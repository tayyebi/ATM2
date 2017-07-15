namespace ATM2.Masters
{
    partial class RexaMessageBox
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
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlBox.Size = new System.Drawing.Size(743, 205);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(696, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Size = new System.Drawing.Size(47, 205);
            this.btn_Close.Text = "OK";
            // 
            // btn_Back
            // 
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Back.Size = new System.Drawing.Size(47, 205);
            this.btn_Back.Visible = false;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Location = new System.Drawing.Point(602, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Minimize.Size = new System.Drawing.Size(47, 205);
            this.btn_Minimize.Visible = false;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Location = new System.Drawing.Point(649, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Maximize.Size = new System.Drawing.Size(47, 205);
            this.btn_Maximize.Visible = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(47, 0);
            this.lbl_Title.Size = new System.Drawing.Size(555, 205);
            this.lbl_Title.Text = "Adam";
            // 
            // RexaMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 205);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "RexaMessageBox";
            this.Text = "RexaMessageBox";
            this.Load += new System.EventHandler(this.RexaMessageBox_Load);
            this.controlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}