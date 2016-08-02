namespace 语音离线识别演示
{
    partial class F主窗口
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F主窗口));
            this.f识别1 = new F识别();
            this.SuspendLayout();
            // 
            // f识别1
            // 
            this.f识别1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f识别1.Location = new System.Drawing.Point(0, 0);
            this.f识别1.Name = "f识别1";
            this.f识别1.Size = new System.Drawing.Size(837, 529);
            this.f识别1.TabIndex = 0;
            // 
            // F主窗口
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(837, 529);
            this.Controls.Add(this.f识别1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F主窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "语音识别";
            this.ResumeLayout(false);

        }

        #endregion

        private F识别 f识别1;

    }
}