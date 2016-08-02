using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using 语音;

namespace 语音在线服务演示
{
    public partial class F合成 : UserControl
    {
        private IX合成 _IX合成 = new X在线合成();

        public F合成()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.inAPPID.Text = "5162b71e";
            this.in文本.Text = "完成中心网管第一阶段客户端自测";
            this.do合成.Click += do合成_Click;
            this.do登录.Click += do登录_Click;
            this.do注销.Click += do注销_Click;

            this.do登录.Enabled = true;
            this.do合成.Enabled = false;
            this.do注销.Enabled = false;
        }

        void do注销_Click(object sender, EventArgs e)
        {
            _IX合成.注销();

            this.do登录.Enabled = true;
            this.do合成.Enabled = false;
            this.do注销.Enabled = false;
        }

        void do登录_Click(object sender, EventArgs e)
        {
            _IX合成.登录(this.inAPPID.Text.Trim());

            this.do登录.Enabled = false;
            this.do合成.Enabled = true;
            this.do注销.Enabled = true;
        }

        private void do合成_Click(object sender, EventArgs e)
        {
            string __文本 = in文本.Text.Trim();//待合成的文本
            if (string.IsNullOrEmpty(in文本.Text.Trim()))
            {
                __文本 = "请输入合成语音的内容";
            }
            var __wave = _IX合成.合成(__文本);
            播放语音(__wave);
            保存语音(__wave);
            __wave.Close();
        }

        private void 播放语音(Stream memoryStream)
        {
            SoundPlayer soundPlayer = new SoundPlayer(memoryStream);
            soundPlayer.Stop();
            soundPlayer.Play();
        }

        private void 保存语音(MemoryStream memoryStream)
        {
            var fileStream = new FileStream("Call.wav", FileMode.Create, FileAccess.Write);
            memoryStream.WriteTo(fileStream);
            fileStream.Close();
        }
    }
}
