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
        [STAThread]
        static void Main()
        {

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
