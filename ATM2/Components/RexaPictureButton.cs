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
    public partial class RexaPictureButton : PictureBox
    {
        public RexaPictureButton()
        {
            InitializeComponent();
        }

        public RexaPictureButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Cursor = Cursors.Hand;
            MouseHover += delegate
            {
                BorderStyle = BorderStyle.Fixed3D;
            };
            MouseLeave += delegate
            {
                BorderStyle = BorderStyle.None;
            };
        }
    }
}
