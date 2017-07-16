using ATM2.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // [STAThread]
        static void Main()
        {

            // Data Generate

            //List<int> transactionIds;
            //List<string> atmCodes;
            //List<int> carIds;

            //using (var db = new Models.MainModel())
            //{
            //    transactionIds = db.Transactions.Select(x => x.Id).ToList();
            //    atmCodes = db.ATMs.Select(x => x.Code).ToList();
            //    carIds = db.Cars.Select(x => x.Id).ToList();
            //}
            //Random r = new Random();
            //Parallel.For(0, transactionIds.Count(), j =>
            //{
            //    using (var db = new Models.MainModel())
            //    {
            //        bool atm = Convert.ToBoolean(r.Next(0, 10) > 3);
            //        var this_tran = db.Transactions.Find(transactionIds[j]);
            //        if (this_tran.AtmId == null && this_tran.CarId == null)
            //        {
            //            if (atm)
            //            {
            //                string code = atmCodes[r.Next(0, atmCodes.Count - 1)];
            //                this_tran.AtmId = code;
            //            }
            //            else
            //            {
            //                int id = carIds[r.Next(0, carIds.Count - 1)];
            //                this_tran.CarId = id;
            //            }
            //            /* db.SaveChangesAsync(); */
            //            db.SaveChanges();
            //        }
            //    }
            //});

            Application.ThreadException += (sender, args) => RexaAppException(sender, args.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => RexaAppException(sender, args.ExceptionObject as Exception);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var container = new Container();
            Application.Run(container);
        }
        private static void RexaAppException(object sender, Exception e)
        {
            new RexaMessageBox(e.Message).ShowDialog();
        }
    }
}
