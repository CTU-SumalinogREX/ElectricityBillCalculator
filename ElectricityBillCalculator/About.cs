﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityBillCalculator
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void contactLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com"); //Change to compose email
        }
    }
}
