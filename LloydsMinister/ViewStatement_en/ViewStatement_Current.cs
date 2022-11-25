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
    public partial class ViewStatement_Current : Form
    {
        public ViewStatement_Current()
        {
            InitializeComponent();
        }

        private void ViewStatement_Current_Load(object sender, EventArgs e)
        {
            btnStatBack.Cursor = Cursors.Hand;
        }

        private void btnStatBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatementMenu menu = new ViewStatementMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}