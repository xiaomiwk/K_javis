namespace 贾维斯
{
    partial class F常用命令
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.in表格 = new System.Windows.Forms.DataGridView();
            this.in离线语音 = new System.Windows.Forms.RadioButton();
            this.in在线语音 = new System.Windows.Forms.RadioButton();
            this.in无语音 = new System.Windows.Forms.RadioButton();
            this.in启用 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.in命令 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in需要确认 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.in目录 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in文件名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in执行参数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in显示顺序 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.do修改 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.do删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.do运行 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.in表格)).BeginInit();
            this.SuspendLayout();
            // 
            // in表格
            // 
            this.in表格.AllowUserToAddRows = false;
            this.in表格.AllowUserToDeleteRows = false;
            this.in表格.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in表格.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.in表格.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.in表格.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.in表格.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.in启用,
            this.in命令,
            this.in需要确认,
            this.in目录,
            this.in文件名,
            this.in执行参数,
            this.in显示顺序,
            this.do修改,
            this.do删除,
            this.do运行});
            this.in表格.GridColor = System.Drawing.SystemColors.ControlLight;
            this.in表格.Location = new System.Drawing.Point(0, 0);
            this.in表格.Name = "in表格";
            this.in表格.RowHeadersVisible = false;
            this.in表格.RowTemplate.Height = 23;
            this.in表格.Size = new System.Drawing.Size(847, 427);
            this.in表格.TabIndex = 7;
            // 
            // in离线语音
            // 
            this.in离线语音.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.in离线语音.AutoSize = true;
            this.in离线语音.BackColor = System.Drawing.Color.Transparent;
            this.in离线语音.ForeColor = System.Drawing.Color.Gray;
            this.in离线语音.Location = new System.Drawing.Point(3, 443);
            this.in离线语音.Name = "in离线语音";
            this.in离线语音.Size = new System.Drawing.Size(74, 21);
            this.in离线语音.TabIndex = 10;
            this.in离线语音.TabStop = true;
            this.in离线语音.Text = "离线语音";
            this.in离线语音.UseVisualStyleBackColor = false;
            // 
            // in在线语音
            // 
            this.in在线语音.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.in在线语音.AutoSize = true;
            this.in在线语音.BackColor = System.Drawing.Color.Transparent;
            this.in在线语音.ForeColor = System.Drawing.Color.Gray;
            this.in在线语音.Location = new System.Drawing.Point(83, 443);
            this.in在线语音.Name = "in在线语音";
            this.in在线语音.Size = new System.Drawing.Size(74, 21);
            this.in在线语音.TabIndex = 9;
            this.in在线语音.TabStop = true;
            this.in在线语音.Text = "在线语音";
            this.in在线语音.UseVisualStyleBackColor = false;
            // 
            // in无语音
            // 
            this.in无语音.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.in无语音.AutoSize = true;
            this.in无语音.BackColor = System.Drawing.Color.Transparent;
            this.in无语音.ForeColor = System.Drawing.Color.Gray;
            this.in无语音.Location = new System.Drawing.Point(163, 443);
            this.in无语音.Name = "in无语音";
            this.in无语音.Size = new System.Drawing.Size(62, 21);
            this.in无语音.TabIndex = 8;
            this.in无语音.TabStop = true;
            this.in无语音.Text = "无语音";
            this.in无语音.UseVisualStyleBackColor = false;
            // 
            // in启用
            // 
            this.in启用.HeaderText = "启用";
            this.in启用.Name = "in启用";
            this.in启用.Width = 60;
            // 
            // in命令
            // 
            this.in命令.HeaderText = "命令";
            this.in命令.Name = "in命令";
            this.in命令.Width = 150;
            // 
            // in需要确认
            // 
            this.in需要确认.HeaderText = "需要确认";
            this.in需要确认.Name = "in需要确认";
            this.in需要确认.Width = 80;
            // 
            // in目录
            // 
            this.in目录.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.in目录.HeaderText = "目录";
            this.in目录.Name = "in目录";
            // 
            // in文件名
            // 
            this.in文件名.HeaderText = "文件名";
            this.in文件名.Name = "in文件名";
            this.in文件名.Width = 180;
            // 
            // in执行参数
            // 
            this.in执行参数.HeaderText = "执行参数";
            this.in执行参数.Name = "in执行参数";
            // 
            // in显示顺序
            // 
            this.in显示顺序.HeaderText = "显示顺序";
            this.in显示顺序.Name = "in显示顺序";
            this.in显示顺序.Width = 80;
            // 
            // do修改
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.do修改.DefaultCellStyle = dataGridViewCellStyle1;
            this.do修改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do修改.HeaderText = "";
            this.do修改.Name = "do修改";
            this.do修改.Text = "修改";
            this.do修改.Width = 80;
            // 
            // do删除
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.do删除.DefaultCellStyle = dataGridViewCellStyle2;
            this.do删除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do删除.HeaderText = "";
            this.do删除.Name = "do删除";
            this.do删除.Text = "删除";
            this.do删除.Width = 80;
            // 
            // do运行
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.do运行.DefaultCellStyle = dataGridViewCellStyle3;
            this.do运行.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do运行.HeaderText = "";
            this.do运行.Name = "do运行";
            this.do运行.Text = "运行";
            this.do运行.Width = 80;
            // 
            // F常用命令
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.in离线语音);
            this.Controls.Add(this.in在线语音);
            this.Controls.Add(this.in无语音);
            this.Controls.Add(this.in表格);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "F常用命令";
            this.Size = new System.Drawing.Size(847, 477);
            ((System.ComponentModel.ISupportInitialize)(this.in表格)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView in表格;
        private System.Windows.Forms.RadioButton in离线语音;
        private System.Windows.Forms.RadioButton in在线语音;
        private System.Windows.Forms.RadioButton in无语音;
        private System.Windows.Forms.DataGridViewCheckBoxColumn in启用;
        private System.Windows.Forms.DataGridViewTextBoxColumn in命令;
        private System.Windows.Forms.DataGridViewCheckBoxColumn in需要确认;
        private System.Windows.Forms.DataGridViewTextBoxColumn in目录;
        private System.Windows.Forms.DataGridViewTextBoxColumn in文件名;
        private System.Windows.Forms.DataGridViewTextBoxColumn in执行参数;
        private System.Windows.Forms.DataGridViewTextBoxColumn in显示顺序;
        private System.Windows.Forms.DataGridViewButtonColumn do修改;
        private System.Windows.Forms.DataGridViewButtonColumn do删除;
        private System.Windows.Forms.DataGridViewButtonColumn do运行;
    }
}
