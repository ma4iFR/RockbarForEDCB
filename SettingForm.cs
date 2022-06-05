using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        // CtrlCmdUtil
        private CtrlCmdUtil ctrlCmdUtil = null;

        // CtrlCmdの結果格納用
        private List<EpgServiceInfo> serviceInfos = new List<EpgServiceInfo>();

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
            catch
            {
                // TOML設定ファイルが読み込めない場合は空設定で起動
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

            showTaskTraiIconCheckBox.Checked = setting.ShowTaskTrayIcon;

            // サービス一覧取得
            serviceInfos.Clear();

            if (canConnect)
            {
                ctrlCmdUtil.SendEnumService(ref serviceInfos);
            }

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
                    //TODO ちゃんとしたcolumn名にしてカラムのindexで取得するようにする
                    leftListView.Items[item.Name].SubItems[0].Text = "";
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
                //TODO indexをどうにかする
                selectedServices.Add(new Service { Tsid = item.SubItems[3].Text, Sid = item.SubItems[4].Text, Name = item.SubItems[2].Text });
            }

            RockbarUtility.SaveAllServicesToSetting(selectedServices);

            // お気に入りチャンネル
            List<Service> favoriteServices = new List<Service>();

            foreach (ListViewItem item in favoriteServiceListView.Items)
            {
                //TODO indexをどうにかする
                favoriteServices.Add(new Service { Tsid = item.SubItems[3].Text, Sid = item.SubItems[4].Text, Name = item.SubItems[2].Text });
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
    }
}
