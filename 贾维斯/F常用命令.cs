using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.存储;
using 语音;

namespace 贾维斯
{
    public partial class F常用命令 : UserControl
    {
        private E语音 _当前语音 = E语音.无;

        private IX识别 _IX识别;

        private D命令 _D命令 = new D命令();

        private List<M命令> _命令缓存;

        private BMIC _MIC = new BMIC();

        private M命令 _待确定命令;

        public F常用命令()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.in表格.CellClick += in表格_CellClick;

            _命令缓存 = _D命令.查询();
            刷新表格();

            this.in无语音.Checked = true;
            this.in离线语音.Click += 选择语音;
            this.in无语音.Click += 选择语音;
            this.in在线语音.Click += 选择语音;
            _MIC.收到数据 += (__数据, __长度) => _IX识别.输入数据(__数据);
        }

        void 选择语音(object sender, EventArgs e)
        {
            var __新语音 = E语音.在线;
            if (this.in无语音.Checked)
            {
                __新语音 = E语音.无;
            }
            if (this.in离线语音.Checked)
            {
                __新语音 = E语音.离线;
            }
            if (__新语音 != _当前语音)
            {
                切换语音(_当前语音, __新语音);
                _当前语音 = __新语音;
            }
        }

        void 切换语音(E语音 __旧语音, E语音 __新语音)
        {
            switch (__旧语音)
            {
                case E语音.无:
                    break;
                case E语音.离线:
                case E语音.在线:
                    _MIC.停止录音();
                    _IX识别.识别出内容 -= _IX识别_识别出内容;
                    _IX识别.结束();
                    _IX识别.注销();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            switch (__新语音)
            {
                case E语音.无:
                    break;
                case E语音.离线:
                    _IX识别 = new X离线识别();
                    _IX识别.登录(HINI.Read("配置.ini", "讯飞语音", "离线识别APPID"));
                    开始();
                    播放(__新语音, "欢迎使用离线语音服务");
                    break;
                case E语音.在线:
                    _IX识别 = new X在线识别();
                    _IX识别.登录(HINI.Read("配置.ini", "讯飞语音", "在线服务APPID"));
                    开始();
                    播放(__新语音, "欢迎使用在线语音服务");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void 开始()
        {
            var __命令列表 = new List<string>(_命令缓存.FindAll(q => q.启用).Select(q => q.命令).ToList());
            __命令列表.Add("确定");
            _IX识别.设置语法(__命令列表);
            _IX识别.开始();
            _IX识别.识别出内容 += _IX识别_识别出内容;
            _MIC.开始录音();
        }

        void _IX识别_识别出内容(string __内容, int __置信率)
        {
            Debug.WriteLine("识别出内容: {0}({1})", __内容, __置信率);

            if (__内容 == "确定" && _待确定命令 != null)
            {
                运行命令(_待确定命令);
                _待确定命令 = null;
                return;
            }

            var __匹配命令 = _命令缓存.Find(q => q.命令 == __内容.Replace(" ", ""));
            if (__匹配命令 == null)
            {
                __匹配命令 = _命令缓存.Find(q => __内容.EndsWith(q.命令));
                if (__匹配命令 == null)
                {
                    return;
                }
            }
            if (__匹配命令.需要确认)
            {
                _待确定命令 = __匹配命令;
                播放(_当前语音, string.Format("确定要{0}吗?", __匹配命令.命令));
                return;
            }
            运行命令(__匹配命令);
        }

        private void 刷新表格()
        {
            this.in表格.Rows.Clear();
            _命令缓存.ForEach(q =>
            {
                var __行号 = this.in表格.Rows.Add(q.启用, q.命令, q.需要确认, q.目录, q.文件名, q.执行参数, q.显示顺序, "修改", "删除", "运行");
                this.in表格.Rows[__行号].Tag = q;
            });

            this.in表格.Rows.Add(true, "", false, "", "", "", "0", "增加", "", "运行");
        }

        void in表格_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var __行 = this.in表格.Rows[e.RowIndex];
            var __列名 = this.in表格.Columns[e.ColumnIndex].Name;
            var __启用 = __行.Cells["in启用"].Value != null && (bool)__行.Cells["in启用"].Value;
            var __命令 = (string)__行.Cells["in命令"].Value;
            var __需要确认 = __行.Cells["in需要确认"].Value != null && (bool)__行.Cells["in需要确认"].Value;
            var __执行参数 = (string)__行.Cells["in执行参数"].Value;
            var __目录 = (string)__行.Cells["in目录"].Value;
            var __文件名 = (string)__行.Cells["in文件名"].Value;
            var __显示顺序 = int.Parse(__行.Cells["in显示顺序"].Value.ToString());
            if (__列名 == "do修改")
            {
                this.in表格.EndEdit();
                if (__行.Tag == null)
                {
                    var __M命令 = new M命令
                    {
                        执行参数 = __执行参数,
                        命令 = __命令,
                        目录 = __目录,
                        文件名 = __文件名,
                        启用 = __启用,
                        需要确认 = __需要确认,
                        显示顺序 = __显示顺序,
                    };
                    _D命令.增加(__M命令);
                    __行.Tag = __M命令;
                    __行.Cells["do修改"].Value = "修改";
                    __行.Cells["do删除"].Value = "删除";
                    this.in表格.Rows.Add(true, "", false, "", "", "", "0", "增加", "", "运行");
                }
                else
                {
                    var __M命令 = __行.Tag as M命令;
                    __M命令.命令 = __命令;
                    __M命令.目录 = __目录;
                    __M命令.文件名 = __文件名;
                    __M命令.启用 = __启用;
                    __M命令.需要确认 = __需要确认;
                    __M命令.执行参数 = __执行参数;
                    __M命令.显示顺序 = __显示顺序;
                    _D命令.修改(__M命令);
                }
                _命令缓存 = _D命令.查询();
                刷新表格();
                return;
            }
            if (__列名 == "do删除")
            {
                if (__行.Tag == null)
                {
                    __行.Cells["in命令"].Value = "";
                    __行.Cells["in目录"].Value = "";
                    __行.Cells["in文件名"].Value = "";
                    __行.Cells["in执行参数"].Value = "";
                    __行.Cells["in启用"].Value = true;
                    __行.Cells["in需要确认"].Value = false;
                    __行.Cells["in显示顺序"].Value = "0";
                }
                else
                {
                    var __M命令 = __行.Tag as M命令;
                    _D命令.删除(__M命令);
                    this.in表格.Rows.RemoveAt(e.RowIndex);
                    _命令缓存 = _D命令.查询();
                }
                return;
            }
            if (__列名 == "do运行")
            {
                M命令 __M命令;
                if (__行.Tag == null)
                {
                    __M命令 = new M命令
                    {
                        执行参数 = __执行参数,
                        命令 = __命令,
                        目录 = __目录,
                        文件名 = __文件名,
                        启用 = __启用,
                        需要确认 = __需要确认,
                        显示顺序 = __显示顺序,
                    };
                }
                else
                {
                    __M命令 = __行.Tag as M命令;
                }
                if (__M命令.需要确认)
                {
                    if (MessageBox.Show(string.Format("确定要 [{0}] 吗?", __M命令.命令), "", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                运行命令(__M命令);
            }
        }

        private void 运行命令(M命令 __命令)
        {
            if (__命令.需要确认)
            {

            }
            try
            {
                var __processInfo = new ProcessStartInfo(__命令.目录 == null ? __命令.文件名 : Path.Combine(__命令.目录, __命令.文件名), __命令.执行参数);
                if (!string.IsNullOrEmpty(__命令.目录))
                {
                    __processInfo.WorkingDirectory = __命令.目录;
                }
                Process.Start(__processInfo);
            }
            catch (Exception ex)
            {
                播放(_当前语音, "出错了");
                MessageBox.Show(string.Format("执行 {0} 出错!\n{1}", __命令, ex.Message), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 播放(E语音 __语音, string __内容)
        {
            switch (__语音)
            {
                case E语音.无:
                    break;
                case E语音.离线:
                    X离线播放.播放(HINI.Read("配置.ini", "讯飞语音", "离线合成APPID"), __内容);
                    break;
                case E语音.在线:
                    X在线播放.播放(__内容);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
