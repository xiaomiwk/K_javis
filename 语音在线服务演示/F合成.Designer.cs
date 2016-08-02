namespace 语音在线服务演示
{
    partial class F合成
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
            this.inAPPID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.do注销 = new System.Windows.Forms.Button();
            this.do登录 = new System.Windows.Forms.Button();
            this.in文本 = new System.Windows.Forms.RichTextBox();
            this.do合成 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inAPPID
            // 
            this.inAPPID.Location = new System.Drawing.Point(23, 54);
            this.inAPPID.Name = "inAPPID";
            this.inAPPID.Size = new System.Drawing.Size(100, 21);
            this.inAPPID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "APPID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "请输入文本";
            // 
            // do注销
            // 
            this.do注销.Location = new System.Drawing.Point(275, 290);
            this.do注销.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.do注销.Name = "do注销";
            this.do注销.Size = new System.Drawing.Size(100, 26);
            this.do注销.TabIndex = 11;
            this.do注销.Text = "注销";
            this.do注销.UseVisualStyleBackColor = true;
            // 
            // do登录
            // 
            this.do登录.Location = new System.Drawing.Point(23, 290);
            this.do登录.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.do登录.Name = "do登录";
            this.do登录.Size = new System.Drawing.Size(100, 26);
            this.do登录.TabIndex = 10;
            this.do登录.Text = "登录";
            this.do登录.UseVisualStyleBackColor = true;
            // 
            // in文本
            // 
            this.in文本.Location = new System.Drawing.Point(23, 135);
            this.in文本.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.in文本.Name = "in文本";
            this.in文本.Size = new System.Drawing.Size(418, 134);
            this.in文本.TabIndex = 8;
            this.in文本.Text = "";
            // 
            // do合成
            // 
            this.do合成.Location = new System.Drawing.Point(129, 290);
            this.do合成.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.do合成.Name = "do合成";
            this.do合成.Size = new System.Drawing.Size(140, 26);
            this.do合成.TabIndex = 15;
            this.do合成.Text = "合成&&播放&&保存";
            this.do合成.UseVisualStyleBackColor = true;
            // 
            // F合成
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.do合成);
            this.Controls.Add(this.inAPPID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.do注销);
            this.Controls.Add(this.do登录);
            this.Controls.Add(this.in文本);
            this.Name = "F合成";
            this.Size = new System.Drawing.Size(481, 351);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inAPPID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button do注销;
        private System.Windows.Forms.Button do登录;
        private System.Windows.Forms.RichTextBox in文本;
        private System.Windows.Forms.Button do合成;
    }
}
