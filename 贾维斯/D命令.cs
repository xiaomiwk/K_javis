using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utility.存储;

namespace 贾维斯
{
    class D命令
    {
        private List<M命令> _缓存 = new List<M命令>();

        private string _文件名 = "常用命令.json";

        public D命令()
        {
            if (H路径.验证文件是否存在(_文件名))
            {
                _缓存 = H序列化.FromJSON字符串<List<M命令>>(File.ReadAllText(H路径.获取绝对路径(_文件名), Encoding.UTF8));
            }
        }

        public void 增加(M命令 __命令)
        {
            _缓存.Add(__命令);
            保存();
        }

        public void 修改(M命令 __命令)
        {
            保存();
        }

        public void 删除(M命令 __命令)
        {
            _缓存.Remove(__命令);
            保存();
        }

        public List<M命令> 查询()
        {
            return new List<M命令>(_缓存);
        }

        private void 保存()
        {
            _缓存.Sort((n, m) => {
                                   if (m.显示顺序.CompareTo(n.显示顺序) == 0)
                                   {
                                       return m.文件名.CompareTo(n.文件名);
                                   }
                                   else
                                   {
                                       return m.显示顺序.CompareTo(n.显示顺序);
                                   }
            });
            File.WriteAllText(H路径.获取绝对路径(_文件名), H序列化.ToJSON字符串(_缓存), Encoding.UTF8);
        }
    }
}
