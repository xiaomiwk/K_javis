using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace 语音
{
    public static class H日志输出
    {
        private static Action<string, string, TraceEventType> _记录信息;

        private static Action<Exception, string, TraceEventType> _记录异常;

        /// <param name="__记录信息">string __概要, string __详细 = null, TraceEventType __等级</param>
        /// <param name="__记录异常">Exception __异常, string __描述 = null, TraceEventType __等级</param>
        public static void 设置(Action<string, string, TraceEventType> __记录信息, Action<Exception, string, TraceEventType> __记录异常)
        {
            _记录信息 = __记录信息;
            _记录异常 = __记录异常;
        }

        internal static void 记录(string __概要, string __详细 = null, TraceEventType __等级 = TraceEventType.Verbose)
        {
            //Debug.WriteLine("{3,-14} {2,-10}\t{0}\t{1}", __概要, __详细, __等级, DateTime.Now.ToString("hh:mm:ss.FFF"));
            if (_记录信息 != null)
            {
                _记录信息(__概要, __详细, __等级);
            }
        }

        internal static void 记录(Exception __异常, string __描述 = null, TraceEventType __等级 = TraceEventType.Error)
        {
            //Debug.WriteLine("{3,-14} {2,-10}\t{0}\t{1}", __描述, __异常, __等级, DateTime.Now.ToString("hh:mm:ss.FFF"));
            if (_记录异常 != null)
            {
                _记录异常(__异常, __描述, __等级);
            }
        }
    }
}
