using ATM2.Components;
using ATM2.Masters;
using ATM2.Models;
using ATM2.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM2
{
    public partial class Report1 : Adam
    {

        public Report1()
        {
            InitializeComponent();
        }
        private void Report1_Load(object sender, EventArgs e)
        {
            LoadCalendar();
            LoadZones();
        }




        public void LoadCalendar()
        {
            var db = new MainModel();

            var years = new ModelViews.CalendarDimensions(ref db).Years();
            var monthes = new ModelViews.CalendarDimensions(ref db).Monthes(2000);

            this.Invoke(new MethodInvoker(() =>
            {
                comboBox1.DataSource = years;
                comboBox1.DisplayMember = "Year";

                comboBox2.DataSource = monthes;
                comboBox2.DisplayMember = "Month";
            }));
        }
        public void LoadZones()
        {
            var db = new MainModel();

            var zones =
                new ModelViews.Zones(ref db).DropDown();

            this.Invoke(new MethodInvoker(() =>
            {
                comboBox3.DataSource = zones;
                comboBox3.DisplayMember = "Name";
            }));
        }


        private void rexaButton1_Click(object sender, EventArgs e)
        {
            //var db = new MainModel();
            //RexaDataGridView rGV = new RexaDataGridView
            //{
            //    Dock = DockStyle.Fill,
            //    DataSource = new Transactions(ref db).Abstract(((Zone)comboBox3.SelectedItem).Id, (Convert.ToInt32(comboBox1.Text)), (Convert.ToInt32(comboBox2.Text)))
            //};
            //panel2.Controls.Clear();
            //panel2.Controls.Add(rGV);

            var db = new MainModel();
            this.reportViewer1.RefreshReport();
            Report1LayoutBindingSource.DataSource
                = new Transactions(ref db).Abstract(((Zone)comboBox3.SelectedItem).Id, (Convert.ToInt32(comboBox1.Text)), (Convert.ToInt32(comboBox2.Text)));
        }
    }
}