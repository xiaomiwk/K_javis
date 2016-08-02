using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace 语音
{
    class Dll离线识别
    {
        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPLogin(string user, string password, string configs);

        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPLogout();

        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRBuildGrammar([MarshalAs(UnmanagedType.AnsiBStr)]string grammarType, [MarshalAs(UnmanagedType.AnsiBStr)]string grammarContent, int grammarLength, [MarshalAs(UnmanagedType.AnsiBStr)]string grammarParams, IntPtr callback, IntPtr userData);

        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr QISRSessionBegin(string grammarList, string _params, ref int errorCode);

        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRAudioWrite(IntPtr sessionID, byte[] waveData, uint waveLen, E音频块位置 audioStatus, ref  E检测状态 epStatus, ref E识别状态 recogStatus);

        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr QISRGetResult(IntPtr sessionID, ref E识别状态 rsltStatus, int waitTime, ref int errorCode);

        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRGetParam(IntPtr sessionID, string paramName, string paramValue, ref uint valueLen);

        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int QISRSessionEnd(IntPtr sessionID, string hints);

        [DllImport("msc_语音离线识别.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr QISRUploadData(string lexiconName, string lexiconContent, string _params);


        //[DllImport("xf_voice_dll.dll", CallingConvention = CallingConvention.StdCall)]
        //public static extern int XfBuildGrammerWithFiles(string grammarType, string grammarfile, string _params);

        //[DllImport("xf_voice_dll.dll", CallingConvention = CallingConvention.StdCall)]
        //public static extern int XfBuildGrammerWithContexts(string grammarType, string pContexts, string _params, ref byte[] _paramsid);

    }
}
