namespace 贾维斯
{
    partial class F主窗口
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F主窗口));
            this.u窗口背景1 = new Utility.WindowsForm.U窗口背景();
            this.uTab1 = new Utility.WindowsForm.UTab();
            this.u窗体头1 = new Utility.WindowsForm.U窗体头();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.out通知栏图标 = new System.Windows.Forms.NotifyIcon(this.components);
            this.out通知栏右键 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.do显示 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.do退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.out系统设置 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.do设置 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.do打开调试窗口 = new System.Windows.Forms.ToolStripMenuItem();
            this.u窗口背景1.SuspendLayout();
            this.u窗体头1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.out通知栏右键.SuspendLayout();
            this.out系统设置.SuspendLayout();
            this.SuspendLayout();
            // 
            // u窗口背景1
            // 
            this.u窗口背景1.Controls.Add(this.uTab1);
            this.u窗口背景1.Controls.Add(this.u窗体头1);
            this.u窗口背景1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u窗口背景1.Location = new System.Drawing.Point(0, 0);
            this.u窗口背景1.Margin = new System.Windows.Forms.Padding(0);
            this.u窗口背景1.Name = "u窗口背景1";
            this.u窗口背景1.Size = new System.Drawing.Size(1000, 650);
            this.u窗口背景1.TabIndex = 0;
            this.u窗口背景1.边框颜色 = System.Drawing.Color.Gainsboro;
            this.u窗口背景1.面板颜色 = System.Drawing.Color.Empty;
            // 
            // uTab1
            // 
            this.uTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uTab1.Location = new System.Drawing.Point(12, 59);
            this.uTab1.Name = "uTab1";
            this.uTab1.Size = new System.Drawing.Size(976, 579);
            this.uTab1.TabIndex = 5;
            this.uTab1.标题宽度 = 120;
            // 
            // u窗体头1
            // 
            this.u窗体头1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.u窗体头1.BackColor = System.Drawing.Color.White;
            this.u窗体头1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("u窗体头1.BackgroundImage")));
            this.u窗体头1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.u窗体头1.Controls.Add(this.pictureBox1);
            this.u窗体头1.Controls.Add(this.label1);
            this.u窗体头1.Location = new System.Drawing.Point(1, 1);
            this.u窗体头1.Name = "u窗体头1";
            this.u窗体头1.Size = new System.Drawing.Size(998, 52);
            this.u窗体头1.TabIndex = 4;
            this.u窗体头1.显示最大化按钮 = true;
            this.u窗体头1.显示最小化按钮 = true;
            this.u窗体头1.显示设置按钮 = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::贾维斯.Properties.Resources.K;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "贾维斯";
            // 
            // out通知栏图标
            // 
            this.out通知栏图标.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.out通知栏图标.BalloonTipText = "贾维斯";
            this.out通知栏图标.ContextMenuStrip = this.out通知栏右键;
            this.out通知栏图标.Icon = ((System.Drawing.Icon)(resources.GetObject("out通知栏图标.Icon")));
            this.out通知栏图标.Text = "贾维斯";
            this.out通知栏图标.Visible = true;
            // 
            // out通知栏右键
            // 
            this.out通知栏右键.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.do显示,
            this.toolStripSeparator1,
            this.do退出});
            this.out通知栏右键.Name = "contextMenuStrip1";
            this.out通知栏右键.Size = new System.Drawing.Size(99, 54);
            // 
            // do显示
            // 
            this.do显示.Name = "do显示";
            this.do显示.Size = new System.Drawing.Size(98, 22);
            this.do显示.Text = "显示";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // do退出
            // 
            this.do退出.Name = "do退出";
            this.do退出.Size = new System.Drawing.Size(98, 22);
            this.do退出.Text = "退出";
            // 
            // out系统设置
            // 
            this.out系统设置.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.do设置,
            this.toolStripSeparator2,
            this.do打开调试窗口});
            this.out系统设置.Name = "out系统设置";
            this.out系统设置.Size = new System.Drawing.Size(147, 54);
            // 
            // do设置
            // 
            this.do设置.Name = "do设置";
            this.do设置.Size = new System.Drawing.Size(146, 22);
            this.do设置.Text = "设置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // do打开调试窗口
            // 
            this.do打开调试窗口.Name = "do打开调试窗口";
            this.do打开调试窗口.Size = new System.Drawing.Size(146, 22);
            this.do打开调试窗口.Text = "打开调试窗口";
            // 
            // F主窗口
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.u窗口背景1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "F主窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贾维斯";
            this.u窗口背景1.ResumeLayout(false);
            this.u窗体头1.ResumeLayout(false);
            this.u窗体头1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.out通知栏右键.ResumeLayout(false);
            this.out系统设置.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Utility.WindowsForm.U窗口背景 u窗口背景1;
        private Utility.WindowsForm.U窗体头 u窗体头1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon out通知栏图标;
        private Utility.WindowsForm.UTab uTab1;
        private System.Windows.Forms.ContextMenuStrip out通知栏右键;
        private System.Windows.Forms.ToolStripMenuItem do显示;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem do退出;
        private System.Windows.Forms.ContextMenuStrip out系统设置;
        private System.Windows.Forms.ToolStripMenuItem do设置;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem do打开调试窗口;
    }
}

