namespace 贾维斯
{
    partial class F调试窗口
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F调试窗口));
            this.u窗口背景1 = new Utility.WindowsForm.U窗口背景();
            this.out信息 = new System.Windows.Forms.TextBox();
            this.u窗体头1 = new Utility.WindowsForm.U窗体头();
            this.label1 = new System.Windows.Forms.Label();
            this.u窗体脚1 = new Utility.WindowsForm.U窗体脚();
            this.u窗口背景1.SuspendLayout();
            this.u窗体头1.SuspendLayout();
            this.SuspendLayout();
            // 
            // u窗口背景1
            // 
            this.u窗口背景1.Controls.Add(this.out信息);
            this.u窗口背景1.Controls.Add(this.u窗体头1);
            this.u窗口背景1.Controls.Add(this.u窗体脚1);
            this.u窗口背景1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u窗口背景1.Location = new System.Drawing.Point(0, 0);
            this.u窗口背景1.Margin = new System.Windows.Forms.Padding(0);
            this.u窗口背景1.Name = "u窗口背景1";
            this.u窗口背景1.Size = new System.Drawing.Size(1000, 180);
            this.u窗口背景1.TabIndex = 0;
            this.u窗口背景1.边框颜色 = System.Drawing.Color.Gainsboro;
            this.u窗口背景1.面板颜色 = System.Drawing.Color.Empty;
            // 
            // out信息
            // 
            this.out信息.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out信息.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.out信息.Location = new System.Drawing.Point(12, 50);
            this.out信息.Multiline = true;
            this.out信息.Name = "out信息";
            this.out信息.Size = new System.Drawing.Size(976, 118);
            this.out信息.TabIndex = 5;
            // 
            // u窗体头1
            // 
            this.u窗体头1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.u窗体头1.BackColor = System.Drawing.Color.White;
            this.u窗体头1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("u窗体头1.BackgroundImage")));
            this.u窗体头1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.u窗体头1.Controls.Add(this.label1);
            this.u窗体头1.Location = new System.Drawing.Point(1, 1);
            this.u窗体头1.Name = "u窗体头1";
            this.u窗体头1.Size = new System.Drawing.Size(998, 32);
            this.u窗体头1.TabIndex = 7;
            this.u窗体头1.显示最大化按钮 = true;
            this.u窗体头1.显示最小化按钮 = true;
            this.u窗体头1.显示设置按钮 = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "调试窗口";
            // 
            // u窗体脚1
            // 
            this.u窗体脚1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.u窗体脚1.BackColor = System.Drawing.Color.White;
            this.u窗体脚1.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.u窗体脚1.Location = new System.Drawing.Point(985, 162);
            this.u窗体脚1.Name = "u窗体脚1";
            this.u窗体脚1.Size = new System.Drawing.Size(14, 17);
            this.u窗体脚1.TabIndex = 6;
            // 
            // F调试窗口
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 180);
            this.Controls.Add(this.u窗口背景1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "F调试窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "调试窗口";
            this.u窗口背景1.ResumeLayout(false);
            this.u窗口背景1.PerformLayout();
            this.u窗体头1.ResumeLayout(false);
            this.u窗体头1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Utility.WindowsForm.U窗口背景 u窗口背景1;
        private System.Windows.Forms.TextBox out信息;
        private Utility.WindowsForm.U窗体脚 u窗体脚1;
        private Utility.WindowsForm.U窗体头 u窗体头1;
        private System.Windows.Forms.Label label1;
    }
}