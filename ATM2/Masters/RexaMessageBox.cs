using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM2.Masters
{
    public partial class RexaMessageBox : Adam
    {
        public RexaMessageBox(string Message)
        {
            InitializeComponent();
            Text = Message;
        }

        private void RexaMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
