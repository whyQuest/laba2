﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void спадкуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void наслідуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InheritanceWindow = new Form2();
            InheritanceWindow.Show();
        }
    }
}
