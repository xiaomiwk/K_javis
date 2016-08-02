using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 语音;

namespace 语音离线合成演示
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var __参数 = Environment.GetCommandLineArgs();
            if (__参数.Length == 3)
            {
                //MessageBox.Show(string.Join(" ", __参数));
                X离线播放.播放(__参数[1], __参数[2]);
                return;
            }
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F语音合成());
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
