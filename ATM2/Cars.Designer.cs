namespace ATM2
{
    partial class Cars
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
            this.components = new System.ComponentModel.Container();
            this.rexaLabel1 = new MarathonSkills2015.Components.RexaLabel(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_Operations.SuspendLayout();
            this.panel_Fields.SuspendLayout();
            this.controlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Operations
            // 
            this.panel_Operations.Location = new System.Drawing.Point(10, 447);
            this.panel_Operations.Size = new System.Drawing.Size(898, 24);
            // 
            // rexaButton3
            // 
            this.rexaButton3.Location = new System.Drawing.Point(673, 0);
            // 
            // rexaButton2
            // 
            this.rexaButton2.Location = new System.Drawing.Point(748, 0);
            // 
            // rexaButton1
            // 
            this.rexaButton1.Location = new System.Drawing.Point(823, 0);
            // 
            // panel_Fields
            // 
            this.panel_Fields.Controls.Add(this.textBox1);
            this.panel_Fields.Controls.Add(this.rexaLabel1);
            this.panel_Fields.Location = new System.Drawing.Point(671, 41);
            this.panel_Fields.Size = new System.Drawing.Size(237, 406);
            this.panel_Fields.Controls.SetChildIndex(this.rexaLabel1, 0);
            this.panel_Fields.Controls.SetChildIndex(this.textBox1, 0);
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(10, 10);
            this.controlBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.controlBox.Size = new System.Drawing.Size(898, 31);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(858, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Close.Size = new System.Drawing.Size(40, 31);
            // 
            // btn_Back
            // 
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Back.Size = new System.Drawing.Size(40, 31);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Location = new System.Drawing.Point(778, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Minimize.Size = new System.Drawing.Size(40, 31);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Location = new System.Drawing.Point(818, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Maximize.Size = new System.Drawing.Size(40, 31);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(40, 0);
            this.lbl_Title.Size = new System.Drawing.Size(738, 31);
            this.lbl_Title.Text = "Crud";
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rexaLabel1.Location = new System.Drawing.Point(0, 42);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(237, 13);
            this.rexaLabel1.TabIndex = 2;
            this.rexaLabel1.Text = "مدل";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 481);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Cars";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "خودرو ها";
            this.Load += new System.EventHandler(this.Cars_Load);
            this.panel_Operations.ResumeLayout(false);
            this.panel_Fields.ResumeLayout(false);
            this.panel_Fields.PerformLayout();
            this.controlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MarathonSkills2015.Components.RexaLabel rexaLabel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}