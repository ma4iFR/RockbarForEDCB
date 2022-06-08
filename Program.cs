using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockbarForEDCB
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ThreadExceptionイベントハンドラを追加
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            // 常にThreadExceptionが発生されるようにする
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // UnhandledExceptionイベントハンドラを追加
            System.AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        /// GUIスレッド内の補足されない例外処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
                // エラーメッセージを表示する
                MessageBox.Show(e.Exception.ToString(), "エラー");
            }
            finally
            {
                // アプリケーションを終了する
                Application.Exit();
            }
        }

        /// <summary>
        /// GUIスレッド外の補足されない例外処理
        /// </summary>
        /// <param name="sender">イベントソース</param>
        /// <param name="e">イベントパラメータ</param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                // エラーメッセージを表示する
                Exception ex = (Exception)e.ExceptionObject;
                MessageBox.Show(ex.ToString(), "エラー");
            }
            finally
            {
                // アプリケーションを終了する
                Environment.Exit(1);
            }
        }
    }
}
