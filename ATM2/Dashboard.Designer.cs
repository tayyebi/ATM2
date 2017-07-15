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
            this.components = new System.ComponentModel.Container();
            this.rexaPictureButton1 = new ATM2.Components.RexaPictureButton(this.components);
            this.rexaPictureButton2 = new ATM2.Components.RexaPictureButton(this.components);
            this.groupBox_Menu = new System.Windows.Forms.GroupBox();
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rexaPictureButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rexaPictureButton2)).BeginInit();
            this.groupBox_Menu.SuspendLayout();
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
            // rexaPictureButton1
            // 
            this.rexaPictureButton1.BackColor = System.Drawing.Color.Transparent;
            this.rexaPictureButton1.BackgroundImage = global::ATM2.Properties.Resources.atm;
            this.rexaPictureButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rexaPictureButton1.Location = new System.Drawing.Point(6, 25);
            this.rexaPictureButton1.Name = "rexaPictureButton1";
            this.rexaPictureButton1.Size = new System.Drawing.Size(160, 109);
            this.rexaPictureButton1.TabIndex = 1;
            this.rexaPictureButton1.TabStop = false;
            // 
            // rexaPictureButton2
            // 
            this.rexaPictureButton2.BackColor = System.Drawing.Color.Transparent;
            this.rexaPictureButton2.BackgroundImage = global::ATM2.Properties.Resources.bank_car;
            this.rexaPictureButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rexaPictureButton2.Location = new System.Drawing.Point(6, 140);
            this.rexaPictureButton2.Name = "rexaPictureButton2";
            this.rexaPictureButton2.Size = new System.Drawing.Size(160, 109);
            this.rexaPictureButton2.TabIndex = 1;
            this.rexaPictureButton2.TabStop = false;
            this.rexaPictureButton2.Click += new System.EventHandler(this.rexaPictureButton2_Click);
            // 
            // groupBox_Menu
            // 
            this.groupBox_Menu.Controls.Add(this.rexaPictureButton1);
            this.groupBox_Menu.Controls.Add(this.rexaPictureButton2);
            this.groupBox_Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_Menu.Location = new System.Drawing.Point(702, 45);
            this.groupBox_Menu.Name = "groupBox_Menu";
            this.groupBox_Menu.Size = new System.Drawing.Size(174, 461);
            this.groupBox_Menu.TabIndex = 2;
            this.groupBox_Menu.TabStop = false;
            this.groupBox_Menu.Text = "منو";
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Status.Location = new System.Drawing.Point(10, 45);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Size = new System.Drawing.Size(692, 461);
            this.groupBox_Status.TabIndex = 3;
            this.groupBox_Status.TabStop = false;
            this.groupBox_Status.Text = "وضعیت";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 516);
            this.Controls.Add(this.groupBox_Status);
            this.Controls.Add(this.groupBox_Menu);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "داشبورد";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.groupBox_Menu, 0);
            this.Controls.SetChildIndex(this.groupBox_Status, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rexaPictureButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rexaPictureButton2)).EndInit();
            this.groupBox_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RexaPictureButton rexaPictureButton1;
        private Components.RexaPictureButton rexaPictureButton2;
        private System.Windows.Forms.GroupBox groupBox_Menu;
        private System.Windows.Forms.GroupBox groupBox_Status;
    }
}

