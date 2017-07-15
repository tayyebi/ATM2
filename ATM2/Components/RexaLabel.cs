using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonSkills2015.Components
{
    public partial class RexaLabel : Label
    {
        protected override void InitLayout()
        {
            base.InitLayout();

            AutoSize = false;
        }

        public RexaLabel()
        {
            InitializeComponent();
        }

        public RexaLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
