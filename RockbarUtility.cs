using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RockbarForEDCB
{
    /// <summary>
    /// サービス種類列挙型
    /// </summary>
    public enum ServiceType
    {
        // BS (Broadcasting Satellite)
        BS,
        // CS (Communication Satellite)
        CS,
        // 地デジ(Digital Terrestrial Television)
        DTTV,                   
    };

    /// <summary>
    /// 予約ステータス列挙子
    /// </summary>
    public enum ReserveStatus
    {
        // 予約なし
        NONE,
        // 正常予約
        OK,
        // 部分録画
        PARTIAL,
        // 録画不可(チューナー不足)
        NG,
        // 番組消失
        DISAPPEARED,
    };

    /// <summary>
    /// サービスクラス
    /// </summary>
    public class Service
    {
        public string Tsid { get; set; }
        public string Sid { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// 設定ファイルクラス
    /// </summary>
    public class RockBarSetting
    {
        public RockBarSetting()
        {
            // 数値系は0初期化・bool系はfalse初期化・stringはnull初期化。設定が必要な箇所だけ設定する

            TypeConverter fontConverter = TypeDescriptor.GetConverter(typeof(Font));
            this.Font = fontConverter.ConvertToString(SystemFonts.DefaultFont);

            TypeConverter colorConverter = TypeDescriptor.GetConverter(typeof(Color));
            this.FormBackColor = colorConverter.ConvertToString(Color.FromArgb(163, 216, 232));
            this.ListBackColor = colorConverter.ConvertToString(Color.FromArgb(40, 40, 40));
            this.ForeColor = colorConverter.ConvertToString(Color.FromArgb(25, 250, 140));

            BonDriverNameToTunerName = new Dictionary<string, string>();
        }

        // 起動時x座標
        public int X { get; set; }
        // 起動時y座標
        public int Y { get; set; }
        // 起動時画面幅
        public int Width { get; set; }
        // 起動時画面高
        public int Height { get; set; }
        // 起動時スプリッター位置
        public int SplitterDistance { get; set; }
        // TCP/IP使用
        public bool UseTcpIp { get; set; }
        // IPアドレス
        public string IpAddress { get; set; }
        // ポート番号
        public uint PortNumber { get; set; }
        // Web Link使用
        public bool UseWebLink { get; set; }
        // Web Link URL
        public string WebLinkUrl { get; set; }
        // TVTest.exeパス
        public string TvtestPath { get; set; }
        // TVTest BS/CSオプション
        public string TvtestBscsOption { get; set; }
        // TVTest 地デジオプション
        public string TvtestDttvOption { get; set; }
        // TVTestダブルクリック起動使用
        public bool UseDoubleClickTvtest { get; set; }
        // TVTest自動起動使用
        public bool IsAutoOpenTvtest { get; set; }
        // TVTest自動起動(地デジ)
        public bool IsAutoOpenTvtestDttv { get; set; }
        // TVTest自動起動(BS)
        public bool IsAutoOpenTvtestBs { get; set; }
        // TVTest自動起動(CS)
        public bool IsAutoOpenTvtestCs { get; set; }
        // TVTest自動起動(お気に入りサービス)
        public bool IsAutoOpenTvtestFavoriteService { get; set; }
        // TVTest自動起動開始マージン
        public uint AutoOpenMargin { get; set; }
        // TVTest自動起動終了マージン
        public uint AutoCloseMargin { get; set; }
        // タスクトレイアイコン常時表示
        public bool ShowTaskTrayIcon { get; set; }
        // ×ボタンでタスクトレイに格納
        public bool StoreTaskTrayByClosing { get; set; }
        // タスクトレイアイコンクリック時表示・非表示切り替え
        public bool ToggleVisibleTaskTrayIconClick { get; set; }
        // 水平分割
        public bool IsHorizontalSplit { get; set; }
        // フォント(シリアライズしたもの)
        public string Font { get; set; }
        // フォーム背景色(シリアライズしたもの)
        public string FormBackColor { get; set; }
        // リスト背景色(シリアライズしたもの)
        public string ListBackColor { get; set; }
        // 文字色(シリアライズしたもの)
        public string ForeColor { get; set; }
        // BonDriver名→チューナー名マッピング
        public Dictionary<string, string> BonDriverNameToTunerName { get; set; }
    }

    /// <summary>
    /// ユーティリティクラス
    /// </summary>
    class RockbarUtility
    {
        // 設定ファイル名はハードコーディングとする
        public static string TOML_CONFIG_FILENAME = "RockbarForEDCB.toml";
        public static string TSV_ALL_SERVICE_FILENAME = "SelectedServices.tsv";
        public static string TSV_FAVORITE_SERVICE_FILENAME = "FavoriteServices.tsv";

        private const string DELIMITER = "-";

        /// <summary>
        /// 文字列分割処理
        /// もとからある改行は残し、20文字以上ある行に改行を挿入する
        /// </summary>
        /// <param name="input">入力文字列</param>
        /// <returns>文字列リスト(行毎)</returns>
        public static List<string> BreakString(string input)
        {
            if (input == null)
            {
                return null;
            }

            input = input.TrimEnd();

            List<string> results = new List<string>();

            string[] lines = input.Split('\n');
            foreach (string line in lines)
            {
                string temp = line.Trim();

                while (temp.Length > 20)
                {
                    results.Add(temp.Substring(0, 20));
                    temp = temp.Substring(20);
                }

                results.Add(temp);
            }

            return results;
        }
        
        /// <summary>
        /// ONIDからサービスタイプ(BS/CS/地デジ)を返す
        /// </summary>
        /// <param name="originalNetworkId">ONID</param>
        /// <returns>サービスタイプ</returns>
        public static ServiceType GetServiceType(int originalNetworkId)
        {
            switch (originalNetworkId)
            {
                case 4:
                    // BS
                    return ServiceType.BS;
                case 6:
                case 7:
                case 10:
                    // CS
                    return ServiceType.CS;
                default:
                    // 地デジ
                    return ServiceType.DTTV;
            }
        }

        /// <summary>
        /// サービスタイプからサービス種類文字列(短)を返す
        /// </summary>
        /// <param name="serviceType">サービスタイプ</param>
        /// <returns>サービス種類文字列(短)</returns>
        public static string GetShortServiceTypeName(ServiceType serviceType)
        {
            switch (serviceType)
            {
                case ServiceType.DTTV:
                    return "地";
                case ServiceType.BS:
                    return "BS";
                case ServiceType.CS:
                    return "CS";
                default:
                    return null;
            }
        }

        /// <summary>
        /// 予約ステータスから予約ステータス識別文字列を返す
        /// </summary>
        /// <param name="reserveStatus">予約ステータス</param>
        /// <returns>予約ステータス識別子</returns>
        public static string GetReserveStatusString(ReserveStatus reserveStatus)
        {
            switch (reserveStatus)
            {
                case ReserveStatus.NONE:
                    return "　";
                case ReserveStatus.OK:
                    return "◎";
                case ReserveStatus.PARTIAL:
                    return "欠";
                case ReserveStatus.NG:
                    return "×";
                case ReserveStatus.DISAPPEARED:
                    return "消";
                default:
                    return null;
            }
        }

        /// <summary>
        /// キー取得処理
        /// </summary>
        /// <param name="ids">ID配列</param>
        /// <returns>連結キー</returns>
        public static string GetKey(params ushort[] ids)
        {
            return String.Join(DELIMITER, ids);
        }

        /// <summary>
        /// キー取得処理
        /// </summary>
        /// <param name="ids">ID配列</param>
        /// <returns>連結キー</returns>
        public static string GetKey(params string[] ids)
        {
            return String.Join(DELIMITER, ids);
        }

        /// <summary>
        /// TSVファイルからサービスリストを読み込んで返す
        /// </summary>
        /// <param name="filename">TSVファイル名</param>
        /// <returns>サービスリスト</returns>
        private static List<Service> GetServicesFromSetting(string filename)
        {
            // タブ区切り・ヘッダ文字列大文字
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "\t",
                PrepareHeaderForMatch = args => args.Header.ToUpper(),
            };

            List<Service> result = new List<Service>();

            try
            {
                using (var reader = new StreamReader(filename))
                using (var tsv = new CsvHelper.CsvReader(reader, config))
                {
                    // Mapping処理
                    var records = tsv.GetRecords<Service>();
                    result.AddRange(records);
                }
            }
            catch
            {
                // CSVファイルがない場合フォーマットエラーの場合、空リストを返す
            }

            return result;
        }

        /// <summary>
        /// TSVファイルから全サービスリストを読み込んで返す
        /// </summary>
        /// <returns>全サービスリスト</returns>
        public static List<Service> GetAllServicesFromSetting()
        {
            return GetServicesFromSetting(GetTsvAllServiceFilePath());
        }

        /// <summary>
        /// TSVファイルからお気に入りサービスリストを読み込んで返す
        /// </summary>
        /// <returns>お気に入りサービスリスト</returns>
        public static List<Service> GetFavoriteServicesFromSetting()
        {
            return GetServicesFromSetting(GetTsvFavoriteServiceFilePath());
        }

        /// <summary>
        /// TSVファイルにサービスリストを書き込む
        /// </summary>
        /// <param name="services">サービスリスト</param>
        /// <param name="filename">ファイル名</param>
        private static void SaveServicesToSetting(List<Service> services, string filename)
        {
            // タブ区切り・ヘッダ文字列大文字
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "\t",
                PrepareHeaderForMatch = args => args.Header.ToUpper(),
            };

            List<Service> result = new List<Service>();

            using (var writer = new StreamWriter(filename))
            using (var tsv = new CsvHelper.CsvWriter(writer, config))
            {
                tsv.WriteRecords(services);
            }
        }

        /// <summary>
        /// TSVファイルに全サービスリストを書き込む
        /// </summary>
        /// <param name="services">全サービスリスト</param>
        public static void SaveAllServicesToSetting(List<Service> services)
        {
            SaveServicesToSetting(services, GetTsvAllServiceFilePath());
        }

        /// <summary>
        /// TSVファイルにお気に入りサービスリストを書き込む
        /// </summary>
        /// <param name="services">お気に入りサービスリスト</param>
        public static void SaveFavoriteServicesToSetting(List<Service> services)
        {
            SaveServicesToSetting(services, GetTsvFavoriteServiceFilePath());
        }

        /// <summary>
        /// TOML設定ファイルのフルパスを返す
        /// </summary>
        /// <returns>TOML設定ファイルのフルパス</returns>
        public static string GetTomlSettingFilePath()
        {
            // フルパスを返す
            return GetFullPath(TOML_CONFIG_FILENAME);
        }

        /// <summary>
        /// TSV全サービス設定ファイルのフルパスを返す
        /// </summary>
        /// <returns>TSV全サービス設定ファイルのフルパス</returns>
        public static string GetTsvAllServiceFilePath()
        {
            // フルパスを返す
            return GetFullPath(TSV_ALL_SERVICE_FILENAME);
        }

        /// <summary>
        /// TSVお気に入りサービス設定ファイルのフルパスを返す
        /// </summary>
        /// <returns>TSVお気に入りサービス設定ファイルのフルパス</returns>
        public static string GetTsvFavoriteServiceFilePath()
        {
            // フルパスを返す
            return GetFullPath(TSV_FAVORITE_SERVICE_FILENAME);
        }

        /// <summary>
        /// アプリケーションディレクトリとファイル名を連結して返却する
        /// </summary>
        /// <param name="filename">ファイル名</param>
        /// <returns>フルパス</returns>
        private static string GetFullPath(string filename)
        {
            // 実行ファイルのフルパスを取得
            string appFilePath = System.Reflection.Assembly.GetEntryAssembly().Location;

            // ディレクトリと連結して、設定ファイルのフルパスを返す
            return Path.Combine(Path.GetDirectoryName(appFilePath), filename);
        }

        /// <summary>
        /// BonDriver名からデフォルトチューナー名を生成する処理
        /// </summary>
        /// <param name="bonDriverName">BonDriver名</param>
        /// <returns>デフォルトチューナー名</returns>
        public static string GetDefaultTunerName(string bonDriverName)
        {
            if (bonDriverName == "チューナー不足")
            {
                return "TU不足";
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(bonDriverName, @"_(MLT|S3U|uSUNpTV|Bulldog)[0-9]*\.dll", RegexOptions.IgnoreCase))
            {
                return "3波";
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(bonDriverName, @"_S[0-9]*\.dll", RegexOptions.IgnoreCase))
            {
                return "BS/CS";
            }
            else
            {
                return "地デジ";
            }
        }
    }
}
