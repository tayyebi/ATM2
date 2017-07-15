namespace ATM2.Masters
{
    partial class Crud
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
            this.panel_Operations = new System.Windows.Forms.Panel();
            this.rexaButton3 = new MarathonSkills2015.Components.RexaButton(this.components);
            this.rexaButton2 = new MarathonSkills2015.Components.RexaButton(this.components);
            this.rexaButton1 = new MarathonSkills2015.Components.RexaButton(this.components);
            this.panel_Fields = new System.Windows.Forms.Panel();
            this.rexaLabel_Id = new MarathonSkills2015.Components.RexaLabel(this.components);
            this.r1 = new MarathonSkills2015.Components.RexaLabel(this.components);
            this.rexaDataGridView_Main = new ATM2.Components.RexaDataGridView(this.components);
            this.انتخاب = new System.Windows.Forms.DataGridViewButtonColumn();
            this.controlBox.SuspendLayout();
            this.panel_Operations.SuspendLayout();
            this.panel_Fields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rexaDataGridView_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(12, 12);
            this.controlBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlBox.Size = new System.Drawing.Size(840, 31);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(793, 0);
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
            this.btn_Minimize.Location = new System.Drawing.Point(699, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Minimize.Size = new System.Drawing.Size(47, 31);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Location = new System.Drawing.Point(746, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Maximize.Size = new System.Drawing.Size(47, 31);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(47, 0);
            this.lbl_Title.Size = new System.Drawing.Size(652, 31);
            this.lbl_Title.Text = "Adam";
            // 
            // panel_Operations
            // 
            this.panel_Operations.BackColor = System.Drawing.Color.Firebrick;
            this.panel_Operations.Controls.Add(this.rexaButton3);
            this.panel_Operations.Controls.Add(this.rexaButton2);
            this.panel_Operations.Controls.Add(this.rexaButton1);
            this.panel_Operations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Operations.Location = new System.Drawing.Point(12, 486);
            this.panel_Operations.Name = "panel_Operations";
            this.panel_Operations.Size = new System.Drawing.Size(840, 24);
            this.panel_Operations.TabIndex = 1;
            // 
            // rexaButton3
            // 
            this.rexaButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.rexaButton3.Location = new System.Drawing.Point(615, 0);
            this.rexaButton3.Name = "rexaButton3";
            this.rexaButton3.Size = new System.Drawing.Size(75, 24);
            this.rexaButton3.TabIndex = 2;
            this.rexaButton3.Text = "حذف";
            this.rexaButton3.UserDefinedBackColor = System.Drawing.Color.Firebrick;
            this.rexaButton3.UserDefinedForeColor = System.Drawing.SystemColors.ControlText;
            this.rexaButton3.UseVisualStyleBackColor = true;
            // 
            // rexaButton2
            // 
            this.rexaButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.rexaButton2.Location = new System.Drawing.Point(690, 0);
            this.rexaButton2.Name = "rexaButton2";
            this.rexaButton2.Size = new System.Drawing.Size(75, 24);
            this.rexaButton2.TabIndex = 1;
            this.rexaButton2.Text = "ویرایش";
            this.rexaButton2.UserDefinedBackColor = System.Drawing.Color.Firebrick;
            this.rexaButton2.UserDefinedForeColor = System.Drawing.SystemColors.ControlText;
            this.rexaButton2.UseVisualStyleBackColor = true;
            // 
            // rexaButton1
            // 
            this.rexaButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rexaButton1.Location = new System.Drawing.Point(765, 0);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(75, 24);
            this.rexaButton1.TabIndex = 0;
            this.rexaButton1.Text = "جدید";
            this.rexaButton1.UserDefinedBackColor = System.Drawing.Color.Firebrick;
            this.rexaButton1.UserDefinedForeColor = System.Drawing.SystemColors.ControlText;
            this.rexaButton1.UseVisualStyleBackColor = true;
            // 
            // panel_Fields
            // 
            this.panel_Fields.BackColor = System.Drawing.Color.Firebrick;
            this.panel_Fields.Controls.Add(this.rexaLabel_Id);
            this.panel_Fields.Controls.Add(this.r1);
            this.panel_Fields.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Fields.ForeColor = System.Drawing.Color.White;
            this.panel_Fields.Location = new System.Drawing.Point(615, 43);
            this.panel_Fields.Margin = new System.Windows.Forms.Padding(10);
            this.panel_Fields.Name = "panel_Fields";
            this.panel_Fields.Size = new System.Drawing.Size(237, 443);
            this.panel_Fields.TabIndex = 2;
            // 
            // rexaLabel_Id
            // 
            this.rexaLabel_Id.Dock = System.Windows.Forms.DockStyle.Top;
            this.rexaLabel_Id.Location = new System.Drawing.Point(0, 21);
            this.rexaLabel_Id.Name = "rexaLabel_Id";
            this.rexaLabel_Id.Size = new System.Drawing.Size(237, 21);
            this.rexaLabel_Id.TabIndex = 1;
            this.rexaLabel_Id.Text = "[هیچ]";
            this.rexaLabel_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r1
            // 
            this.r1.Dock = System.Windows.Forms.DockStyle.Top;
            this.r1.Location = new System.Drawing.Point(0, 0);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(237, 21);
            this.r1.TabIndex = 0;
            this.r1.Text = "شناسه";
            this.r1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaDataGridView_Main
            // 
            this.rexaDataGridView_Main.AllowUserToAddRows = false;
            this.rexaDataGridView_Main.AllowUserToDeleteRows = false;
            this.rexaDataGridView_Main.AllowUserToOrderColumns = true;
            this.rexaDataGridView_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rexaDataGridView_Main.BackgroundColor = System.Drawing.Color.White;
            this.rexaDataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rexaDataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.انتخاب});
            this.rexaDataGridView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rexaDataGridView_Main.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rexaDataGridView_Main.GridColor = System.Drawing.Color.Black;
            this.rexaDataGridView_Main.Location = new System.Drawing.Point(12, 43);
            this.rexaDataGridView_Main.MultiSelect = false;
            this.rexaDataGridView_Main.Name = "rexaDataGridView_Main";
            this.rexaDataGridView_Main.ReadOnly = true;
            this.rexaDataGridView_Main.Size = new System.Drawing.Size(603, 443);
            this.rexaDataGridView_Main.TabIndex = 3;
            this.rexaDataGridView_Main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rexaDataGridView_Main_Select);
            // 
            // انتخاب
            // 
            this.انتخاب.HeaderText = "";
            this.انتخاب.Name = "انتخاب";
            this.انتخاب.ReadOnly = true;
            this.انتخاب.Text = "انتخاب";
            this.انتخاب.ToolTipText = "برای انتخاب کلیک کنید";
            this.انتخاب.UseColumnTextForButtonValue = true;
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 522);
            this.Controls.Add(this.rexaDataGridView_Main);
            this.Controls.Add(this.panel_Fields);
            this.Controls.Add(this.panel_Operations);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Crud";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Crud";
            this.Load += new System.EventHandler(this.Crud_Load);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.panel_Operations, 0);
            this.Controls.SetChildIndex(this.panel_Fields, 0);
            this.Controls.SetChildIndex(this.rexaDataGridView_Main, 0);
            this.controlBox.ResumeLayout(false);
            this.panel_Operations.ResumeLayout(false);
            this.panel_Fields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rexaDataGridView_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_Operations;
        public MarathonSkills2015.Components.RexaButton rexaButton3;
        public MarathonSkills2015.Components.RexaButton rexaButton2;
        public MarathonSkills2015.Components.RexaButton rexaButton1;
        public System.Windows.Forms.Panel panel_Fields;
        public Components.RexaDataGridView rexaDataGridView_Main;
        private MarathonSkills2015.Components.RexaLabel rexaLabel_Id;
        private MarathonSkills2015.Components.RexaLabel r1;
        private System.Windows.Forms.DataGridViewButtonColumn انتخاب;
    }
}