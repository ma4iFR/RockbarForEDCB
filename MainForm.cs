using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using EpgTimer;
using Nett;

namespace RockbarForEDCB
{
    /// <summary>
    /// メインフォームクラス
    /// </summary>
    public partial class MainForm : Form
    {
        // 設定情報
        private RockBarSetting rockbarSetting = null;

        // EpgTimerSrv接続可否
        private bool canConnect = true;

        // CtrlCmdの結果格納用
        private List<EpgServiceEventInfo> serviceEvents = new List<EpgServiceEventInfo>();
        private List<TunerReserveInfo> tunerReserveInfos = new List<TunerReserveInfo>();
        private List<ReserveData> reserveDatas = new List<ReserveData>();

        // サービス一覧(+番組)の保持用(TSID + SID → サービス情報(+番組))
        private Dictionary<string, EpgServiceEventInfo> serviceMap = new Dictionary<string, EpgServiceEventInfo>();

        // 番組一覧の保持用(TSID + SID + EventID → 番組情報)
        private Dictionary<string, EpgEventInfo> allEventMap = new Dictionary<string, EpgEventInfo>();

        // 予約情報の保持用(TSID + SID + EventID → 予約情報)
        private Dictionary<string, ReserveData> reserveMap = new Dictionary<string, ReserveData>();

        // CSVサービスリストの格納
        private List<Service> allServiceList = null;
        private List<Service> favoriteServiceList = null;

        // CtrlCmdUtil
        private CtrlCmdUtil ctrlCmdUtil = new CtrlCmdUtil();

        // Rockbarから自動起動したTVTestのプロセス一覧
        private Dictionary<string, System.Diagnostics.Process> tvtestProcesses = new Dictionary<string, System.Diagnostics.Process>();

        // マウスのクリック位置を記憶
        private Point mousePoint;

        // 色の設定情報(設定情報から変数にロードしたもの)
        private Color formBackColor;
        private Color listBackColor;
        private Color foreColor;

        /// <summary>
        /// コンストラクタ
        /// コンフィグの読み込み・CtrlCmdの初期化・初回表示処理を行う。
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            try
            {
                rockbarSetting = Toml.ReadFile<RockBarSetting>(RockbarUtility.GetTomlSettingFilePath());
            }
            catch (FileNotFoundException)
            {
                // TOML設定ファイルが存在しない場合は準正常系として空設定で起動。それ以外の場合は例外を投げる
                rockbarSetting = new RockBarSetting();
            }

            // コンフィグファイルにwidth, height指定時のみ前回位置・サイズ・スプリッタ位置で起動
            if (rockbarSetting.Width != 0 && rockbarSetting.Height != 0)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(rockbarSetting.X, rockbarSetting.Y);
                this.Size = new Size(rockbarSetting.Width, rockbarSetting.Height);
                splitContainer.SplitterDistance = rockbarSetting.SplitterDistance;
            }

            // 設定反映
            applySetting();

            allServiceList = RockbarUtility.GetAllServicesFromSetting();
            favoriteServiceList = RockbarUtility.GetFavoriteServicesFromSetting();

            if (rockbarSetting.UseTcpIp) {
                // Pipe通信にする
                ctrlCmdUtil.SetSendMode(true);
                ctrlCmdUtil.SetNWSetting(rockbarSetting.IpAddress, rockbarSetting.PortNumber);
            }
            else
            {
                // Pipe通信にする
                ctrlCmdUtil.SetSendMode(false);
            }

            // 適当な通信を行って、通信可否を確認し問題があればメッセージを出す
            tunerReserveInfos.Clear();
            ErrCode errCode = ctrlCmdUtil.SendEnumTunerReserve(ref tunerReserveInfos);

            if (errCode != ErrCode.CMD_SUCCESS)
            {
                canConnect = false;
                MessageBox.Show(
                    $"EpgTimerSrvと接続できません。以降の通信を停止します。\nオプション設定を見直してアプリケーションを再起動してください。\n\nErrCode: {errCode}",
                    "EpgTimerSrv接続チェック失敗",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            // 初回表示
            RefreshEvent(true, true);

            // タイマーを有効化
            timer.Enabled = true;
        }

        /// <summary>
        /// ウィンドウプロシージャ
        /// リサイズ機能とダブルクリック無効化をwindowに追加
        /// 参照) https://stackoverflow.com/questions/31199437/borderless-and-resizable-form-c
        /// </summary>
        /// <param name="m">Windowsメッセージ</param>
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 5;

            switch (m.Msg)
            {
                case 0x0084: /*NCHITTEST*/
                    base.WndProc(ref m);

                    if ((int) m.Result == 0x01) /*HTCLIENT*/
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr) 13; /*HTTOPLEFT*/
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr) 12; /*HTTOP*/
                            else
                                m.Result = (IntPtr) 14; /*HTTOPRIGHT*/
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr) 10; /*HTLEFT*/
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr) 2; /*HTCAPTION*/
                            else
                                m.Result = (IntPtr) 11; /*HTRIGHT*/
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr) 16; /*HTBOTTOMLEFT*/
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr) 15; /*HTBOTTOM*/
                            else
                                m.Result = (IntPtr) 17; /*HTBOTTOMRIGHT*/
                        }
                    }
                    return;
                case 0x00A3: // WM_NCLBUTTONDBLCLK
                    // 非クライアント領域のダブルクリックによる最大化無効
                    m.Result = IntPtr.Zero;
                    return;
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// 設定反映処理
        /// 主に見た目部分の設定をフォームに反映する。初回起動時・設定変更時に実行
        /// </summary>
        private void applySetting()
        {
            // タスクトレイアイコン常時表示
            if (rockbarSetting.ShowTaskTrayIcon)
            {
                notifyIcon.Visible = true;
            }
            else
            {
                // 初回起動時・設定画面からの戻りで格納状態はないはず
                notifyIcon.Visible = false;
            }

            // 縦に並べて表示
            if (rockbarSetting.IsHorizontalSplit)
            {
                splitContainer.Orientation = Orientation.Horizontal;
            }
            else
            {
                splitContainer.Orientation = Orientation.Vertical;
            }

            // フォント
            TypeConverter fontConverter = TypeDescriptor.GetConverter(typeof(Font));
            Font font = (Font) fontConverter.ConvertFromString(rockbarSetting.Font);

            serviceListView.Font = font;
            tunerListView.Font = font;
            listContextMenuStrip.Font = font;

            // フォント設定時にチャンネル一覧の2, 3列目の幅を設定(以降固定)
            // applySetting後に必ずServiceListはクリアされるため、1回2, 3列目だけのダミーデータを追加して列幅調整する
            String[] data = {
                "",
                "00:00-00:00",
                "◎",
                ""
            };

            ListViewItem item = new ListViewItem(data);
            // 調整時に目立つので背景色で隠す
            item.ForeColor = serviceListView.BackColor;
            serviceListView.Items.Add(item);
            // 2,3列目を内容で広げる
            serviceListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            serviceListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);

            adjustListViewColumns(serviceListView);
            adjustListViewColumns(tunerListView);

            // 色
            TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));
            this.formBackColor = (Color)colorConverter.ConvertFromString(rockbarSetting.FormBackColor);
            this.listBackColor = (Color)colorConverter.ConvertFromString(rockbarSetting.ListBackColor);
            this.foreColor = (Color)colorConverter.ConvertFromString(rockbarSetting.ForeColor);

            this.BackColor = this.formBackColor;

            serviceListView.BackColor = this.listBackColor;
            serviceListView.ForeColor = this.foreColor;

            tunerListView.BackColor = this.listBackColor;
            tunerListView.ForeColor = this.foreColor;
        }

        /// <summary>
        /// 描画更新処理
        /// 必要があればEpgTimerSrv通信を行い、チャンネルListView・チューナListViewの表示を更新する。
        /// </summary>
        /// <param name="isChannelRefresh">対象チャンネルリストの切り替え要否</param>
        /// <param name="isTrasnmission">EpgTimerSrvと通信要否</param>
        private void RefreshEvent(bool isChannelRefresh, bool isTrasnmission)
        {
            // EpgTimerSrvと通信する
            if (isTrasnmission && canConnect)
            {
                // 予約一覧取得
                reserveDatas.Clear();
                ctrlCmdUtil.SendEnumReserve(ref reserveDatas);

                // 予約一覧関連のハッシュを作成
                reserveMap.Clear();
                foreach (ReserveData reserveData in reserveDatas)
                {
                    // TSID + SID + EventID → 予約一覧
                    reserveMap.Add(RockbarUtility.GetKey(reserveData.TransportStreamID, reserveData.ServiceID, reserveData.EventID), reserveData);
                }

                // 番組情報一覧取得
                serviceEvents.Clear();
                allEventMap.Clear();
                ctrlCmdUtil.SendEnumPgAll(ref serviceEvents);

                // 番組一覧関連のハッシュを作成
                serviceMap.Clear();
                foreach (EpgServiceEventInfo service in serviceEvents)
                {
                    // TSID + SID → サービス一覧(serviceが番組情報を保持している)
                    serviceMap.Add(RockbarUtility.GetKey(service.serviceInfo.TSID, service.serviceInfo.SID), service);

                    // TSID + SID + EventID → 番組情報
                    foreach (EpgEventInfo ev in service.eventList)
                    {
                        allEventMap.Add(RockbarUtility.GetKey(ev.transport_stream_id, ev.service_id, ev.event_id), ev);
                    }
                }

                // チューナーごとの予約一覧取得
                tunerReserveInfos.Clear();
                ctrlCmdUtil.SendEnumTunerReserve(ref tunerReserveInfos);
            }

            // チャンネル一覧・チューナー一覧にキー情報だけでアイテムを表示する(対象放送波切り替え時も実行)
            if (isChannelRefresh)
            {
                serviceListView.Items.Clear();

                List<Service> services = null;

                if (serviceTabControl.SelectedTab.Text == "お気に入り")
                {
                    services = favoriteServiceList;
                }
                else
                {
                    services = allServiceList;
                }

                // チャンネル表示
                foreach (var service in services)
                {
                    string key = RockbarUtility.GetKey(service.Tsid, service.Sid);

                    if (! serviceMap.ContainsKey(key))
                    {
                        // 定義したチャンネルがEDCBからのデータにない場合はスキップ(ユーザには設定画面でわかるようにする)
                        continue;
                    }

                    var matchedService = serviceMap[key];

                    if (serviceTabControl.SelectedTab == dttvTabPage && RockbarUtility.GetServiceType(matchedService.serviceInfo.ONID) != ServiceType.DTTV)
                    {
                        continue;
                    }
                    else if (serviceTabControl.SelectedTab == bsTabPage && RockbarUtility.GetServiceType(matchedService.serviceInfo.ONID) != ServiceType.BS)
                    {
                        continue;
                    }
                    else if (serviceTabControl.SelectedTab == csTabPage && RockbarUtility.GetServiceType(matchedService.serviceInfo.ONID) != ServiceType.CS)
                    {
                        continue;
                    }

                    // 1回キーとチャンネル名だけで追加
                    String[] data = {
                        matchedService.serviceInfo.service_name,
                        "",
                        "",
                        ""
                    };

                    ListViewItem item = new ListViewItem(data);
                    item.Name = key;

                    serviceListView.Items.Add(item);
                }

                adjustListViewColumns(serviceListView);

                filteringLabel.Visible = false;

                tunerListView.Items.Clear();

                // チューナー表示
                foreach (var tuner in tunerReserveInfos)
                {
                    string name = null;
                    
                    // 設定にチューナー名があれば取得し、なければデフォルト名で表示
                    if (rockbarSetting.BonDriverNameToTunerName.ContainsKey(tuner.tunerName))
                    {
                        name = rockbarSetting.BonDriverNameToTunerName[tuner.tunerName];
                    }
                    else
                    {
                        name = RockbarUtility.GetDefaultTunerName(tuner.tunerName);
                    }

                    // 連番付与
                    if (tuner.tunerID != 0xffffffff)
                    {
                        name += (tuner.tunerID & 0xffff).ToString();
                    }

                    // 1回キーとチューナー名だけで追加
                    string[] data = {name, ""};
                    ListViewItem item = new ListViewItem(data);
                    item.Name = tuner.tunerID.ToString();

                    tunerListView.Items.Add(item);
                }

                adjustListViewColumns(tunerListView);
            }

            // チャンネル一覧の追加済みアイテムに対して、現在放送中の番組情報を付与する
            foreach (var service in serviceEvents)
            {
                string key = RockbarUtility.GetKey(service.serviceInfo.TSID, service.serviceInfo.SID);

                var ev = service.eventList.Find(x => x.start_time <= DateTime.Now && x.start_time.AddSeconds(x.durationSec) >= DateTime.Now);

                // チャンネル一覧ListViewでこのサービスが表示対象
                if (serviceListView.Items.ContainsKey(key))
                {
                    ListViewItem item = serviceListView.Items[key];

                    if (ev != null)
                    {
                        // 現在放送中の番組あり
                        string eventKey = RockbarUtility.GetKey(ev.transport_stream_id, ev.service_id, ev.event_id);

                        ReserveStatus reserveStatus = ReserveStatus.NONE;

                        // 予約状態文字列を取得
                        if (reserveMap.ContainsKey(eventKey)) {
                            ReserveData reserveData = reserveMap[eventKey];

                            reserveStatus = ReserveStatus.OK;

                            if (reserveData.OverlapMode == 1)
                            {
                                reserveStatus = ReserveStatus.PARTIAL;
                            }
                            else if (reserveData.OverlapMode == 2)
                            {
                                reserveStatus = ReserveStatus.NG;
                            }
                        }

                        string reserveString = RockbarUtility.GetReserveStatusString(reserveStatus);

                        // 番組情報を表示
                        item.SubItems[1].Text = ev.start_time.ToString("HH:mm") + '-' + ev.start_time.AddSeconds(ev.durationSec).ToString("HH:mm");
                        item.SubItems[2].Text = reserveString;
                        item.SubItems[3].Text = ev.ShortInfo?.event_name;
                        item.ToolTipText = ev.ShortInfo?.event_name;

                        // 色変更
                        switch (reserveStatus)
                        {
                            case ReserveStatus.NONE:
                                item.BackColor = this.listBackColor;
                                break;
                            case ReserveStatus.OK:
                                item.BackColor = Color.DarkSlateGray;
                                break;
                            case ReserveStatus.PARTIAL:
                                item.BackColor = Color.FromArgb(160, 160, 0);
                                break;
                            case ReserveStatus.NG:
                                item.BackColor = Color.Red;
                                break;
                        }
                    }
                    else
                    {
                        // 現在放送中の番組なし
                        item.SubItems[1].Text = "";
                        item.SubItems[2].Text = "";
                        item.SubItems[3].Text = "";
                        item.ToolTipText = "";
                        item.BackColor = this.listBackColor;
                    }
                }
            }

            // チューナー一覧の追加済みアイテムに対して、現在録画中の番組情報を付与する
            foreach (var tuner in tunerReserveInfos)
            {
                // チューナーのListViewItemを拾う
                var item = tunerListView.Items[tuner.tunerID.ToString()];

                // 使用中の予約タイトルとツールチップを表示
                HashSet<uint> reserveIds = tuner.reserveList.ToHashSet();

                List<ReserveData> reserves = reserveDatas.FindAll(x => reserveIds.Contains(x.ReserveID));

                var currentReserve = reserves.Find(x => x.StartTime <= DateTime.Now && x.StartTime.AddSeconds(x.DurationSecond) >= DateTime.Now);

                if (currentReserve != null)
                {
                    item.SubItems[1].Text = currentReserve.Title;
                    item.ToolTipText = currentReserve.Title; ;
                }
                else
                {
                    item.SubItems[1].Text = "";
                    item.ToolTipText = "";
                }

                // 直近30件に限らず、将来変な予約がある場合警告として色を変える
                if (reserves.Count(x => x.OverlapMode == 1) > 0)
                {
                    // 一部録画に1件でも予約が入っている場合、黃背景色で警告
                    item.BackColor = Color.FromArgb(160, 160, 0);
                }
                else if (reserves.Count(x => x.OverlapMode == 2) > 0)
                {
                    // TU不足に1件でも予約が入っている場合、赤背景色で警告
                    item.BackColor = Color.Red;
                }
                else
                {
                    item.BackColor = this.listBackColor;
                }
            }
        }

        /// <summary>
        /// 設定ファイルの再読み込み処理
        /// </summary>
        private void ReloadSetting()
        {
            // 設定ファイルを書き込んだあとの読み込みなので基本的に例外は発生しないはず。発生した場合は例外を投げる
            rockbarSetting = Toml.ReadFile<RockBarSetting>(RockbarUtility.GetTomlSettingFilePath());

            allServiceList = RockbarUtility.GetAllServicesFromSetting();
            favoriteServiceList = RockbarUtility.GetFavoriteServicesFromSetting();
        }

        /// <summary>
        /// フィルタ処理
        /// チャンネル一覧から、フィルタ文字列にチャンネル名も番組名も一致しないチャンネルを削除して表示更新する(大文字・小文字無視)
        /// </summary>
        private void Filter()
        {
            if (filterTextBox.Text != null)
            {
                for (var i = serviceListView.Items.Count - 1; i >= 0; i--)
                {
                    var item = serviceListView.Items[i];

                    if (
                        item.SubItems[0].Text.IndexOf(filterTextBox.Text, StringComparison.OrdinalIgnoreCase) < 0 &&
                        item.SubItems[3].Text.IndexOf(filterTextBox.Text, StringComparison.OrdinalIgnoreCase) < 0
                    )
                    {
                        serviceListView.Items.RemoveAt(i);
                    }
                }

                filteringLabel.Visible = true;
            }

            serviceListView.Refresh();
        }

        /// <summary>
        /// 番組の右クリックコンテキストメニューItem作成処理
        /// 番組情報・予約情報からチャンネル一覧・チューナー一覧用のコンテキストメニューitemを作成する。
        /// </summary>
        /// <param name="ev">番組情報</param>
        /// <param name="reserve">予約情報</param>
        /// <param name="isTuner">チューナー一覧用？</param>
        /// <returns></returns>
        private ToolStripMenuItem createEventToolStripMenuItem(EpgEventInfo ev, ReserveData reserve, bool isTuner)
        {
            ReserveStatus reserveStatus = ReserveStatus.NONE;

            // 予約ステータスを判別
            if (reserve != null)
            {
                if (reserve.OverlapMode == 0)
                {
                    if (ev == null)
                    {
                        reserveStatus = ReserveStatus.DISAPPEARED;
                    }
                    else
                    {
                        reserveStatus = ReserveStatus.OK;
                    }
                }
                else if (reserve.OverlapMode == 1)
                {
                    reserveStatus = ReserveStatus.PARTIAL;
                }
                else
                {
                    reserveStatus = ReserveStatus.NG;
                }
            }

            ToolStripMenuItem item = new ToolStripMenuItem();

            // 録画ステータスに異常があれば色を変える
            switch (reserveStatus)
            {
                case ReserveStatus.OK:
                    if (!isTuner)
                    {
                        item.BackColor = Color.FromArgb(192, 192, 225);
                    }
                    break;
                case ReserveStatus.PARTIAL:
                    item.BackColor = Color.Yellow;
                    break;
                case ReserveStatus.NG:
                    item.BackColor = Color.Red;
                    break;
            }

            string reserveString = RockbarUtility.GetReserveStatusString(reserveStatus);

            if (isTuner)
            {
                // チューナーから開いた場合は予約情報を表示(必ず予約情報あり)
                item.Text = reserve.StartTime.ToString("MM/dd HH:mm") + "～" + reserve.StartTime.AddSeconds(reserve.DurationSecond).ToString("HH:mm") + "  " +
                    reserveString + "    " + reserve.StationName + "    " + reserve.Title;
            }
            else
            {
                // サービスから開いた場合は番組情報を表示(必ず番組情報あり)
                item.Text = ev.start_time.ToString("MM/dd HH:mm") + "～" + ev.start_time.AddSeconds(ev.durationSec).ToString("HH:mm") + "  " +
                    reserveString + "  " + ev.ShortInfo?.event_name;
            }

            // 番組情報がある場合はサブメニューに番組情報を追加
            if (ev != null)
            {
                // Webリンク使用時のみ1行目にWebリンク用のボタンを表示
                if (rockbarSetting.UseWebLink)
                {
                    item.DropDownItems.Add(">>");
                    item.DropDownItems[item.DropDownItems.Count - 1].Click += (s2, e2) =>
                    {
                        string url = rockbarSetting.WebLinkUrl;
                        url = url.Replace("{ONID}", ev.original_network_id.ToString());
                        url = url.Replace("{TSID}", ev.transport_stream_id.ToString());
                        url = url.Replace("{SID}", ev.service_id.ToString());
                        url = url.Replace("{EID}", ev.event_id.ToString());

                        try
                        {
                            // URLがパースできるかどうかを事前判定しておく
                            new Uri(url);

                            var startInfo = new System.Diagnostics.ProcessStartInfo(url);
                            startInfo.UseShellExecute = true;
                            System.Diagnostics.Process.Start(startInfo);
                        }
                        catch
                        {
                            MessageBox.Show($"Web番組詳細URLが不正です。Web番組詳細URLの設定を見直してください。\nURL: {url}", "ブラウザ起動エラー");
                            return;
                        }
                    };

                    item.DropDownItems.Add(new ToolStripSeparator());
                }

                // 基本情報をサブメニューに追加
                var shortStrs = RockbarUtility.BreakString(ev.ShortInfo?.text_char);

                if (shortStrs != null)
                {
                    foreach (string str in shortStrs)
                    {
                        item.DropDownItems.Add(str);
                        item.DropDownItems[item.DropDownItems.Count - 1].Enabled = false;
                    }

                }

                item.DropDownItems.Add(new ToolStripSeparator());

                // 拡張情報をサブメニューに追加
                var longStrs = RockbarUtility.BreakString(ev.ExtInfo?.text_char);

                if (longStrs != null)
                {
                    foreach (string str in longStrs)
                    {
                        item.DropDownItems.Add(str);
                        item.DropDownItems[item.DropDownItems.Count - 1].Enabled = false;
                    }
                }
            }

            return item;
        }

        /// <summary>
        /// リストビューカラム幅調整処理
        /// 1列目を内容に合わせ、最終列コントロールいっぱいまで広げる。
        /// </summary>
        /// <param name="listView">対象リストビュー</param>
        private void adjustListViewColumns(ListView listView)
        {
            // 1列目を内容で広げる
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);

            // 1列目・最終列以外は固定幅
            int columnWidth = 0;

            for (var i = 0; i < listView.Columns.Count - 1; i++)
            {
                columnWidth += listView.Columns[i].Width;
            }

            // 最終列をいっぱいに広げる
            listView.Columns[listView.Columns.Count - 1].Width = listView.ClientRectangle.Width - columnWidth - 2;
        }

        /// <summary>
        /// TVTest起動処理
        /// TSID, SIDを指定してTVTestを起動する。地デジ・BS/CSで異なるオプションを使用する。
        /// </summary>
        /// <param name="isDttv">地デジ？</param>
        /// <param name="tsid">TSID</param>
        /// <param name="sid">SID</param>
        /// <returns>TVTestプロセス</returns>
        private System.Diagnostics.Process startTvTest(bool isDttv, uint tsid, uint sid)
        {
            System.Diagnostics.Process result = null;

            try
            {
                if (isDttv)
                {
                    result = System.Diagnostics.Process.Start(rockbarSetting.TvtestPath, $"{rockbarSetting.TvtestDttvOption} /tsid {tsid} /sid {sid}");
                }
                else
                {
                    result = System.Diagnostics.Process.Start(rockbarSetting.TvtestPath, $"{rockbarSetting.TvtestBscsOption} /tsid {tsid} /sid {sid}");
                }
            }
            catch
            {
                MessageBox.Show("TVTestの起動に失敗しました。TVTestの設定を見直してください。", "TVTest起動エラー");
            }

            return result;
        }

    /// <summary>
    /// チャンネル一覧マウスクリック時処理
    /// 右クリック時、直近30件の番組情報をコンテキストメニューに表示。
    /// </summary>
    /// <param name="sender">イベントソース</param>
    /// <param name="e">イベントパラメータ</param>
    private void serviceListView_MouseClick(object sender, MouseEventArgs e)
        {
            // 右クリック
            // 現在の番組を含め、今後の番組を30件までコンテキストメニューで表示(TVRockの仕様踏襲)
            if (e.Button == MouseButtons.Right)
            {
                // クリックした箇所が自動選択されるので拾う
                var selected = serviceListView.SelectedItems[0];

                listContextMenuStrip.Items.Clear();

                EpgServiceEventInfo sv = serviceMap[selected.Name];

                var afterEventList = sv.eventList.FindAll(x => x.start_time.AddSeconds(x.durationSec) >= DateTime.Now).OrderBy(a => a.start_time);

                int i = 0;

                foreach (var ev in afterEventList)
                {
                    string eventKey = RockbarUtility.GetKey(ev.transport_stream_id, ev.service_id, ev.event_id);

                    ReserveData reserveData = null;
                    
                    if (reserveMap.ContainsKey(eventKey))
                    {
                        reserveData = reserveMap[eventKey];
                    }

                    listContextMenuStrip.Items.Add(createEventToolStripMenuItem(ev, reserveData, false));

                    i++;

                    if (i >= 30)
                    {
                        break;
                    }
                }

                listContextMenuStrip.Show((Control) sender, new Point(0, e.Y) );
            }
        }

        /// <summary>
        /// チャンネル一覧マウスダブルクリック処理
        /// TVTest使用オプションがONの場合、カーソル箇所の番組を対象にTVTestを起動する。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void serviceListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // TVTest使用時のみ
            if (! rockbarSetting.UseDoubleClickTvtest)
            {
                return;
            }

            // 左ダブルクリック
            // TVTestを起動する
            if (e.Button == MouseButtons.Left)
            {
                // クリックした箇所が自動選択されるので拾う
                var selected = serviceListView.SelectedItems[0];

                EpgServiceEventInfo sv = serviceMap[selected.Name];

                if (RockbarUtility.GetServiceType(sv.serviceInfo.ONID) == ServiceType.DTTV) {
                    // 地上波
                    startTvTest(true, sv.serviceInfo.TSID, sv.serviceInfo.SID);
                }
                else
                {
                    // BS, CS
                    startTvTest(false, sv.serviceInfo.TSID, sv.serviceInfo.SID);
                }
            }
        }

        /// <summary>
        /// チューナー一覧マウスクリック時処理
        /// 右クリック時、直近30件の予約情報をコンテキストメニューに表示。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void tunerListView_MouseClick(object sender, MouseEventArgs e)
        {
            // 右クリック
            // 今後の予約を30件までコンテキストメニューで表示
            //TODO DRY
            if (e.Button == MouseButtons.Right)
            {
                // クリックした箇所が自動選択されるので拾う
                var selected = tunerListView.SelectedItems[0];

                listContextMenuStrip.Items.Clear();

                TunerReserveInfo tunerReserveInfo = tunerReserveInfos.Find((TunerReserveInfo x) => x.tunerID.ToString() == selected.Name);

                // TunerReserveInfoには予約IDしか入っていないので、ReserveDataから予約情報を取り直す
                HashSet<uint> reserveIds = tunerReserveInfo.reserveList.ToHashSet();

                var reserves = reserveDatas.FindAll(x => reserveIds.Contains(x.ReserveID)).OrderBy(x => x.StartTime);

                int i = 0;

                foreach (var reserveData in reserves)
                {
                    string key = RockbarUtility.GetKey(reserveData.TransportStreamID, reserveData.ServiceID, reserveData.EventID);

                    EpgEventInfo ev = null;

                    if (allEventMap.ContainsKey(key))
                    {
                        ev = allEventMap[key];
                    }

                    listContextMenuStrip.Items.Add(createEventToolStripMenuItem(ev, reserveData, true));

                    i++;

                    if (i >= 30)
                    {
                        break;
                    }
                }

                listContextMenuStrip.Show((Control)sender, new Point(0, e.Y));
            }
        }

        /// <summary>
        /// タイマー処理
        /// 毎分0秒のEpgTimerSrv通信と、TVTestの起動・終了を行う
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime timerTime = DateTime.Now;

            if (timerTime.Second == 0) {
                RefreshEvent(false, true);
            }
            
            if (! rockbarSetting.IsAutoOpenTvtest)
            {
                return;
            }

            // TVTest自動起動
            // 実実装としては毎秒チェックするのではなく、毎分(59-マージン)秒タイミングで次の1分間に始まる番組をオープンする
            if (timerTime.Second == (59 - rockbarSetting.AutoOpenMargin)) {
                // 0の場合はこの1分間なので59秒加算
                DateTime checkTime = timerTime.AddSeconds(59);

                // お気に入りサービスのキー(大した件数ではない想定なので毎秒計算し直しで良いものとする)
                HashSet<string> favoriteServiceKeys = favoriteServiceList.Select(x => RockbarUtility.GetKey(x.Tsid, x.Sid)).ToHashSet();

                foreach (var reserve in reserveDatas)
                {
                    if (reserve.StartTime.Date == checkTime.Date && reserve.StartTime.Hour == checkTime.Hour && reserve.StartTime.Minute == checkTime.Minute)
                    {
                        string key = RockbarUtility.GetKey(reserve.TransportStreamID, reserve.ServiceID);

                        // すでに自動起動中のTVTestとTSID・SIDが同一の場合、(TVTest側でチャンネルが変わっていない前提で)起動スキップする
                        if (tvtestProcesses.ContainsKey(key))
                        {
                            continue;
                        }

                        // お気に入りサービスオプションが設定されている場合、お気に入りサービスにキーが含まれていなかったらスキップ
                        if (rockbarSetting.IsAutoOpenTvtestFavoriteService && ! favoriteServiceKeys.Contains(key)) 
                        {
                            continue;
                        }

                        // 地上波
                        if (RockbarUtility.GetServiceType(reserve.OriginalNetworkID) == ServiceType.DTTV && rockbarSetting.IsAutoOpenTvtestDttv)
                        {
                            var p = startTvTest(true, reserve.TransportStreamID, reserve.ServiceID);
                            tvtestProcesses.Add(key, p);
                        }

                        // BS, CS
                        if (
                            RockbarUtility.GetServiceType(reserve.OriginalNetworkID) == ServiceType.BS && rockbarSetting.IsAutoOpenTvtestBs ||
                            RockbarUtility.GetServiceType(reserve.OriginalNetworkID) == ServiceType.CS && rockbarSetting.IsAutoOpenTvtestCs
                        )
                        {
                            var p = startTvTest(false, reserve.TransportStreamID, reserve.ServiceID);
                            tvtestProcesses.Add(key, p);
                        }
                    }
                }
            }

            // TVTest自動終了
            // 現時点のオプションにかかわらず、自身が開いたTVTestは予約終了時間でクローズ
            // 実実装としては毎秒チェックするのではなく、毎分マージン秒タイミングで現在放送してない番組をクローズ
            if (timerTime.Second == rockbarSetting.AutoCloseMargin)
            {
                // 閉じてるプロセスは取り除く
                var keys = tvtestProcesses.Keys.ToList();

                foreach (var key in keys)
                {
                    try
                    {
                        if (tvtestProcesses[key].HasExited)
                        {
                            tvtestProcesses.Remove(key);
                        }
                    }
                    catch
                    {
                        // 何らかの理由でプロセスにアクセスできない場合もキーを削除
                        tvtestProcesses.Remove(key);
                    }
                }

                // 把握してる生存プロセスの中で、録画放送に該当してるものがない場合はクローズ
                Dictionary<string, ReserveData> currentReserves = new Dictionary<string, ReserveData>();

                // 現在放送中番組を抽出
                foreach (var data in reserveDatas)
                {
                    // 途中処理があまりに遅いと、タイマー開始時とNowでズレが生じる可能性あり。問題がでたら検討
                    if (data.StartTime < DateTime.Now && data.StartTime.AddSeconds(data.DurationSecond) > DateTime.Now)
                    {
                        var key = RockbarUtility.GetKey(data.TransportStreamID, data.ServiceID);

                        // 予約方法次第で同一番組が二重に登録されているケースあり
                        if (! currentReserves.ContainsKey(key))
                        {
                            currentReserves.Add(key, data);
                        }
                    }
                }

                // 放送中番組でないTVTestを閉じる
                foreach (var p in tvtestProcesses)
                {
                    if (! currentReserves.ContainsKey(p.Key))
                    {
                        try
                        {
                            p.Value.CloseMainWindow();
                        }
                        catch
                        {
                            // 何らかの理由でプロセスがクローズできない場合
                            // 想定外ケースなのでここに落ちる場合は原因究明要
                        }
                    }
                }
            }
        }

        /// <summary>
        /// チャンネルタブ切り替え処理
        /// EpgTimerSrv通信せずに、対象チャンネルの表示切替を行う
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void serviceTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEvent(true, false);
        }

        /// <summary>
        /// ✕ボタン押下処理
        /// タスクトレイ格納オプションON時、タスクトレイに格納。そうでない場合、フォームを閉じる
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            if (rockbarSetting.StoreTaskTrayByClosing)
            {
                // 他のオプションにかかわらず、最小化(もどき)をする場合はタスクトレイにアイコンを表示する
                notifyIcon.Visible = true;
                this.Visible = false;
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// メインフォームマウスボタン押下処理
        /// ドラッグ時の位置取得。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }

            // フォームと同様にドラッグしたいラベルはEnabled = falseにしておく
        }

        /// <summary>
        /// メインフォームマウス移動処理
        /// ドラッグ時フォーム移動処理。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }


        /// <summary>
        /// フィルタ入力欄キー押下処理
        /// Enter入力時にフィルタを行う。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filter();
            }
        }

        /// <summary>
        /// リセットボタン押下処理
        /// フィルタ文字列をクリアしフィルタ結果をリセットする。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Clear();
            RefreshEvent(true, false);
        }

        /// <summary>
        /// フィルタボタン押下処理
        /// フィルタを行う。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void filterButton_Click(object sender, EventArgs e)
        {
            Filter();
        }

        /// <summary>
        /// 設定ボタン押下処理
        /// 設定フォームを開き、設定変更があった場合は設定を再読込して画面をリフレッシュする。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(ctrlCmdUtil, canConnect);
            DialogResult result = settingForm.ShowDialog();
            settingForm.Dispose();

            if (result == DialogResult.OK)
            {
                ReloadSetting();
                applySetting();
                RefreshEvent(true, true);
            }
        }

        /// <summary>
        /// フォームクローズ中処理
        /// フォームクローズ時に、位置・サイズ情報を設定ファイルに出力する。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            rockbarSetting.X = this.Location.X;
            rockbarSetting.Y = this.Location.Y;
            rockbarSetting.Width = this.Size.Width;
            rockbarSetting.Height = this.Size.Height;
            rockbarSetting.SplitterDistance = splitContainer.SplitterDistance;

            Toml.WriteFile(rockbarSetting, RockbarUtility.GetTomlSettingFilePath());
        }

        /// <summary>
        /// タスクトレイ終了コンテキストメニュークリック処理
        /// フォームを閉じる。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// タスクトレイアイコンマウスボタン押下処理
        /// トグルオプションONの場合、表示・非表示切り替え＋アクティブ化。それ以外の場合アクテイブ化のみ
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (this.Visible)
                {
                    // フォーム表示時に左クリックした場合はオプションにより挙動切り替え
                    if (rockbarSetting.ToggleVisibleTaskTrayIconClick)
                    {
                        this.Visible = false;
                    }
                    else
                    {
                        this.Activate();
                    }
                }
                else
                {
                    // フォーム非表示時に左クリックした場合は必ず表示
                    this.Visible = true;
                    this.Activate();

                    // オプションによりタスクトレイアイコン表示を切り替え
                    if (! rockbarSetting.ShowTaskTrayIcon)
                    {
                        notifyIcon.Visible = false;
                    }
                }
            }
        }

        /// <summary>
        /// フォームサイズ変更処理
        /// 左右のリストビューのカラム幅を調整する。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            adjustListViewColumns(serviceListView);
            adjustListViewColumns(tunerListView);
        }

        /// <summary>
        /// スプリッタ位置調整処理
        /// 左右のリストビューのカラム幅を調整する。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            adjustListViewColumns(serviceListView);
            adjustListViewColumns(tunerListView);
        }

    }
}
