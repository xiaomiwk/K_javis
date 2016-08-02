namespace 语音在线服务演示
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.f识别MIC1 = new F识别();
            this.out合成 = new System.Windows.Forms.TabPage();
            this.f合成1 = new F合成();
            this.out听写 = new System.Windows.Forms.TabPage();
            this.f听写1 = new F听写();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.out合成.SuspendLayout();
            this.out听写.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.out合成);
            this.tabControl1.Controls.Add(this.out听写);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 529);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.f识别MIC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "识别";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // f识别MIC1
            // 
            this.f识别MIC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f识别MIC1.Location = new System.Drawing.Point(3, 3);
            this.f识别MIC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f识别MIC1.Name = "f识别MIC1";
            this.f识别MIC1.Size = new System.Drawing.Size(823, 490);
            this.f识别MIC1.TabIndex = 0;
            // 
            // out合成
            // 
            this.out合成.Controls.Add(this.f合成1);
            this.out合成.Location = new System.Drawing.Point(4, 29);
            this.out合成.Name = "out合成";
            this.out合成.Padding = new System.Windows.Forms.Padding(3);
            this.out合成.Size = new System.Drawing.Size(829, 496);
            this.out合成.TabIndex = 2;
            this.out合成.Text = "合成";
            this.out合成.UseVisualStyleBackColor = true;
            // 
            // f合成1
            // 
            this.f合成1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f合成1.Location = new System.Drawing.Point(3, 3);
            this.f合成1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f合成1.Name = "f合成1";
            this.f合成1.Size = new System.Drawing.Size(823, 490);
            this.f合成1.TabIndex = 0;
            // 
            // out听写
            // 
            this.out听写.Controls.Add(this.f听写1);
            this.out听写.Location = new System.Drawing.Point(4, 29);
            this.out听写.Name = "out听写";
            this.out听写.Padding = new System.Windows.Forms.Padding(3);
            this.out听写.Size = new System.Drawing.Size(829, 496);
            this.out听写.TabIndex = 3;
            this.out听写.Text = "听写";
            this.out听写.UseVisualStyleBackColor = true;
            // 
            // f听写1
            // 
            this.f听写1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f听写1.Location = new System.Drawing.Point(3, 3);
            this.f听写1.Name = "f听写1";
            this.f听写1.Size = new System.Drawing.Size(823, 490);
            this.f听写1.TabIndex = 0;
            // 
            // F主窗口
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(837, 529);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F主窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "语音在线合成&识别&听写";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.out合成.ResumeLayout(false);
            this.out听写.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private F识别 f识别MIC1;
        private System.Windows.Forms.TabPage out合成;
        private F合成 f合成1;
        private System.Windows.Forms.TabPage out听写;
        private F听写 f听写1;
    }
}