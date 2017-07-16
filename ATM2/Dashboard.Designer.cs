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
            this.controlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(10, 10);
            this.controlBox.Margin = new System.Windows.Forms.Padding(4);
            this.controlBox.Size = new System.Drawing.Size(866, 35);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(754, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Size = new System.Drawing.Size(112, 35);
            // 
            // btn_Back
            // 
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Size = new System.Drawing.Size(112, 35);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Location = new System.Drawing.Point(530, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimize.Size = new System.Drawing.Size(112, 35);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Location = new System.Drawing.Point(642, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Maximize.Size = new System.Drawing.Size(112, 35);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(112, 0);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Size = new System.Drawing.Size(418, 35);
            this.lbl_Title.Text = "Adam";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 516);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "داشبورد";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

