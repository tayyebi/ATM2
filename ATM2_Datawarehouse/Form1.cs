using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM2_Datawarehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> AtmCodes = new List<string>();
            var theReader = new SQL().Read("Select Code from ATM");
            while (theReader.Read())
            {
                AtmCodes.Add(theReader["Code"].ToString());
            }


            Parallel.For(0, AtmCodes.Count - 1, i =>
             {
                 try
                 {


                     //foreach (var item in AtmCodes)
                     //{
                     //    try
                     //{
                     new SQL().Execute("EXEC ('select Package.Id ,  Package.[Count], CASE WHEN [Transaction].Way = ''O'' THEN (-1) * Package.[Value]  ELSE Package.[Value] END as [Value] into ATM_" + AtmCodes[i]+" from Package join [Transaction] on Package.TransactionId = [Transaction].Id where [Transaction].AtmId = ''" + AtmCodes[i] + "'' and [Transaction].[Successful] = 1')");
            //"IF EXISTS  (select * from " + item + ") DROP TABLE " + item

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(item);
            //}

            //}



        }
                catch (Exception exx ){

                    string a = exx.Message;

    }
});


        }
    }
}
