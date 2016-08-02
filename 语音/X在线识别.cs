using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace 语音
{
    public class X在线识别 : X识别
    {
        private Dll _Dll = new Dll();

        private string _语法id;

        public override void 设置语法(string 语法)
        {
            var __语法参数 = "dtt = abnf, sub = asr";
            int __结果 = 0;
            var __语法长度 = Encoding.UTF8.GetBytes(语法).Length;
            var __编码 = Encoding.UTF8.GetBytes(语法 + '\0');
            var __指针 = Dll在线.MSPUploadData("", __编码, (uint)__语法长度, __语法参数, ref __结果);
            if (__结果 != 0)
            {
                Debug.WriteLine("语法加载失败, 错误码: " + __结果);
                throw new ApplicationException("语法加载失败, 错误码: " + __结果);
            }
            _语法id = Marshal.PtrToStringAnsi(__指针);
            //Debug.WriteLine("语法id: " + _语法id);
        }

        public override void 设置语法(List<string> __词典)
        {
            var __语法 = new StringBuilder(@"#ABNF 1.0 GB2312;

language zh-CN;
mode voice;

root $main;

$main = $digit;
$digit = ");
            __词典.ForEach(q => __语法.Append(q).Append("|"));
            if (__词典.Count > 0)
            {
                __语法.Remove(__语法.Length - 1, 1);
            }
            __语法.Append(";");
            设置语法(__语法.ToString());
        }

        protected override void 分析识别结果(string __结果)
        {
            //confidence=93 grammar=0 input=打电话给丁伟
            var __分段 = __结果.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var __置信度 = int.Parse(__分段[0].Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries)[1]);
            var __内容 = __分段[2].Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries)[1];
            On识别出内容(__内容, __置信度);
        }

        protected override string 获取登录参数()
        {
            return "appid = {0}, work_dir = .";
        }

        protected override string 获取识别参数()
        {
            return "sub = asr, result_type = plain, result_encoding = gb2312";
        }

        protected override string 获取语法id()
        {
            return _语法id;
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
