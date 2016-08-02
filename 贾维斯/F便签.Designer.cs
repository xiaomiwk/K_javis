namespace 贾维斯
{
    partial class F便签
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
            this.in文本 = new System.Windows.Forms.RichTextBox();
            this.do撤销 = new Utility.WindowsForm.U按钮();
            this.do保存 = new Utility.WindowsForm.U按钮();
            this.in重要性 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.in紧急性 = new System.Windows.Forms.ComboBox();
            this.do设置 = new Utility.WindowsForm.U按钮();
            this.do听写 = new Utility.WindowsForm.U按钮();
            this.SuspendLayout();
            // 
            // in文本
            // 
            this.in文本.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in文本.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.in文本.Location = new System.Drawing.Point(3, 3);
            this.in文本.Name = "in文本";
            this.in文本.Size = new System.Drawing.Size(894, 456);
            this.in文本.TabIndex = 0;
            this.in文本.Text = "";
            // 
            // do撤销
            // 
            this.do撤销.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.do撤销.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            this.do撤销.FlatAppearance.BorderSize = 0;
            this.do撤销.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do撤销.ForeColor = System.Drawing.Color.White;
            this.do撤销.Location = new System.Drawing.Point(214, 473);
            this.do撤销.Name = "do撤销";
            this.do撤销.Size = new System.Drawing.Size(100, 26);
            this.do撤销.TabIndex = 2;
            this.do撤销.Text = "撤销";
            this.do撤销.UseVisualStyleBackColor = false;
            this.do撤销.大小 = new System.Drawing.Size(100, 26);
            this.do撤销.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            // 
            // do保存
            // 
            this.do保存.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.do保存.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            this.do保存.FlatAppearance.BorderSize = 0;
            this.do保存.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do保存.ForeColor = System.Drawing.Color.White;
            this.do保存.Location = new System.Drawing.Point(108, 473);
            this.do保存.Name = "do保存";
            this.do保存.Size = new System.Drawing.Size(100, 26);
            this.do保存.TabIndex = 1;
            this.do保存.Text = "保存";
            this.do保存.UseVisualStyleBackColor = false;
            this.do保存.大小 = new System.Drawing.Size(100, 26);
            this.do保存.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            // 
            // in重要性
            // 
            this.in重要性.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.in重要性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.in重要性.FormattingEnabled = true;
            this.in重要性.Location = new System.Drawing.Point(446, 473);
            this.in重要性.Name = "in重要性";
            this.in重要性.Size = new System.Drawing.Size(121, 25);
            this.in重要性.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "重要性:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "紧急性:";
            // 
            // in紧急性
            // 
            this.in紧急性.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.in紧急性.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.in紧急性.FormattingEnabled = true;
            this.in紧急性.Location = new System.Drawing.Point(638, 473);
            this.in紧急性.Name = "in紧急性";
            this.in紧急性.Size = new System.Drawing.Size(121, 25);
            this.in紧急性.TabIndex = 5;
            // 
            // do设置
            // 
            this.do设置.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.do设置.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            this.do设置.FlatAppearance.BorderSize = 0;
            this.do设置.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do设置.ForeColor = System.Drawing.Color.White;
            this.do设置.Location = new System.Drawing.Point(765, 473);
            this.do设置.Name = "do设置";
            this.do设置.Size = new System.Drawing.Size(100, 26);
            this.do设置.TabIndex = 7;
            this.do设置.Text = "设置";
            this.do设置.UseVisualStyleBackColor = false;
            this.do设置.大小 = new System.Drawing.Size(100, 26);
            this.do设置.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            // 
            // do听写
            // 
            this.do听写.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.do听写.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            this.do听写.FlatAppearance.BorderSize = 0;
            this.do听写.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do听写.ForeColor = System.Drawing.Color.White;
            this.do听写.Location = new System.Drawing.Point(2, 472);
            this.do听写.Name = "do听写";
            this.do听写.Size = new System.Drawing.Size(100, 26);
            this.do听写.TabIndex = 8;
            this.do听写.Text = "听写";
            this.do听写.UseVisualStyleBackColor = false;
            this.do听写.大小 = new System.Drawing.Size(100, 26);
            this.do听写.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            // 
            // F便签
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.do听写);
            this.Controls.Add(this.do设置);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.in紧急性);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.in重要性);
            this.Controls.Add(this.do撤销);
            this.Controls.Add(this.do保存);
            this.Controls.Add(this.in文本);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "F便签";
            this.Size = new System.Drawing.Size(900, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox in文本;
        private Utility.WindowsForm.U按钮 do保存;
        private Utility.WindowsForm.U按钮 do撤销;
        private System.Windows.Forms.ComboBox in重要性;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox in紧急性;
        private Utility.WindowsForm.U按钮 do设置;
        private Utility.WindowsForm.U按钮 do听写;
    }
}
