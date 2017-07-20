namespace ATM2.Masters
{
    partial class Container
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.گزارشهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کارکردماهانهیمنطقهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.داشبوردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشهاToolStripMenuItem,
            this.داشبوردToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // گزارشهاToolStripMenuItem
            // 
            this.گزارشهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کارکردماهانهیمنطقهToolStripMenuItem});
            this.گزارشهاToolStripMenuItem.Name = "گزارشهاToolStripMenuItem";
            this.گزارشهاToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.گزارشهاToolStripMenuItem.Text = "گزارش ها";
            // 
            // کارکردماهانهیمنطقهToolStripMenuItem
            // 
            this.کارکردماهانهیمنطقهToolStripMenuItem.Name = "کارکردماهانهیمنطقهToolStripMenuItem";
            this.کارکردماهانهیمنطقهToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.کارکردماهانهیمنطقهToolStripMenuItem.Text = "کارکرد ماهانه ی منطقه";
            this.کارکردماهانهیمنطقهToolStripMenuItem.Click += new System.EventHandler(this.کارکردماهانهیمنطقهToolStripMenuItem_Click);
            // 
            // داشبوردToolStripMenuItem
            // 
            this.داشبوردToolStripMenuItem.Name = "داشبوردToolStripMenuItem";
            this.داشبوردToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.داشبوردToolStripMenuItem.Text = "داشبورد";
            this.داشبوردToolStripMenuItem.Click += new System.EventHandler(this.داشبوردToolStripMenuItem_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Container";
            this.Text = "سامانه ارتباط چند عاملی خودپردازها";
            this.Load += new System.EventHandler(this.Container_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem گزارشهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کارکردماهانهیمنطقهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem داشبوردToolStripMenuItem;
    }
}