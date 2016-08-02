using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace 语音
{
    class Dll离线合成
    {
        [DllImport("msc_语音离线合成.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPLogin(string user, string password, string configs);

        [DllImport("msc_语音离线合成.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int MSPLogout();

        [DllImport("msc_语音离线合成.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QTTSSessionBegin(string _params, ref int errorCode);

        [DllImport("msc_语音离线合成.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QTTSTextPut(IntPtr sessionID, string textString, uint textLen, string _params);

        [DllImport("msc_语音离线合成.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QTTSAudioGet(IntPtr sessionID, ref uint audioLen, ref E合成状态 synthStatus, ref int errorCode);

        [DllImport("msc_语音离线合成.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr QTTSAudioInfo(IntPtr sessionID);

        [DllImport("msc_语音离线合成.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int QTTSSessionEnd(IntPtr sessionID, string hints);

    }
}
