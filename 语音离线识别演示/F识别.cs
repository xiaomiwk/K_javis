using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using 语音;

namespace 语音离线识别演示
{
    public partial class F识别 : UserControl
    {
        private IX识别 _IX识别 = new X离线识别();

        private string _语法头 = @"#BNF+IAT 1.0;
!grammar work;
!slot <head>;
!slot <body>;
!slot <foot>;

!start <rule>;";

        private string _语法示例 = @"<rule>:[<head>]<body>[<foot>][<foot>][<foot>][<foot>][<foot>][<foot>][<foot>][<foot>][<foot>][<foot>][<foot>];
<head>:我想|我要|请|帮我|我想要|请帮我;
<body>:
打开我的电脑|打开浏览器|打开基础项目|备份|打开周报|关机|确定|看邮件|打开飞秋|打开词典|打开VSS|打开截图|打开记事本|打开帮助|呼叫;
<foot>:
0|1|2|3|4|5|6|7|8|9;";

        private BMIC _MIC = new BMIC();

        public F识别()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.inAPPID.Text = "56289797";
            this.in语法.Text = _语法示例;
            this.in文本.Text = "";
            this.do登录.Click += do登录_Click;
            this.do注销.Click += do注销_Click;
            this.do停止监听.Click += do停止监听_Click;
            this.do监听MIC.Click += do监听MIC_Click;
            this.in文本.DoubleClick += (m, n) => this.in文本.Clear();

            _MIC.收到数据 += 处理语音数据;
            _IX识别.置信度 = 30;
            _IX识别.识别出内容 += _IX离线识别_识别出内容;

            this.do登录.Enabled = true;
            this.do监听MIC.Enabled = false;
            this.do停止监听.Enabled = false;
            this.do注销.Enabled = false;
        }

        void _IX离线识别_识别出内容(string __结果, int __置信度)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, int>(_IX离线识别_识别出内容), __结果, __置信度);
                return;
            }
            this.in文本.Text = this.in文本.Text + string.Format("{0}({1}){2}", __结果, __置信度, Environment.NewLine);

            X离线播放.播放("5162b71e", __结果);
        }

        void 处理语音数据(byte[] __数据, int __长度)
        {
            _IX识别.输入数据(__数据);
        }

        void do监听MIC_Click(object sender, EventArgs e)
        {
            this.do监听MIC.Enabled = false;
            this.do停止监听.Enabled = true;
            //var __语法内容 = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, GRM_FILE), System.Text.Encoding.Default);
            var __语法内容 = _语法头 + Environment.NewLine + this.in语法.Text.Trim();
            _IX识别.设置语法(__语法内容);

            _IX识别.开始();
            _MIC.开始录音();

            this.do监听MIC.Enabled = false;
            this.do停止监听.Enabled = true;
        }

        void do停止监听_Click(object sender, EventArgs e)
        {
            _IX识别.结束();
            this.do监听MIC.Enabled = true;
            this.do停止监听.Enabled = false;
            _MIC.停止录音();

            this.do监听MIC.Enabled = true;
            this.do停止监听.Enabled = false;
        }

        void do注销_Click(object sender, EventArgs e)
        {
            _IX识别.注销();

            this.do登录.Enabled = true;
            this.do监听MIC.Enabled = false;
            this.do停止监听.Enabled = false;
            this.do注销.Enabled = false;
        }

        void do登录_Click(object sender, EventArgs e)
        {
            _IX识别.登录(this.inAPPID.Text);

            this.do登录.Enabled = false;
            this.do监听MIC.Enabled = true;
            this.do停止监听.Enabled = false;
            this.do注销.Enabled = true;
        }
    }
}
