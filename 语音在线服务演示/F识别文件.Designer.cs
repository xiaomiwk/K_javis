namespace 语音在线服务演示
{
    partial class F识别文件
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
            this.label1 = new System.Windows.Forms.Label();
            this.do注销 = new System.Windows.Forms.Button();
            this.do登录 = new System.Windows.Forms.Button();
            this.do识别文件 = new System.Windows.Forms.Button();
            this.in文本 = new System.Windows.Forms.RichTextBox();
            this.inAPPID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "识别结果";
            // 
            // do注销
            // 
            this.do注销.Location = new System.Drawing.Point(408, 25);
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
            // do识别文件
            // 
            this.do识别文件.Location = new System.Drawing.Point(302, 25);
            this.do识别文件.Name = "do识别文件";
            this.do识别文件.Size = new System.Drawing.Size(100, 26);
            this.do识别文件.TabIndex = 6;
            this.do识别文件.Text = "识别文件";
            this.do识别文件.UseVisualStyleBackColor = true;
            // 
            // in文本
            // 
            this.in文本.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.in文本.Location = new System.Drawing.Point(24, 99);
            this.in文本.Name = "in文本";
            this.in文本.Size = new System.Drawing.Size(652, 297);
            this.in文本.TabIndex = 5;
            this.in文本.Text = "";
            // 
            // inAPPID
            // 
            this.inAPPID.Location = new System.Drawing.Point(71, 27);
            this.inAPPID.Name = "inAPPID";
            this.inAPPID.Size = new System.Drawing.Size(100, 21);
            this.inAPPID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "APPID";
            // 
            // F识别文件
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.inAPPID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.do注销);
            this.Controls.Add(this.do登录);
            this.Controls.Add(this.do识别文件);
            this.Controls.Add(this.in文本);
            this.Name = "F识别文件";
            this.Size = new System.Drawing.Size(700, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button do注销;
        private System.Windows.Forms.Button do登录;
        private System.Windows.Forms.Button do识别文件;
        private System.Windows.Forms.RichTextBox in文本;
        private System.Windows.Forms.TextBox inAPPID;
        private System.Windows.Forms.Label label2;
    }
}

