using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.存储;
using 语音;

namespace 贾维斯
{
    public partial class F便签 : UserControl
    {
        private IX识别 _IX听写 = new X在线听写();

        private BMIC _MIC = new BMIC();

        private string _文件名 = "便签.rtf";

        public F便签()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.in紧急性.Items.AddRange(new object[] { "非常紧急", "紧急", "不紧急" });
            this.in重要性.Items.AddRange(new object[] { "非常重要", "重要", "不重要" });
            this.in紧急性.SelectedIndex = 1;
            this.in重要性.SelectedIndex = 1;

            this.do保存.Click += do保存_Click;
            this.do撤销.Click += do撤销_Click;
            this.do设置.Click += do设置_Click;

            if (H路径.验证文件是否存在(_文件名))
            {
                this.in文本.LoadFile(_文件名);
            }

            _MIC.收到数据 += 处理语音数据;
            _IX听写.识别出内容 += _IX听写_识别出内容;
            this.do听写.Click += do听写_Click;
        }

        void 处理语音数据(byte[] __数据, int __长度)
        {
            _IX听写.输入数据(__数据);
        }

        void do听写_Click(object sender, EventArgs e)
        {
            if (this.do听写.Text == "听写")
            {
                _IX听写.登录(HINI.Read("配置.ini", "讯飞语音", "在线服务APPID"));
                _IX听写.开始();
                _MIC.开始录音();
                this.do听写.Text = "停止听写";
            }
            else
            {
                _IX听写.结束();
                _IX听写.注销();
                _MIC.停止录音();
                this.do听写.Text = "听写";
            }
        }

        void _IX听写_识别出内容(string __内容, int __置信度)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, int>(_IX听写_识别出内容), __内容, __置信度);
                return;
            }
            this.in文本.AppendText(__内容);
        }

        void do设置_Click(object sender, EventArgs e)
        {
            var __紧急性 = (string)this.in紧急性.SelectedItem;
            var __重要性 = (string)this.in重要性.SelectedItem;
            var __前景色 = Color.Black;
            var __背景色 = Color.White;
            var __字体大小 = 10F;
            switch (__紧急性)
            {
                case "非常紧急":
                    __背景色 = Color.Red;
                    break;
                case "紧急":
                    __背景色 = Color.Orange;
                    break;
            }
            switch (__重要性)
            {
                case "非常重要":
                    //__前景色 = Color.Red;
                    __字体大小 = Math.Max(14F, __字体大小);
                    break;
                case "重要":
                    //__前景色 = Color.Green;
                    __字体大小 = Math.Max(12F, __字体大小);
                    break;
            }
            this.in文本.SelectionColor = __前景色;
            this.in文本.SelectionBackColor = __背景色;
            this.in文本.SelectionFont = new Font("微软雅黑", __字体大小);
        }

        void do撤销_Click(object sender, EventArgs e)
        {
            if (H路径.验证文件是否存在(_文件名))
            {
                this.in文本.LoadFile(_文件名);
            }
            else
            {
                this.in文本.Clear();
            }
        }

        void do保存_Click(object sender, EventArgs e)
        {
            //_D便签.保存(this.in文本.Rtf);
            this.in文本.SaveFile(_文件名);
        }
    }
}
