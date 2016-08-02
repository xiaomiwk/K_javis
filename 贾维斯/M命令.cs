using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 贾维斯
{
    public class M命令
    {
        public bool 启用 { get; set; }

        public string 命令 { get; set; }

        public bool 需要确认 { get; set; }

        public string 目录 { get; set; }

        public string 文件名 { get; set; }

        public string 执行参数 { get; set; }

        public int 显示顺序 { get; set; }
    }
}
