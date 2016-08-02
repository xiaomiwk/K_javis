using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace 语音
{
    //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    //public struct UserData
    //{
    //    public int build_fini; //标识语法构建是否完成

    //    public int update_fini;  //标识更新词典是否完成

    //    public int errcode; //记录语法构建或更新词典回调错误码

    //    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    //    public byte[] grammar_id; //保存语法构建返回的语法ID
    //}

    ////public delegate int GrammarCallBack(int errorCode, [MarshalAs(UnmanagedType.AnsiBStr)]string info, ref UserData userData);
    //public delegate int GrammarCallBack(int errorCode, string info, IntPtr userData);

    public class Dll在线
    {
        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPLogin(string user, string password, string configs);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPLogout();

        #region 听写识别

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRBuildGrammar([MarshalAs(UnmanagedType.AnsiBStr)]string grammarType, [MarshalAs(UnmanagedType.AnsiBStr)]string grammarContent, int grammarLength, [MarshalAs(UnmanagedType.AnsiBStr)]string grammarParams, IntPtr callback, IntPtr userData);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr QISRSessionBegin(string grammarList, string _params, ref int errorCode);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRAudioWrite(IntPtr sessionID, byte[] waveData, uint waveLen, E音频块位置 audioStatus, ref  E检测状态 epStatus, ref E识别状态 recogStatus);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr QISRGetResult(IntPtr sessionID, ref E识别状态 rsltStatus, int waitTime, ref int errorCode);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRGetParam(IntPtr sessionID, string paramName, string paramValue, ref uint valueLen);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRSessionEnd(IntPtr sessionID, string hints);

        [DllImport("msc_语音在线服务.dll", EntryPoint = "MSPUploadData", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MSPUploadData([MarshalAs(UnmanagedType.AnsiBStr)]string dataName, byte[] data, uint dataLen, [MarshalAs(UnmanagedType.AnsiBStr)]string _params, ref int errorCode);

        #endregion

        #region 合成
        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QTTSSessionBegin(string _params, ref int errorCode);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QTTSTextPut(IntPtr sessionID, string textString, uint textLen, string _params);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QTTSAudioGet(IntPtr sessionID, ref uint audioLen, ref E合成状态 synthStatus, ref int errorCode);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QTTSAudioInfo(IntPtr sessionID);

        [DllImport("msc_语音在线服务.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QTTSSessionEnd(IntPtr sessionID, string hints);

        #endregion

    }
}
