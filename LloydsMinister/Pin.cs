﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class Pin : Form
    {
        public Pin()
        {
            InitializeComponent();
        }

        private void Pin_Load(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetValuepin = enterPin1.Text;
            this.Hide();
            Menu m2 = new Menu();
            m2.ShowDialog();
            m2.Closed += (s, args) => this.Close();
        }
        public static string SetValuepin = "";
    }
}
