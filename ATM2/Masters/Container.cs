﻿using System;
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
    public partial class Container :Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {

        }

        private void داشبوردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1 { MdiParent = this }.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void راهاندازیمجددبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}