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
    public partial class Dashboard : Adam
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private MainModel db = new MainModel();
        private void Dashboard_Load(object sender, EventArgs e)
        {
            new Thread(() => LoadZones()).Start();
        }
            
        public void LoadZones()
        {
            var zones = new Zones(ref db).DropDown();
            this.Invoke(new MethodInvoker(() =>
            {

            }));
        }
    }
}
