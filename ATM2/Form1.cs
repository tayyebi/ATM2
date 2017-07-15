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
    public partial class Form1 : Adam
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread loadStats = new Thread(() => LoadStats());
            loadStats.Start();
        }


        public void LoadStats()
        {
            RexaDataGridView rDgV =
                new RexaDataGridView();
            rDgV.Dock = DockStyle.Top;
            //using (var db = new MainModel())
            //{
            var db = new MainModel();
            rDgV.DataSource = new Transactions(ref db).LastActivity();
            //}
            this.Invoke(new MethodInvoker(() =>
            {
                groupBox_Status.Controls.Add(rDgV);
            }));
        }

    }
}
