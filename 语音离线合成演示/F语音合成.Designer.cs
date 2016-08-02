namespace 语音离线合成演示
{
    partial class F语音合成
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F语音合成));
            this.in文本 = new System.Windows.Forms.RichTextBox();
            this.do合成 = new System.Windows.Forms.Button();
            this.do登录 = new System.Windows.Forms.Button();
            this.do注销 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inAPPID = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // in文本
            // 
            this.in文本.Location = new System.Drawing.Point(29, 135);
            this.in文本.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.in文本.Name = "in文本";
            this.in文本.Size = new System.Drawing.Size(418, 134);
            this.in文本.TabIndex = 0;
            this.in文本.Text = "";
            // 
            // do合成
            // 
            this.do合成.Location = new System.Drawing.Point(135, 290);
            this.do合成.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.do合成.Name = "do合成";
            this.do合成.Size = new System.Drawing.Size(140, 26);
            this.do合成.TabIndex = 1;
            this.do合成.Text = "合成&&播放&&保存";
            this.do合成.UseVisualStyleBackColor = true;
            // 
            // do登录
            // 
            this.do登录.Location = new System.Drawing.Point(29, 290);
            this.do登录.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.do登录.Name = "do登录";
            this.do登录.Size = new System.Drawing.Size(100, 26);
            this.do登录.TabIndex = 2;
            this.do登录.Text = "登录";
            this.do登录.UseVisualStyleBackColor = true;
            // 
            // do注销
            // 
            this.do注销.Location = new System.Drawing.Point(281, 290);
            this.do注销.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.do注销.Name = "do注销";
            this.do注销.Size = new System.Drawing.Size(100, 26);
            this.do注销.TabIndex = 3;
            this.do注销.Text = "注销";
            this.do注销.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入文本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "APPID";
            this.toolTip1.SetToolTip(this.label2, "从讯飞申请,体验版30天有效");
            // 
            // inAPPID
            // 
            this.inAPPID.Location = new System.Drawing.Point(29, 54);
            this.inAPPID.Name = "inAPPID";
            this.inAPPID.Size = new System.Drawing.Size(100, 23);
            this.inAPPID.TabIndex = 6;
            // 
            // F语音合成
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(475, 346);
            this.Controls.Add(this.inAPPID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.do注销);
            this.Controls.Add(this.do登录);
            this.Controls.Add(this.do合成);
            this.Controls.Add(this.in文本);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F语音合成";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "语音合成测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox in文本;
        private System.Windows.Forms.Button do合成;
        private System.Windows.Forms.Button do登录;
        private System.Windows.Forms.Button do注销;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inAPPID;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

