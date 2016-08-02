using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 语音
{
    public interface IX合成
    {
        void 登录(string appid);

        void 注销();

        int 音频采样率 { get; }

        /// <returns>wave音频数据</returns>
        MemoryStream 合成(string 文本);
    }
}
