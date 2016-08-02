using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace 语音
{
    public class X离线识别 : X识别
    {
        string ASR_RES_PATH = "fo|res/asr/common.jet";  //离线语法识别资源路径

        string GRM_BUILD_PATH = "res/asr/GrmBuilld";  //构建离线语法识别网络生成数据保存路径

        private string _语法id;

        private Dll _Dll = new Dll();

        public X离线识别()
        {
            this.置信度 = 30;
        }

        public override void 设置语法(string __语法)
        {
            _语法id = 解析语法id(__语法);
            var __语法参数 = string.Format("engine_type = local, asr_res_path = {0}, sample_rate={2}, grm_build_path = {1} ", ASR_RES_PATH, GRM_BUILD_PATH, 音频采样率);
            //ASRDll.XfBuildGrammerWithFiles("bnf", GRM_FILE, __语法参数);

            var __语法长度 = Encoding.Default.GetBytes(__语法).Length;
            var __结果 = Dll离线识别.QISRBuildGrammar("bnf", __语法, __语法长度, __语法参数, IntPtr.Zero, IntPtr.Zero); //回调出错未解决, 暂时不填
            if (__结果 != 0)
            {
                Debug.WriteLine("语法加载失败, 错误码: " + __结果);
                throw new ApplicationException("语法加载失败, 错误码: " + __结果);
            }
        }

        public override void 设置语法(List<string> __词典)
        {
            var __语法 = new StringBuilder(@"#BNF+IAT 1.0;
!grammar work;
!slot <head>;
!slot <body>;

!start <rule>;
<rule>:[<head>]<body>;
<head>:我想|我要|请|帮我|我想要|请帮我;
<body>:");
            __词典.ForEach(q => __语法.Append(q).Append("|"));
            if (__词典.Count > 0)
            {
                __语法.Remove(__语法.Length - 1, 1);
            }
            __语法.Append(";");
            设置语法(__语法.ToString());
        }

        private string 解析语法id(string __语法)
        {
            var __起始索引 = __语法.IndexOf("!grammar ");
            var __结束索引 = __语法.IndexOf(";", __起始索引);
            return __语法.Substring(__起始索引 + 9, __结束索引 - __起始索引 - 9);
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
            return "appid = {0}, engine_start=asr, asr_res_path=fo|res\\asr\\common.jet";
        }

        protected override string 获取识别参数()
        {
            return string.Format("engine_type = local, asr_res_path = {0}, sample_rate=16000, grm_build_path = {1},local_grammar = {2},result_type = plain, result_encoding = gb2312, asr_threshold = {3}", ASR_RES_PATH, GRM_BUILD_PATH, _语法id, 置信度);
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
                return Dll离线识别.MSPLogin(user, password, configs);
            }

            public int MSPLogout()
            {
                return Dll离线识别.MSPLogout();
            }

            public IntPtr QISRSessionBegin(string grammarList, string _params, ref int errorCode)
            {
                return Dll离线识别.QISRSessionBegin(grammarList, _params, ref errorCode);
            }

            public int QISRAudioWrite(IntPtr sessionID, byte[] waveData, uint waveLen, E音频块位置 audioStatus, ref E检测状态 epStatus, ref E识别状态 recogStatus)
            {
                return Dll离线识别.QISRAudioWrite(sessionID, waveData, waveLen, audioStatus, ref epStatus, ref recogStatus);
            }

            public IntPtr QISRGetResult(IntPtr sessionID, ref E识别状态 rsltStatus, int waitTime, ref int errorCode)
            {
                return Dll离线识别.QISRGetResult(sessionID, ref rsltStatus, waitTime, ref errorCode);
            }

            public int QISRSessionEnd(IntPtr sessionID, string hints)
            {
                return Dll离线识别.QISRSessionEnd(sessionID, hints);
            }
        }
    }
}
