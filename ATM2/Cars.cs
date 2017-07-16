using ATM2.Masters;
using ATM2.Models;
using System;

namespace ATM2
{
    public partial class Cars : Crud
    {


        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            var db = new MainModel();
            rexaDataGridView_Main.DataSource
                = new ModelViews.Cars(ref db).Select();
        }
    }
}
