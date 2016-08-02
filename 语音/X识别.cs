using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace 语音
{
    public interface IX识别DLL
    {
        int MSPLogin(string user, string password, string configs);

        int MSPLogout();

        IntPtr QISRSessionBegin(string grammarList, string _params, ref int errorCode);

        int QISRAudioWrite(IntPtr sessionID, byte[] waveData, uint waveLen, E音频块位置 audioStatus, ref  E检测状态 epStatus, ref E识别状态 recogStatus);

        IntPtr QISRGetResult(IntPtr sessionID, ref E识别状态 rsltStatus, int waitTime, ref int errorCode);

        int QISRSessionEnd(IntPtr sessionID, string hints);
    }

    public abstract class X识别 : IX识别
    {
        private IntPtr _会话 = IntPtr.Zero;

        private E检测状态 _检测状态 = E检测状态.等待输入;

        private E识别状态 _识别状态 = E识别状态.正在识别中;

        private E任务状态 _任务状态 = E任务状态.停止;

        private enum E任务状态
        {
            停止, 停止中, 运行中
        }

        protected abstract IX识别DLL DLL接口 { get; }

        protected X识别()
        {
            this.置信度 = 30;
        }

        public void 登录(string appid)
        {
            int __结果 = DLL接口.MSPLogin(string.Empty, string.Empty, string.Format(获取登录参数(), appid));
            if (__结果 != (int)ErrorCode.MSP_SUCCESS)
            {
                throw new ApplicationException("登录失败! 错误码: " + __结果);
            }
        }

        public void 注销()
        {
            int __结果 = DLL接口.MSPLogout();
            if (__结果 != (int)ErrorCode.MSP_SUCCESS)
            {
                throw new ApplicationException("注销失败! 错误码: " + __结果);
            }
        }

        public int 数据单块最大长度 { get { return 3200; } }

        public int 音频采样率 { get { return 16000; } }

        public int 置信度 { get; set; }

        protected abstract string 获取登录参数();

        protected abstract string 获取识别参数();

        protected abstract string 获取语法id();

        public abstract void 设置语法(string __语法);

        public abstract void 设置语法(List<string> __词典);

        public void 输入数据(byte[] __数据)
        {
            if (_会话 == IntPtr.Zero || _任务状态 != E任务状态.运行中)
            {
                Debug.Write("X");
                return;
            }
            var __识别状态 = E识别状态.正在识别中;
            if (_检测状态 == E检测状态.等待输入)
            {
                Debug.Write(">");
                DLL接口.QISRAudioWrite(_会话, __数据, (uint)__数据.Length, E音频块位置.第一块, ref _检测状态, ref __识别状态);
            }
            else if (_检测状态 == E检测状态.处理中)
            {
                Debug.Write(">");
                DLL接口.QISRAudioWrite(_会话, __数据, (uint)__数据.Length, E音频块位置.中间, ref _检测状态, ref __识别状态);
            }
            else
            {
                Debug.Write("X");
            }
            //Debug.Write(_检测状态 + "," + _识别状态);
        }

        public void 开始()
        {
            while (_任务状态 != E任务状态.停止)
            {
                Thread.Sleep(300);
            }
            _任务状态 = E任务状态.运行中;
            new Thread(识别) { IsBackground = true }.Start();
        }

        void 识别()
        {
            while (_任务状态 == E任务状态.运行中)
            {
                int __结果 = 0;
                try
                {
                    _会话 = DLL接口.QISRSessionBegin(获取语法id(), 获取识别参数(), ref __结果); //重新开始会话 
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("开启会话出错: " + ex);
                    Thread.Sleep(300);
                    continue;
                }
                _检测状态 = E检测状态.等待输入;
                _识别状态 = E识别状态.正在识别中;
                if (__结果 != 0)
                {
                    Debug.WriteLine("开启会话出错, 错误码: " + __结果);
                    Thread.Sleep(300);
                    continue;
                }
                Debug.WriteLine("开启会话");

                while (_任务状态 == E任务状态.运行中 && _识别状态 != E识别状态.识别结束 && _识别状态 != E识别状态.没有识别结果)
                {
                    if (_检测状态 == E检测状态.等待输入)
                    {
                        Debug.Write("-");
                        Thread.Sleep(300);
                        continue;
                    }

                    IntPtr __识别结果 = DLL接口.QISRGetResult(_会话, ref _识别状态, 0, ref __结果);
                    //Debug.WriteLine("任务状态: {0}; 识别状态: {1}", _任务状态, _识别状态);
                    if (__结果 == 0)
                    {
                        if (__识别结果 != IntPtr.Zero)
                        {
                            var __文本 = Marshal.PtrToStringAnsi(__识别结果);
                            Debug.Write("\n识别出命令: " + Environment.NewLine + __文本 + Environment.NewLine);
                            分析识别结果(__文本);
                        }
                        Debug.Write(".");
                    }
                    else
                    {
                        Debug.WriteLine("\n识别出错: {0}", __结果);
                        break;
                    }
                    Thread.Sleep(300);
                }
                Debug.WriteLineIf(_任务状态 != E任务状态.运行中 || _识别状态 != E识别状态.识别结束, string.Format("\n任务状态: {0}; 识别状态: {1}; 检测状态: {2}", _任务状态, _识别状态, _检测状态));
                try
                {
                    __结果 = DLL接口.QISRSessionEnd(_会话, null);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(Environment.NewLine + "结束会话出错: " + ex + Environment.NewLine);
                }
                _会话 = IntPtr.Zero;
                if (__结果 == 0)
                {
                    Debug.WriteLine(Environment.NewLine + "结束会话" + Environment.NewLine);
                }
                else
                {
                    Debug.WriteLine(Environment.NewLine + "结束会话出错, 错误码: " + __结果 + Environment.NewLine);
                }
            }
            _任务状态 = E任务状态.停止;
        }

        protected abstract void 分析识别结果(string __结果);

        public void 结束()
        {
            DLL接口.QISRAudioWrite(_会话, null, 0, E音频块位置.最后一块, ref _检测状态, ref _识别状态);
            _任务状态 = E任务状态.停止中;
        }

        public event Action<string, int> 识别出内容;

        protected virtual void On识别出内容(string __内容, int __置信度)
        {
            var handler = 识别出内容;
            if (handler != null) handler(__内容, __置信度);
        }

    }
}
