namespace ATM2
{
    partial class Report1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rexaButton1 = new MarathonSkills2015.Components.RexaButton(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rexaLabel2 = new MarathonSkills2015.Components.RexaLabel(this.components);
            this.rexaLabel3 = new MarathonSkills2015.Components.RexaLabel(this.components);
            this.rexaLabel1 = new MarathonSkills2015.Components.RexaLabel(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Report1LayoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report1LayoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(12, 12);
            this.controlBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlBox.Size = new System.Drawing.Size(722, 31);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(675, 0);
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
            this.btn_Minimize.Location = new System.Drawing.Point(581, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Minimize.Size = new System.Drawing.Size(47, 31);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Location = new System.Drawing.Point(628, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Maximize.Size = new System.Drawing.Size(47, 31);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(47, 0);
            this.lbl_Title.Size = new System.Drawing.Size(534, 31);
            this.lbl_Title.Text = "Adam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rexaButton1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.rexaLabel2);
            this.panel1.Controls.Add(this.rexaLabel3);
            this.panel1.Controls.Add(this.rexaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 74);
            this.panel1.TabIndex = 1;
            // 
            // rexaButton1
            // 
            this.rexaButton1.Location = new System.Drawing.Point(17, 37);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(75, 23);
            this.rexaButton1.TabIndex = 1;
            this.rexaButton1.Text = "جستجو";
            this.rexaButton1.UserDefinedBackColor = System.Drawing.SystemColors.Control;
            this.rexaButton1.UserDefinedForeColor = System.Drawing.SystemColors.ControlText;
            this.rexaButton1.UseVisualStyleBackColor = true;
            this.rexaButton1.Click += new System.EventHandler(this.rexaButton1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(439, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(17, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(144, 24);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(439, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // rexaLabel2
            // 
            this.rexaLabel2.Location = new System.Drawing.Point(589, 37);
            this.rexaLabel2.Name = "rexaLabel2";
            this.rexaLabel2.Size = new System.Drawing.Size(123, 18);
            this.rexaLabel2.TabIndex = 0;
            this.rexaLabel2.Text = "ماه";
            this.rexaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaLabel3
            // 
            this.rexaLabel3.Location = new System.Drawing.Point(167, 7);
            this.rexaLabel3.Name = "rexaLabel3";
            this.rexaLabel3.Size = new System.Drawing.Size(123, 18);
            this.rexaLabel3.TabIndex = 0;
            this.rexaLabel3.Text = "منطقه";
            this.rexaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.Location = new System.Drawing.Point(589, 7);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(123, 18);
            this.rexaLabel1.TabIndex = 0;
            this.rexaLabel1.Text = "سال";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Report1LayoutBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ATM2.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(722, 191);
            this.reportViewer1.TabIndex = 2;
            // 
            // Report1LayoutBindingSource
            // 
            this.Report1LayoutBindingSource.DataSource = typeof(ATM2.Reports.Report1Layout);
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 320);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Report1";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Report1";
            this.Load += new System.EventHandler(this.Report1_Load);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.controlBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Report1LayoutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private MarathonSkills2015.Components.RexaLabel rexaLabel2;
        private MarathonSkills2015.Components.RexaLabel rexaLabel3;
        private MarathonSkills2015.Components.RexaLabel rexaLabel1;
        private MarathonSkills2015.Components.RexaButton rexaButton1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Report1LayoutBindingSource;
    }
}