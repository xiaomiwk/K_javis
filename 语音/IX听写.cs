using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 语音
{
    public interface IX听写
    {
        void 登录(string appid);

        void 注销();

        int 音频采样率 { get; }

        void 上传词典(List<string> 词典);

        void 输入数据(byte[] 语音);

        void 开始();

        void 结束();

        event Action<string> 识别出内容;
    }
}
