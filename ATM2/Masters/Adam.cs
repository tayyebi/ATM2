using MarathonSkills2015.Components;
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
    public partial class Adam : Form
    {

        public Panel controlBox = new Panel();
        public RexaButton btn_Close = new RexaButton { BackColor = Color.FromArgb(0, 144, 62) };
        public RexaButton btn_Back = new RexaButton { BackColor = Color.FromArgb(0, 144, 62) };
        public RexaButton btn_Minimize = new RexaButton { BackColor = Color.FromArgb(0, 144, 62) };
        public RexaButton btn_Maximize = new RexaButton { BackColor = Color.FromArgb(0, 144, 62) };
        public RexaLabel lbl_Title = new RexaLabel { BackColor = Color.FromArgb(0, 144, 62) };



        public Adam()
        {
            StartPosition = FormStartPosition.CenterScreen;
            //RightToLeft = RightToLeft.Yes;
            //RightToLeftLayout = true;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Color.White;
            Font = new Font("Arial", 10, FontStyle.Regular);

            InitializeComponent();


            btn_Close.Text = "بستن";
            btn_Close.Dock = DockStyle.Right;
            btn_Close.Click += delegate
            {
                Close();
            };

            btn_Back.Text = "بازگشت";
            btn_Back.Dock = DockStyle.Left;
            btn_Back.Click += delegate
            {
                Close();
            };

            btn_Minimize.Text = "پائین";
            btn_Minimize.Dock = DockStyle.Right;
            btn_Minimize.Click += delegate
            {
                this.WindowState = FormWindowState.Minimized;
            };

            btn_Maximize.Text = "تمام";
            btn_Maximize.Dock = DockStyle.Right;
            btn_Maximize.Click += delegate
            {
                if (WindowState == FormWindowState.Maximized)
                    WindowState = FormWindowState.Normal;
                else
                    WindowState = FormWindowState.Maximized;
            };

            lbl_Title.ForeColor = Color.White;
            lbl_Title.Dock = DockStyle.Fill;

            Point mouse_down_position = new Point(0, 0);
            Point mouse_down_window_location = new Point(0, 0);
            bool is_mouse_down = false;


            lbl_Title.MouseUp += delegate
            {
                is_mouse_down = false;
            };
            lbl_Title.MouseDown += delegate
            {
                is_mouse_down = true;
                mouse_down_position = Cursor.Position;
                mouse_down_window_location = this.Location;
            };
            lbl_Title.MouseMove += delegate
            {
                if (is_mouse_down)
                {
                    int d_x = Cursor.Position.X - mouse_down_position.X;
                    int d_y = Cursor.Position.Y - mouse_down_position.Y;

                    int the_x = mouse_down_window_location.X + d_x;
                    int the_y = mouse_down_window_location.Y + d_y;

                    Location = new Point(the_x, the_y);
                }
            };


            btn_Back.Font =
            btn_Minimize.Font =
            btn_Maximize.Font =
            btn_Close.Font = new Font(this.Font.Name, 7, this.Font.Style);

            controlBox.Controls.Add(lbl_Title);
            controlBox.Controls.Add(btn_Back);
            controlBox.Controls.Add(btn_Minimize);
            controlBox.Controls.Add(btn_Maximize);
            controlBox.Controls.Add(btn_Close);

            controlBox.Dock = DockStyle.Top;
            controlBox.BackColor = Color.FromArgb(0, 144, 62);

            Controls.Add(controlBox);


        }

        private void Adam_Load(object sender, EventArgs e)
        {

            controlBox.Height = 25;
            lbl_Title.Text = Text;


            btn_Back.Width =
            btn_Minimize.Width =
            btn_Maximize.Width =
            btn_Close.Width =
            40;

            Padding = new Padding(10);
        }
    }
}
