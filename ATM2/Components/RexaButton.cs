

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MarathonSkills2015.Components
{
    public partial class RexaButton : Button
    {
        public Color UserDefinedBackColor { get; set; }
        public Color UserDefinedForeColor { get; set; }



        protected override void InitLayout()
        {
            base.InitLayout();

            UserDefinedBackColor = BackColor;
            UserDefinedForeColor = ForeColor;

        }

        public RexaButton()
        {
            InitializeComponent();
            Timer t = new Timer
            {
                Interval = 50
            };

            t.Tick += delegate
            {
                ForeColor = Color.FromArgb(255, 255, 255);
                int r, g, b;

                r = BackColor.R;
                g = BackColor.G;
                b = BackColor.B;


                r -= 25;
                g -= 25;
                b -= 25;

                if (r < 0)
                    r = 0;
                if (b < 0)
                    b = 0;
                if (g < 0)
                    g = 0;

                BackColor = Color.FromArgb(r, g, b);


                if (r + g + b == 0)
                    t.Stop();


            };


            MouseEnter += delegate
            {
                t.Enabled = true;
            };
            MouseLeave += delegate
            {
                ForeColor = UserDefinedForeColor;
                BackColor = UserDefinedBackColor;
                t.Enabled = false;
            };
        }

        public RexaButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();


        }
    }
}
