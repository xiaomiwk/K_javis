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

namespace 语音在线服务演示
{
    public partial class F听写 : UserControl
    {
        private IX识别 _IX听写 = new X在线听写();

        private string _语法示例 = "中美数控,王凯";

        private BMIC _MIC = new BMIC();

        public F听写()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.inAPPID.Text = "5162b71e";
            this.in语法.Text = _语法示例;
            this.in文本.Text = "";
            this.do登录.Click += do登录_Click;
            this.do注销.Click += do注销_Click;
            this.do停止监听.Click += do停止监听_Click;
            this.do监听MIC.Click += do监听MIC_Click;
            this.in文本.DoubleClick += (m, n) => this.in文本.Clear();

            _MIC.收到数据 += (__数据, __长度) => _IX听写.输入数据(__数据);
            _IX听写.识别出内容 += _IX离线识别_识别出内容;

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
            this.in文本.Text = this.in文本.Text + __结果;

            X在线播放.播放(__结果);
        }

        void do监听MIC_Click(object sender, EventArgs e)
        {
            this.do监听MIC.Enabled = false;
            this.do停止监听.Enabled = true;
            var __语法内容 = this.in语法.Text.Trim();
            _IX听写.设置语法(__语法内容.Split(new char[]{ ',', '，', ';', '；'}, StringSplitOptions.RemoveEmptyEntries).ToList());
            _IX听写.开始();
            _MIC.开始录音();
        }

        void do停止监听_Click(object sender, EventArgs e)
        {
            _IX听写.结束();
            this.do监听MIC.Enabled = true;
            this.do停止监听.Enabled = false;
            _MIC.停止录音();
        }

        void do注销_Click(object sender, EventArgs e)
        {
            _IX听写.注销();

            this.do登录.Enabled = true;
            this.do监听MIC.Enabled = false;
            this.do停止监听.Enabled = false;
            this.do注销.Enabled = false;
        }

        void do登录_Click(object sender, EventArgs e)
        {
            _IX听写.登录(this.inAPPID.Text);

            this.do登录.Enabled = false;
            this.do监听MIC.Enabled = true;
            this.do停止监听.Enabled = false;
            this.do注销.Enabled = true;
        }
    }
}
