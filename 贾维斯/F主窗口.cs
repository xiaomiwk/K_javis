using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 语音;

namespace 贾维斯
{
    public partial class F主窗口 : Form
    {

        public F主窗口()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.out通知栏图标.Visible = true;

            this.uTab1.添加("常用命令", new F常用命令() { Dock = DockStyle.Fill });
            this.uTab1.添加("便签", new F便签() { Dock = DockStyle.Fill });
            this.uTab1.激活("常用命令");
            this.out通知栏图标.DoubleClick += this.out通知栏图标_DoubleClick;
            this.do退出.Click += this.do退出_Click;
            this.do显示.Click += this.out通知栏图标_DoubleClick;
            this.FormClosing += F主窗口_FormClosing;
            this.do打开调试窗口.Click += do打开调试窗口_Click;
            this.do设置.Click += do设置_Click;
            this.u窗体头1.点击设置 += u窗体头1_点击设置;
        }

        void do设置_Click(object sender, EventArgs e)
        {
            Process.Start("notepad", "配置.ini");
        }

        void u窗体头1_点击设置()
        {
            this.out系统设置.Show(MousePosition);
        }

        void do打开调试窗口_Click(object sender, EventArgs e)
        {
            var __窗口 = new F调试窗口()
            {
                TopMost = true, 
                Height = this.Height, 
                Width = 250, 
            };
            __窗口.Show();
            __窗口.Left = Math.Min(this.Left + this.Width, Screen.FromControl(this).WorkingArea.Width - __窗口.Width);
            __窗口.Top = this.Top;

        }

        void F主窗口_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                this.out通知栏图标.Visible = false;
            }
            else
            {
                this.Hide();
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void out通知栏图标_DoubleClick(object Sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Show();
            this.Activate();
            this.ShowInTaskbar = true;
        }

        private void do退出_Click(object Sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
