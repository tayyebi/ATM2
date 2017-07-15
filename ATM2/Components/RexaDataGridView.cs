using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM2.Components
{
    public partial class RexaDataGridView : DataGridView
    {
        public RexaDataGridView()
        {
            InitializeComponent();
        }

        public RexaDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
