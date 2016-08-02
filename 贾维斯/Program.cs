using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 贾维斯
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F主窗口());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(string.Format("即将关闭\n\r{0}", e.ExceptionObject));
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception is ApplicationException)
            {
                MessageBox.Show(string.Format("出现一个意料中的意外, 请重试\n\r{0}", e.Exception));
            }
        }
    }
}
