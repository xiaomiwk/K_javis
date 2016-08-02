using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NAudio.Wave;

namespace 语音
{
    public class BMIC
    {
        private WaveIn waveIn;

        public int 采样率 { get; set; }
        public int 比特 { get; set; }
        public int 信道数 { get; set; }

        /// <summary>
        /// 毫秒
        /// </summary>
        public int 缓冲时间 { get; set; }

        public BMIC(int __采样率 = 16000, int __比特 = 16, int __信道数 = 1, int __缓冲时间 = 1000)
        {
            this.采样率 = __采样率;
            this.比特 = __比特;
            this.信道数 = __信道数;
            this.缓冲时间 = __缓冲时间;
        }

        public void 开始录音()
        {
            if (waveIn != null)
            {
                waveIn.Dispose();
                waveIn = null;
            }

            if (waveIn == null)
            {
                waveIn = new WaveIn();
                waveIn.WaveFormat = new WaveFormat(采样率, 比特, 信道数);
                waveIn.BufferMilliseconds = 缓冲时间;
                waveIn.DataAvailable += (sender, e) =>
                {
                    //if (e.Buffer.Length != e.BytesRecorded)
                    //{
                    //    throw new ApplicationException("waveIn.DataAvailable e.Buffer.Length != e.BytesRecorded");
                    //}
                    On收到数据(e.Buffer, e.BytesRecorded);
                };
            }
            waveIn.StartRecording();
        }

        public void 停止录音()
        {
            //Debug.WriteLine("StopRecording");
            if (waveIn != null) waveIn.StopRecording();
        }

        public event Action<byte[], int> 收到数据;

        protected virtual void On收到数据(byte[] __数据, int __长度)
        {
            var handler = 收到数据;
            if (handler != null) handler(__数据, __长度);
        }
    }
}
