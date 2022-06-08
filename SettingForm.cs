using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EpgTimer;
using Nett;

namespace RockbarForEDCB
{
    /// <summary>
    /// 設定フォームクラス
    /// </summary>
    public partial class SettingForm : Form
    {
        // ListViewのソーター。ListViewにセットすると自動整列解除できないため、適宜ListViewにセットする。
        private ListViewItemComparer allServiceListViewSorter = new ListViewItemComparer();
        private ListViewItemComparer selectedServiceListViewSorter = new ListViewItemComparer();
        private ListViewItemComparer selectedServiceListView2Sorter = new ListViewItemComparer();
        private ListViewItemComparer favoriteServiceListViewSorter = new ListViewItemComparer();
        private ListViewItemComparer tunerNameListViewSorter = new ListViewItemComparer();

        // CtrlCmdUtil
        private CtrlCmdUtil ctrlCmdUtil = null;

        // CtrlCmdの結果格納用
        private List<EpgServiceInfo> serviceInfos = new List<EpgServiceInfo>();
        private List<TunerReserveInfo> tunerReserveInfos = new List<TunerReserveInfo>();

        /// <summary>
        /// ListView用の比較クラス
        /// ListViewごとに作成・状態保持しておき、列ヘッダクリックごとにソートを行う
        /// </summary>
        public class ListViewItemComparer : IComparer
        {
            private int columnIndex = -1;
            private SortOrder sortOrder = SortOrder.Ascending;

            /// <summary>
            /// 列index更新処理
            /// </summary>
            /// <param name="columnIndex">列index</param>
            public void setColumn(int columnIndex)
            {
                // 同じカラムがクリックされた場合はソート方向を反転
                if (this.columnIndex == columnIndex)
                {
                    if (this.sortOrder == SortOrder.Ascending)
                    {
                        this.sortOrder = SortOrder.Descending;
                    }
                    else
                    {
                        this.sortOrder = SortOrder.Ascending;
                    }
                }
                else
                {
                    this.sortOrder = SortOrder.Ascending;
                }

                this.columnIndex = columnIndex;
            }

            /// <summary>
            /// 比較処理
            /// 要素1<要素2 → 負, 要素1>要素2 → 正, 要素1=要素2 → 0
            /// </summary>
            /// <param name="x1">要素1</param>
            /// <param name="x2">要素2</param>
            /// <returns>比較結果</returns>
            public int Compare(object x1, object x2)
            {
                if (columnIndex < 0)
                {
                    return 0;
                }

                ListViewItem item1 = (ListViewItem) x1;
                ListViewItem item2 = (ListViewItem) x2;

                int result = string.Compare(item1.SubItems[columnIndex].Text, item2.SubItems[columnIndex].Text);

                if (this.sortOrder == SortOrder.Descending)
                {
                    result *= -1;
                }

                return result;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// 設定ファイルを読み込み画面表示する。
        /// サービス一覧を取得し、全サービスとしてリストに表示する。
        /// </summary>
        /// <param name="ctrlCmdUtil"></param>
        /// <param name="canConnect"></param>
        public SettingForm(CtrlCmdUtil ctrlCmdUtil, bool canConnect)
        {
            InitializeComponent();

            this.ctrlCmdUtil = ctrlCmdUtil;

            // セッティングを読み込んで画面表示
            RockBarSetting setting = null;

            try
            {
                setting = Toml.ReadFile<RockBarSetting>(RockbarUtility.GetTomlSettingFilePath());
            }
            catch (FileNotFoundException)
            {
                // TOML設定ファイルが存在しない場合は準正常系として空設定で起動。それ以外の場合は例外を投げる
                setting = new RockBarSetting();
            }

            useTcpIpCheckbox.Checked = setting.UseTcpIp;
            ipAddressTextBox.Text = setting.IpAddress;

            // 設定値異常の場合、下限にする
            if (setting.PortNumber > portNumberNumericUpDown.Maximum || setting.PortNumber < portNumberNumericUpDown.Minimum) {
                portNumberNumericUpDown.Value = portNumberNumericUpDown.Minimum;
            }
            else
            {
                portNumberNumericUpDown.Value = setting.PortNumber;
            }
            useWebLinkCheckBox.Checked = setting.UseWebLink;
            webLinkUrlTextBox.Text = setting.WebLinkUrl;

            tvtestPathTextBox.Text = setting.TvtestPath;
            tvtestBscsOptionTextBox.Text = setting.TvtestBscsOption;
            tvtestDttvOptionTextBox.Text = setting.TvtestDttvOption;
            useDoubleClickTvtestCheckBox.Checked = setting.UseDoubleClickTvtest;
            isAutoOpenTvtestCheckBox.Checked = setting.IsAutoOpenTvtest;
            isAutoOpenDttvCheckBox.Checked = setting.IsAutoOpenTvtestDttv;
            isAutoOpenBsCheckBox.Checked = setting.IsAutoOpenTvtestBs;
            isAutoOpenCsCheckBox.Checked = setting.IsAutoOpenTvtestCs;
            isAutoOpenFavoriteServiceCheckBox.Checked = setting.IsAutoOpenTvtestFavoriteService;
            showTaskTraiIconCheckBox.Checked = setting.ShowTaskTrayIcon;
            storeTaskTrayByClosingCheckBox.Checked = setting.StoreTaskTrayByClosing;
            toggleVisibleTaskTrayIconClickCheckBox.Checked = setting.ToggleVisibleTaskTrayIconClick;
            isHorizontalSplitCheckBox.Checked = setting.IsHorizontalSplit;
            fontTextBox.Text = setting.Font;

            TypeConverter fontConverter = TypeDescriptor.GetConverter(typeof(Font));
            foreColorLabel.Font = (Font)fontConverter.ConvertFromString(setting.Font);

            formBackColorTextBox.Text = setting.FormBackColor;
            listBackColorTextBox.Text = setting.ListBackColor;
            foreColorTextBox.Text = setting.ForeColor;

            TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));

            formBackColorPanel.BackColor = (Color)colorConverter.ConvertFromString(setting.FormBackColor);
            listBackColorPanel.BackColor = (Color)colorConverter.ConvertFromString(setting.ListBackColor);
            foreColorLabel.ForeColor = (Color)colorConverter.ConvertFromString(setting.ForeColor);

            // 設定値異常の場合、下限にする
            if (setting.AutoOpenMargin > autoOpenMarginNumericUpDown.Maximum || setting.AutoOpenMargin < autoOpenMarginNumericUpDown.Minimum)
            {
                autoOpenMarginNumericUpDown.Value = autoOpenMarginNumericUpDown.Minimum;
            }
            else
            {
                autoOpenMarginNumericUpDown.Value = setting.AutoOpenMargin;
            }

            // 設定値異常の場合、下限にする
            if (setting.AutoCloseMargin > autoCloseMarginNumericUpDown.Maximum || setting.AutoCloseMargin < autoCloseMarginNumericUpDown.Minimum)
            {
                autoCloseMarginNumericUpDown.Value = autoCloseMarginNumericUpDown.Minimum;
            }
            else
            {
                autoCloseMarginNumericUpDown.Value = setting.AutoCloseMargin;
            }

            // サービス一覧取得
            serviceInfos.Clear();
            tunerReserveInfos.Clear();

            if (canConnect)
            {
                ctrlCmdUtil.SendEnumTunerReserve(ref tunerReserveInfos);
                ctrlCmdUtil.SendEnumService(ref serviceInfos);
            }

            // チューナー一覧の表示
            foreach (TunerReserveInfo tunerReserveInfo in tunerReserveInfos)
            {
                if (!tunerNameListView.Items.ContainsKey(tunerReserveInfo.tunerName)) {
                    String[] data = null;

                    if (setting.BonDriverNameToTunerName.ContainsKey(tunerReserveInfo.tunerName))
                    {
                        data = new []{
                            "",
                            (tunerReserveInfo.tunerID & 0xffff0000).ToString("x8").Substring(0, 4),
                            tunerReserveInfo.tunerName,
                            setting.BonDriverNameToTunerName[tunerReserveInfo.tunerName]
                        };

                    }
                    else
                    {
                        data = new []{
                            "",
                            (tunerReserveInfo.tunerID & 0xffff0000).ToString("x8").Substring(0, 4),
                            tunerReserveInfo.tunerName,
                            RockbarUtility.GetDefaultTunerName(tunerReserveInfo.tunerName)
                        };
                    }

                    ListViewItem item = new ListViewItem(data);
                    item.Name = tunerReserveInfo.tunerName;
                    tunerNameListView.Items.Add(item);
                }
            }

            // 取得したチューナに含まれず、設定にだけあるものを一応表示
            foreach (var kv in setting.BonDriverNameToTunerName)
            {
                // ListView上になければ追加しておく
                if (!tunerNameListView.Items.ContainsKey(kv.Key))
                {
                    String[] data = {
                        "！",
                        "",
                        kv.Key,
                        kv.Value
                    };

                    ListViewItem item = new ListViewItem(data);
                    item.Name = kv.Key;
                    tunerNameListView.Items.Add(item);
                }
            }

            // 全チャンネルの表示
            foreach (EpgServiceInfo epgServiceInfo in serviceInfos)
            {
                ServiceType serviceType = RockbarUtility.GetServiceType(epgServiceInfo.ONID);

                string type = RockbarUtility.GetShortServiceTypeName(serviceType);

                String[] data = {
                    "",
                    type,
                    epgServiceInfo.service_name,
                    epgServiceInfo.TSID.ToString(),
                    epgServiceInfo.SID.ToString()
                };

                ListViewItem item = new ListViewItem(data);
                item.Name = RockbarUtility.GetKey(epgServiceInfo.TSID, epgServiceInfo.SID);

                allServiceListView.Items.Add(item);
            }

            // 設定ファイルの選択サービス一覧の表示
            List<Service> selectedServices = RockbarUtility.GetAllServicesFromSetting();

            foreach (Service service in selectedServices)
            {
                string key = RockbarUtility.GetKey(service.Tsid, service.Sid);

                if (allServiceListView.Items.ContainsKey(key))
                {
                    // 登録済みはチェック表示
                    ListViewItem targetItem = allServiceListView.Items[key];
                    ListViewItem item = (ListViewItem) targetItem.Clone();
                    item.Name = targetItem.Name;
                    selectedServiceListView.Items.Add(item);

                    checkServiceItem(targetItem);
                }
                else
                {
                    // EpgTimerSrv側のサービス一覧に一致しない場合は異常データ
                    String[] data = {
                        "！",
                        "",
                        "",
                        service.Tsid.ToString(),
                        service.Sid.ToString()
                    };

                    ListViewItem abnormalItem = new ListViewItem(data);
                    abnormalItem.Name = RockbarUtility.GetKey(service.Tsid, service.Sid);
                    selectedServiceListView.Items.Add(abnormalItem);
                };
            }

            // 設定ファイルのお気に入りサービス一覧の仮表示
            List<Service> favoriteServices = RockbarUtility.GetFavoriteServicesFromSetting();

            foreach (Service service in favoriteServices)
            {
                // 1回キーとTSID, SIDだけで追加
                String[] data = {
                    "",
                    "",
                    "",
                    service.Tsid.ToString(),
                    service.Sid.ToString()
                };

                ListViewItem item = new ListViewItem(data);
                item.Name = RockbarUtility.GetKey(service.Tsid, service.Sid);
                favoriteServiceListView.Items.Add(item);
            }
        }

        /// <summary>
        /// サービスへのチェック処理
        /// 1列目に✔を表示して色を変える。
        /// </summary>
        /// <param name="item">ListViewアイテム</param>
        private void checkServiceItem(ListViewItem item)
        {
            item.SubItems[0].Text = "✔";
            item.BackColor = Color.LightGray;
        }

        /// <summary>
        /// サービス追加処理
        /// 左リストビューで選択中のサービスを右リストビューに追加し、左リストビューのアイテムにチェックをつけて選択をクリアする。
        /// </summary>
        /// <param name="leftListView">左ListView</param>
        /// <param name="rightListView">右ListView</param>
        private void addService(ListView leftListView, ListView rightListView)
        {
            // >>ボタン
            foreach (ListViewItem item in leftListView.SelectedItems)
            {
                string key = item.Name;

                if (!rightListView.Items.ContainsKey(key))
                {
                    ListViewItem targetItem = leftListView.Items[key];

                    ListViewItem newItem = (ListViewItem)targetItem.Clone();
                    newItem.Name = key;
                    rightListView.Items.Add(newItem);

                    checkServiceItem(targetItem);
                }
            }

            leftListView.SelectedItems.Clear();
        }

        /// <summary>
        /// 選択サービス追加処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void addSelectedServiceButton_Click(object sender, EventArgs e)
        {
            addService(allServiceListView, selectedServiceListView);
        }

        /// <summary>
        /// お気に入りサービス追加処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void addFavoriteServiceButton_Click(object sender, EventArgs e)
        {
            addService(selectedServiceListView2, favoriteServiceListView);
        }

        /// <summary>
        /// サービス削除処理
        /// 右リストビューで選択中のサービスを右リストビューから削除し、左リストビューのアイテムのチェックを外して選択をクリアする。
        /// </summary>
        /// <param name="leftListView">左ListView</param>
        /// <param name="rightListView">右ListView</param>
        private void removeServiceButton(ListView leftListView, ListView rightListView)
        {
            // <<ボタン
            foreach (ListViewItem item in rightListView.SelectedItems)
            {
                rightListView.Items.Remove(item);

                if (leftListView.Items.ContainsKey(item.Name))
                {
                    // mark列は共通なので全サービス一覧のindexを取って問題ない
                    leftListView.Items[item.Name].SubItems[allServiceMarkColumnHeader.Index].Text = "";
                    leftListView.Items[item.Name].BackColor = Color.White;
                }
            }

            // 選択をクリア
            rightListView.SelectedItems.Clear();
        }

        /// <summary>
        /// 選択サービス削除処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void removeServiceButton_Click(object sender, EventArgs e)
        {
            removeServiceButton(allServiceListView, selectedServiceListView);
        }

        /// <summary>
        /// お気に入りサービス削除処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void removeFavoriteServiceButton_Click(object sender, EventArgs e)
        {
            removeServiceButton(selectedServiceListView2, favoriteServiceListView);
        }

        /// <summary>
        /// アイテム上移動処理
        /// 対象ListViewの選択中のItemをひとつ上に移動する。複数箇所の選択に対応する。
        /// </summary>
        /// <param name="listview">対象ListView</param>
        private void moveUp(ListView listview)
        {
            // ↑処理
            int selectedEndIndex = -1;

            // 選択されたアイテムを範囲ごとにリスト化
            List<(int, int)> ranges = new List<(int, int)>();

            for (int i = listview.Items.Count - 1; i >= 0; i--)
            {
                if (listview.Items[i].Selected)
                {
                    if (selectedEndIndex < 0)
                    {
                        selectedEndIndex = i;
                    }
                }
                else if (selectedEndIndex >= 0)
                {
                    ranges.Add((i + 1, selectedEndIndex));
                    selectedEndIndex = -1;
                }
            }

            // 末尾処理不要(リストの先頭行を含む選択範囲は移動しない)

            foreach ((int startIndex, int endIndex) in ranges)
            {
                // startindexのひとつ上を削除して、endIndexにinsertする
                ListViewItem tempItem = listview.Items[startIndex - 1];
                listview.Items.Remove(tempItem);
                listview.Items.Insert(endIndex, tempItem);
            }
        }

        /// <summary>
        /// 選択サービス上移動処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void moveUpSelectedServiceButton_Click(object sender, EventArgs e)
        {
            moveUp(selectedServiceListView);
        }

        /// <summary>
        /// お気に入りサービス上移動処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void moveUpFavoriteServiceButton_Click(object sender, EventArgs e)
        {
            moveUp(favoriteServiceListView);
        }

        /// <summary>
        /// アイテム下移動処理
        /// 対象ListViewの選択中のItemをひとつ下に移動する。複数箇所の選択に対応する。
        /// </summary>
        /// <param name="listview"></param>
        private void moveDown(ListView listview)
        {
            // ↓処理
            int selectedStartIndex = -1;

            // 選択されたアイテムを範囲ごとにリスト化
            List<(int, int)> ranges = new List<(int, int)>();

            for (int i = 0; i < listview.Items.Count; i++)
            {
                if (listview.Items[i].Selected)
                {
                    if (selectedStartIndex < 0)
                    {
                        selectedStartIndex = i;
                    }
                }
                else if (selectedStartIndex >= 0)
                {
                    ranges.Add((selectedStartIndex, i - 1));
                    selectedStartIndex = -1;
                }
            }

            // 末尾処理不要(リストの最終行を含む選択範囲は移動しない)

            foreach ((int startIndex, int endIndex) in ranges)
            {
                // 下へ移動
                // startindexのひとつ下を削除して、startIndexにinsertする
                ListViewItem tempItem = listview.Items[endIndex + 1];
                listview.Items.Remove(tempItem);
                listview.Items.Insert(startIndex, tempItem);
            }
        }

        /// <summary>
        /// 選択サービス下移動処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void moveDownSelectedServiceButton_Click(object sender, EventArgs e)
        {
            moveDown(selectedServiceListView);
        }

        /// <summary>
        /// お気に入りサービス下移動処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void moveDownFavoriteServiceButton_Click(object sender, EventArgs e)
        {
            moveDown(favoriteServiceListView);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            // TOMLだと編集しづらいかもしれないので、チャンネル系はTSVに保存
            // 選択チャンネル
            List<Service> selectedServices = new List<Service>();

            foreach (ListViewItem item in selectedServiceListView.Items)
            {
                selectedServices.Add(new Service {
                    Tsid = item.SubItems[selectedServiceTsidColumnHeader.Index].Text,
                    Sid = item.SubItems[selectedServiceSidColumnHeader.Index].Text,
                    Name = item.SubItems[selectedServiceNameColumnHeader.Index].Text
                });
            }

            RockbarUtility.SaveAllServicesToSetting(selectedServices);

            // お気に入りチャンネル
            List<Service> favoriteServices = new List<Service>();

            foreach (ListViewItem item in favoriteServiceListView.Items)
            {
                favoriteServices.Add(new Service {
                    Tsid = item.SubItems[favoriteServiceTsidColumnHeader.Index].Text,
                    Sid = item.SubItems[favoriteServiceSidColumnHeader.Index].Text,
                    Name = item.SubItems[favoriteServiceNameColumnHeader.Index].Text
                });
            }

            RockbarUtility.SaveFavoriteServicesToSetting(favoriteServices);

            RockBarSetting rockbarSetting = new RockBarSetting();
            rockbarSetting.UseTcpIp = useTcpIpCheckbox.Checked;
            rockbarSetting.IpAddress = ipAddressTextBox.Text;
            rockbarSetting.PortNumber = (uint) portNumberNumericUpDown.Value;
            rockbarSetting.UseWebLink = useWebLinkCheckBox.Checked;
            rockbarSetting.WebLinkUrl = webLinkUrlTextBox.Text;

            rockbarSetting.TvtestPath = tvtestPathTextBox.Text;
            rockbarSetting.TvtestBscsOption = tvtestBscsOptionTextBox.Text;
            rockbarSetting.TvtestDttvOption = tvtestDttvOptionTextBox.Text;
            rockbarSetting.UseDoubleClickTvtest = useDoubleClickTvtestCheckBox.Checked;
            rockbarSetting.IsAutoOpenTvtest = isAutoOpenTvtestCheckBox.Checked;
            rockbarSetting.IsAutoOpenTvtestDttv = isAutoOpenDttvCheckBox.Checked;
            rockbarSetting.IsAutoOpenTvtestBs = isAutoOpenBsCheckBox.Checked;
            rockbarSetting.IsAutoOpenTvtestCs = isAutoOpenCsCheckBox.Checked;
            rockbarSetting.IsAutoOpenTvtestFavoriteService = isAutoOpenFavoriteServiceCheckBox.Checked;
            rockbarSetting.AutoOpenMargin = (uint) autoOpenMarginNumericUpDown.Value;
            rockbarSetting.AutoCloseMargin = (uint) autoCloseMarginNumericUpDown.Value;
            rockbarSetting.ShowTaskTrayIcon = showTaskTraiIconCheckBox.Checked;
            rockbarSetting.StoreTaskTrayByClosing = storeTaskTrayByClosingCheckBox.Checked;
            rockbarSetting.ToggleVisibleTaskTrayIconClick = toggleVisibleTaskTrayIconClickCheckBox.Checked;
            rockbarSetting.IsHorizontalSplit = isHorizontalSplitCheckBox.Checked;

            rockbarSetting.Font = fontTextBox.Text;
            rockbarSetting.FormBackColor = formBackColorTextBox.Text;
            rockbarSetting.ListBackColor = listBackColorTextBox.Text;
            rockbarSetting.ForeColor = foreColorTextBox.Text;

            rockbarSetting.BonDriverNameToTunerName = new Dictionary<string, string>();

            foreach (ListViewItem item in tunerNameListView.Items)
            {
                rockbarSetting.BonDriverNameToTunerName.Add(
                    item.SubItems[tunerNameBonDriverNameColumnHeader.Index].Text,
                    item.SubItems[tunerNameTunerNameColumnHeader.Index].Text
                );
            }

            Toml.WriteFile(rockbarSetting, RockbarUtility.GetTomlSettingFilePath());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// TVTest開くボタン押下処理
        /// ファイル選択ダイアログを開く。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void tvtestOpenButton_Click(object sender, EventArgs e)
        {
            tvtestOpenFileDialog.ShowDialog();
        }

        /// <summary>
        /// ファイル選択ダイアログ選択完了処理
        /// TVTest.exeパスを設定する。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void tvtestOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            tvtestPathTextBox.Text = tvtestOpenFileDialog.FileName;
        }

        /// <summary>
        /// 設定タブ切り替え処理
        /// お気に入りサービスタブへ切り替え時、選択サービスをリフレッシュしお気に入りサービスキー情報以外を更新する。
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void settingTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (settingTabControl.SelectedTab != favoriteServiceTabPage)
            {
                return;
            }

            // お気に入りサービスタブを開くたびに選択サービスを選択サービスタブからコピーし直す
            selectedServiceListView2.Items.Clear();

            foreach (ListViewItem item in selectedServiceListView.Items)
            {
                ListViewItem copiedItem = (ListViewItem)item.Clone();
                copiedItem.Name = item.Name;
                selectedServiceListView2.Items.Add(copiedItem);
            };

            // 設定ファイルの選択サービス一覧の表示
            foreach (ListViewItem item in favoriteServiceListView.Items)
            {
                string key = item.Name;

                if (selectedServiceListView2.Items.ContainsKey(key))
                {
                    // 登録済みはチェック表示
                    ListViewItem targetItem = selectedServiceListView2.Items[key];

                    item.SubItems[0].Text = targetItem.SubItems[0].Text;
                    item.SubItems[1].Text = targetItem.SubItems[1].Text;
                    item.SubItems[2].Text = targetItem.SubItems[2].Text;

                    checkServiceItem(targetItem);
                }
                else
                {
                    item.SubItems[0].Text = "！";
                    item.SubItems[1].Text = "";
                    item.SubItems[2].Text = "";
                };
            }
        }

        /// <summary>
        /// 全サービス一覧のカラムヘッダクリック処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void allServiceListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // ソートする
            allServiceListViewSorter.setColumn(e.Column);
            allServiceListView.ListViewItemSorter = allServiceListViewSorter;
            allServiceListView.ListViewItemSorter = null;
        }

        /// <summary>
        /// 選択サービス一覧のカラムヘッダクリック処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void selectedServiceListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // ソートする
            selectedServiceListViewSorter.setColumn(e.Column);
            selectedServiceListView.ListViewItemSorter = selectedServiceListViewSorter;
            selectedServiceListView.ListViewItemSorter = null;
        }

        /// <summary>
        /// 選択サービス一覧(お気に入りサービスタブ)のカラムヘッダクリック処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void selectedServiceListView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // ソートする
            selectedServiceListView2Sorter.setColumn(e.Column);
            selectedServiceListView2.ListViewItemSorter = selectedServiceListView2Sorter;
            selectedServiceListView2.ListViewItemSorter = null;
        }

        /// <summary>
        /// お気に入りサービス一覧のカラムヘッダクリック処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void favoriteServiceListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // ソートする
            favoriteServiceListViewSorter.setColumn(e.Column);
            favoriteServiceListView.ListViewItemSorter = favoriteServiceListViewSorter;
            favoriteServiceListView.ListViewItemSorter = null;
        }

        /// <summary>
        /// チューナー名一覧のカラムヘッダクリック処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void tunerNameListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // ソートする
            tunerNameListViewSorter.setColumn(e.Column);
            tunerNameListView.ListViewItemSorter = tunerNameListViewSorter;
            tunerNameListView.ListViewItemSorter = null;
        }

        /// <summary>
        /// フォント選択ボタン押下処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void selectFontButton_Click(object sender, EventArgs e)
        {
            // フォント選択ダイアログを開いて設定値を反映
            TypeConverter fontConverter = TypeDescriptor.GetConverter(typeof(Font));

            if (fontTextBox.Text != null)
            {
                fontDialog.Font = (Font)fontConverter.ConvertFromString(fontTextBox.Text);
            }

            DialogResult result = fontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fontTextBox.Text = fontConverter.ConvertToString(fontDialog.Font);
                foreColorLabel.Font = fontDialog.Font;
            }
        }

        /// <summary>
        /// フォーム背景色選択ボタン押下処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void selectFormBackColorButton_Click(object sender, EventArgs e)
        {
            // カラー選択ダイアログを開いて設定値を反映
            TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));

            if (formBackColorTextBox.Text != null)
            {
                colorDialog.Color = (Color)colorConverter.ConvertFromString(formBackColorTextBox.Text);
            }

            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                formBackColorTextBox.Text = colorConverter.ConvertToString(colorDialog.Color);
                formBackColorPanel.BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// リスト背景色選択ボタン押下処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void selectListBackColorButton_Click(object sender, EventArgs e)
        {
            // カラー選択ダイアログを開いて設定値を反映
            TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));

            if (listBackColorTextBox.Text != null)
            {
                colorDialog.Color = (Color)colorConverter.ConvertFromString(listBackColorTextBox.Text);
            }

            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                listBackColorTextBox.Text = colorConverter.ConvertToString(colorDialog.Color);
                listBackColorPanel.BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// 文字色選択ボタン押下処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void selectForeColorButton_Click(object sender, EventArgs e)
        {
            // カラー選択ダイアログを開いて設定値を反映
            TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));

            if (foreColorTextBox.Text != null)
            {
                colorDialog.Color = (Color)colorConverter.ConvertFromString(foreColorTextBox.Text);
            }

            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreColorTextBox.Text = colorConverter.ConvertToString(colorDialog.Color);
                foreColorLabel.ForeColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// チューナー名選択項目変更処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void tunerNameListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // テキストボックスに選択したチューナー名を表示
            if (tunerNameListView.SelectedItems.Count > 0)
            {
                tunerNameTextBox.Text = tunerNameListView.SelectedItems[0].SubItems[tunerNameTunerNameColumnHeader.Index].Text;
            }
        }

        /// <summary>
        /// チューナー名更新ボタン押下処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private void updateTunerNameButton_Click(object sender, EventArgs e)
        {
            // ListViewに反映
            if (tunerNameListView.SelectedItems.Count > 0)
            {
                tunerNameListView.SelectedItems[0].SubItems[tunerNameTunerNameColumnHeader.Index].Text = tunerNameTextBox.Text;
            }
        }
    }
}
