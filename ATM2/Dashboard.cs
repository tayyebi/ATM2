using ATM2.Components;
using ATM2.Masters;
using ATM2.Models;
using ATM2.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM2
{
    public partial class Dashboard : Adam
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            Thread atmSummary = new Thread(() => AtmSummary());
            atmSummary.Start();
        }

        public void AtmSummary()
        {
            var db = new MainModel();
            RexaDataGridView rGV = new RexaDataGridView { Dock = DockStyle.Fill, DataSource = new ATMs(ref db).Abstarct() };

            this.Invoke(new MethodInvoker(() =>
            {
                Controls.Add(rGV);
            }));
        }

    }
}
