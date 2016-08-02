using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace 语音
{
    public class X在线听写 : X识别
    {
        private Dll _Dll = new Dll();

        public override void 设置语法(string __语法)
        {
        }

        public override void 设置语法(List<string> 词典)
        {
            if (词典 == null || 词典.Count == 0)
            {
                return;
            }
            var __字符串 = 合成词典(词典);
            var __语法参数 = "sub = uup, dtt = userword";
            int __结果 = 0;
            var __语法长度 = Encoding.UTF8.GetBytes(__字符串).Length;
            var __编码 = Encoding.UTF8.GetBytes(__字符串 + '\0');
            Dll在线.MSPUploadData("", __编码, (uint)__语法长度, __语法参数, ref __结果);
            if (__结果 != 0)
            {
                Debug.WriteLine("语法加载失败, 错误码: " + __结果);
                throw new ApplicationException("语法加载失败, 错误码: " + __结果);
            }
        }

        protected override void 分析识别结果(string __结果)
        {
            On识别出内容(__结果, 100);
        }

        private string 合成词典(List<string> 词典)
        {
            //"{\"userword\":[{\"words\":[\"中美速控\",\"人民\",\"张山\",\"明百\",\"可勒\"],\"name\":\"再见\"},{\"words\":[\"邯郸钢铁\",\"电话簿\"],\"name\":\"常用命令\"},{\"words\":[\"身体健康\",\"恭喜发财\",\"吉祥如意\",\"龙年\"],\"name\":\"新年短信\"}]}"
            var __结果 = new StringBuilder();
            __结果.Append("{\"userword\":[{\"words\":[");
            词典.ForEach(q => __结果.AppendFormat("\"{0}\",", q));
            __结果.Remove(__结果.Length - 1, 1);
            __结果.Append("],\"name\":\"wangkai\"}]}");
            return __结果.ToString();
        }

        protected override string 获取登录参数()
        {
            return "appid = {0}, work_dir = .";
        }

        protected override string 获取识别参数()
        {
            return "sub = iat, domain = iat, language = zh_ch, accent = mandarin, sample_rate = 16000, result_type = plain, result_encoding = gb2312";
        }

        protected override string 获取语法id()
        {
            return null;
        }

        protected override IX识别DLL DLL接口 { get { return _Dll; } }

        private class Dll : IX识别DLL
        {
            public int MSPLogin(string user, string password, string configs)
            {
                return Dll在线.MSPLogin(user, password, configs);
            }

            public int MSPLogout()
            {
                return Dll在线.MSPLogout();
            }

            public IntPtr QISRSessionBegin(string grammarList, string _params, ref int errorCode)
            {
                return Dll在线.QISRSessionBegin(grammarList, _params, ref errorCode);
            }

            public int QISRAudioWrite(IntPtr sessionID, byte[] waveData, uint waveLen, E音频块位置 audioStatus, ref E检测状态 epStatus, ref E识别状态 recogStatus)
            {
                return Dll在线.QISRAudioWrite(sessionID, waveData, waveLen, audioStatus, ref epStatus, ref recogStatus);
            }

            public IntPtr QISRGetResult(IntPtr sessionID, ref E识别状态 rsltStatus, int waitTime, ref int errorCode)
            {
                return Dll在线.QISRGetResult(sessionID, ref rsltStatus, waitTime, ref errorCode);
            }

            public int QISRSessionEnd(IntPtr sessionID, string hints)
            {
                return Dll在线.QISRSessionEnd(sessionID, hints);
            }
        }


    }
}
