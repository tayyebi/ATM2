namespace ATM2
{
    partial class Dashboard
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(12, 12);
            this.controlBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlBox.Size = new System.Drawing.Size(1049, 31);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(1002, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Size = new System.Drawing.Size(47, 31);
            // 
            // btn_Back
            // 
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Back.Size = new System.Drawing.Size(47, 31);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Location = new System.Drawing.Point(908, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Minimize.Size = new System.Drawing.Size(47, 31);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Location = new System.Drawing.Point(955, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Maximize.Size = new System.Drawing.Size(47, 31);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(47, 0);
            this.lbl_Title.Size = new System.Drawing.Size(861, 31);
            this.lbl_Title.Text = "Adam";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 452);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(212, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 452);
            this.listBox2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(412, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 452);
            this.panel1.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.listBox2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.controlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
    }
}