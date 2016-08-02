using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 语音
{
    public interface IX识别
    {
        void 登录(string appid);

        void 注销();

        int 音频采样率 { get; }

        /// <summary>
        /// 0-100
        /// </summary>
        int 置信度 { get; set; }

        void 设置语法(string 语法);

        void 设置语法(List<string> 词典);

        void 输入数据(byte[] 语音);

        void 开始();

        void 结束();

        /// <summary>
        /// string: 内容, int: 置信度
        /// </summary>
        event Action<string, int> 识别出内容;

    }
}
