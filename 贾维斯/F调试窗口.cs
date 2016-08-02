using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 贾维斯
{
    public partial class F调试窗口 : Form
    {
        private H窗口输出 _H窗口输出;

        public F调试窗口()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.out信息.DoubleClick += out信息_DoubleClick;

            _H窗口输出 = new H窗口输出(this.out信息);
            Trace.Listeners.Add(_H窗口输出);
            this.FormClosing += F调试窗口_FormClosing;
        }

        void F调试窗口_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trace.Listeners.Remove(_H窗口输出);
        }

        void out信息_DoubleClick(object sender, EventArgs e)
        {
            this.out信息.Clear();
        }

        class H窗口输出 : TraceListener
        {
            private TextBox _文本框;

            public H窗口输出(TextBox __文本框)
            {
                _文本框 = __文本框;
            }

            public override void Write(string message)
            {
                if (_文本框.InvokeRequired)
                {
                    _文本框.BeginInvoke(new Action<string>(Write), message);
                    return;
                }
                if (_文本框.TextLength > 5000)
                {
                    _文本框.Text = _文本框.Text.Substring(4000);
                }

                _文本框.AppendText(message);
            }

            public override void WriteLine(string message)
            {
                Write(message + Environment.NewLine);
            }
        }

    }
}
