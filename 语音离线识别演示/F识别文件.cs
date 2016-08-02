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
    public partial class F识别文件 : UserControl
    {
        private IX识别 _IX识别 = new X离线识别();

        string GRM_FILE = "call.bnf"; //构建离线识别语法网络所用的语法文件

        public F识别文件()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.inAPPID.Text = "56289797";
            this.in文本.Text = "";
            this.do登录.Click += do登录_Click;
            this.do注销.Click += do注销_Click;
            this.do识别文件.Click += do识别文件_Click;
            this.in文本.DoubleClick += (m, n) => this.in文本.Clear();

            _IX识别.置信度 = 50;
            _IX识别.识别出内容 += _IX离线识别_识别出内容;
        }

        void _IX离线识别_识别出内容(string __结果, int __置信度)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, int>(_IX离线识别_识别出内容), __结果, __置信度);
                return;
            }
            this.in文本.Text = this.in文本.Text + string.Format("{0}({1}){2}", __结果, __置信度, Environment.NewLine);
        }

        void do注销_Click(object sender, EventArgs e)
        {
            _IX识别.注销();
        }

        void do登录_Click(object sender, EventArgs e)
        {
            _IX识别.登录(this.inAPPID.Text);
        }

        void do识别文件_Click(object sender, EventArgs e)
        {
            var __语法数据 = File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, GRM_FILE));
            var __语法内容 = System.Text.Encoding.Default.GetString(__语法数据);
            _IX识别.设置语法(__语法内容);

            _IX识别.开始();
            new Thread(输入数据) { IsBackground = true }.Start();
        }

        void 输入数据()
        {
            byte[] __PCM数据 = File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, "wav\\ddhgdw.pcm"));//打给零距离.wav//ddhgdw.pcm
            int __已解码长度 = 0;
            int __未解码长度 = __PCM数据.Length;
            while (true)
            {
                int __本次解码长度 = 3200;//3200与3600, 以及160这三个数值完整的业务关系未清楚
                if (__未解码长度 <= __本次解码长度)
                {
                    __本次解码长度 = __未解码长度;
                }

                byte[] __本次解码 = new byte[3600];
                Buffer.BlockCopy(__PCM数据, __已解码长度, __本次解码, 0, Math.Min(__未解码长度, __本次解码.Length));
                _IX识别.输入数据(__本次解码);

                __已解码长度 += __本次解码长度;
                __未解码长度 -= __本次解码长度;

                if (__未解码长度 <= 0)
                {
                    break;
                }

                Thread.Sleep(160); //模拟人说话时间间隙
            }
            Thread.Sleep(3000); //等待识别
            Debug.WriteLine("_IX离线识别.结束");
            _IX识别.结束();
        }

    }
}
