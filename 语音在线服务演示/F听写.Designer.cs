namespace 语音在线服务演示
{
    partial class F听写
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.do注销 = new System.Windows.Forms.Button();
            this.do登录 = new System.Windows.Forms.Button();
            this.do停止监听 = new System.Windows.Forms.Button();
            this.do监听MIC = new System.Windows.Forms.Button();
            this.inAPPID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.in语法 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.in文本 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // do注销
            // 
            this.do注销.Location = new System.Drawing.Point(514, 25);
            this.do注销.Name = "do注销";
            this.do注销.Size = new System.Drawing.Size(100, 26);
            this.do注销.TabIndex = 8;
            this.do注销.Text = "注销";
            this.do注销.UseVisualStyleBackColor = true;
            // 
            // do登录
            // 
            this.do登录.Location = new System.Drawing.Point(196, 25);
            this.do登录.Name = "do登录";
            this.do登录.Size = new System.Drawing.Size(100, 26);
            this.do登录.TabIndex = 7;
            this.do登录.Text = "登录";
            this.do登录.UseVisualStyleBackColor = true;
            // 
            // do停止监听
            // 
            this.do停止监听.Location = new System.Drawing.Point(408, 25);
            this.do停止监听.Name = "do停止监听";
            this.do停止监听.Size = new System.Drawing.Size(100, 26);
            this.do停止监听.TabIndex = 11;
            this.do停止监听.Text = "停止监听";
            this.do停止监听.UseVisualStyleBackColor = true;
            // 
            // do监听MIC
            // 
            this.do监听MIC.Location = new System.Drawing.Point(302, 25);
            this.do监听MIC.Name = "do监听MIC";
            this.do监听MIC.Size = new System.Drawing.Size(100, 26);
            this.do监听MIC.TabIndex = 12;
            this.do监听MIC.Text = "监听MIC";
            this.do监听MIC.UseVisualStyleBackColor = true;
            // 
            // inAPPID
            // 
            this.inAPPID.Location = new System.Drawing.Point(71, 27);
            this.inAPPID.Name = "inAPPID";
            this.inAPPID.Size = new System.Drawing.Size(100, 21);
            this.inAPPID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "APPID";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(24, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.in语法);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.in文本);
            this.splitContainer1.Size = new System.Drawing.Size(650, 329);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "语法";
            // 
            // in语法
            // 
            this.in语法.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in语法.Location = new System.Drawing.Point(0, 29);
            this.in语法.Name = "in语法";
            this.in语法.Size = new System.Drawing.Size(324, 297);
            this.in语法.TabIndex = 12;
            this.in语法.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "识别结果";
            // 
            // in文本
            // 
            this.in文本.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in文本.Location = new System.Drawing.Point(5, 29);
            this.in文本.Name = "in文本";
            this.in文本.Size = new System.Drawing.Size(311, 297);
            this.in文本.TabIndex = 10;
            this.in文本.Text = "";
            // 
            // F听写
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.inAPPID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.do监听MIC);
            this.Controls.Add(this.do停止监听);
            this.Controls.Add(this.do注销);
            this.Controls.Add(this.do登录);
            this.Name = "F听写";
            this.Size = new System.Drawing.Size(700, 408);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button do注销;
        private System.Windows.Forms.Button do登录;
        private System.Windows.Forms.Button do停止监听;
        private System.Windows.Forms.Button do监听MIC;
        private System.Windows.Forms.TextBox inAPPID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox in语法;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox in文本;
    }
}

