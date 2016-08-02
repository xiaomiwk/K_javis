using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace 语音
{
    public class X在线合成 : IX合成
    {
        public void 登录(string appid)
        {
            var __登录参数 = string.Format("appid={0}, work_dir = .", appid);
            var __结果 = Dll在线.MSPLogin(string.Empty, string.Empty, __登录参数);
            if (__结果 != (int)ErrorCode.MSP_SUCCESS)
            {
                throw new ApplicationException("登录失败! 错误码: " + __结果);
            }
        }

        public void 注销()
        {
            var __结果 = Dll在线.MSPLogout();
            if (__结果 != (int)ErrorCode.MSP_SUCCESS)
            {
                throw new ApplicationException("注销失败! 错误码: " + __结果);
            }
        }

        public int 音频采样率 { get { return 16000; } }

        public MemoryStream 合成(string __文本)
        {
            if (string.IsNullOrEmpty(__文本.Trim()))
            {
                throw new ApplicationException("请输入合成语音的内容!");
            }
            IntPtr __session = IntPtr.Zero;
            try
            {
                int __结果 = 0;
                var __合成参数 = string.Format("voice_name = xiaoyan, text_encoding = gb2312, sample_rate = {0}, speed = 50, volume = 50, pitch = 50, rdn = 2", 音频采样率);
                __session = Dll在线.QTTSSessionBegin(__合成参数, ref __结果);
                if (__结果 != (int)ErrorCode.MSP_SUCCESS)
                {
                    throw new ApplicationException("启动合成失败! 错误码: " + __结果);
                }
                __结果 = Dll在线.QTTSTextPut(__session, __文本, (uint)Encoding.Default.GetByteCount(__文本), string.Empty);
                if (__结果 != (int)ErrorCode.MSP_SUCCESS)
                {
                    throw new ApplicationException("合成失败! 错误码: " + __结果);
                }

                var __数据流 = new MemoryStream();
                __数据流.Write(new byte[44], 0, 44);
                var __解码状态 = E合成状态.进行中;
                while (true)
                {
                    uint __解码长度 = 0;
                    IntPtr __解码指针 = Dll在线.QTTSAudioGet(__session, ref __解码长度, ref __解码状态, ref __结果);
                    if (__结果 != 0)
                        break;
                    byte[] __解码数据 = new byte[(int)__解码长度];
                    if (__解码指针 != IntPtr.Zero)
                    {
                        Marshal.Copy(__解码指针, __解码数据, 0, (int)__解码长度);
                    }
                    __数据流.Write(__解码数据, 0, __解码数据.Length);
                    Thread.Sleep(100);
                    if (__解码状态 == E合成状态.完毕)
                        break;
                }
                //if (memoryStream.Length == 44)
                //{
                //    throw new ApplicationException("合成失败! 无音频 ");
                //}
                byte[] __文件头 = HWAVE文件头.获取((int)__数据流.Length - 44);
                __数据流.Position = 0L;
                __数据流.Write(__文件头, 0, __文件头.Length);
                __数据流.Position = 0L;
                return __数据流;
            }
            finally
            {
                if (__session != IntPtr.Zero)
                {
                    int __结果 = Dll在线.QTTSSessionEnd(__session, "");
                    if (__结果 != (int)ErrorCode.MSP_SUCCESS)
                    {
                        throw new ApplicationException("结束合成失败! 错误码: " + __结果);
                    }
                }
            }
        }

    }
}
