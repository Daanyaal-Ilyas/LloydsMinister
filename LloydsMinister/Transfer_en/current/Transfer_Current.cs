﻿using LloydsMinister.Transfer_en;
using System;
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
    public partial class Transfer_Current : Form
    {
        public Transfer_Current()
        {
            InitializeComponent();
        }

        private void Transfer_Current_Load(object sender, EventArgs e)
        {
            btnTransferBack.Cursor = Cursors.Hand;
            btnlongterm.Cursor = Cursors.Hand;
            btnsimple.Cursor = Cursors.Hand;
            btnextra1.Cursor = Cursors.Hand;
            btnextra2.Cursor = Cursors.Hand;
            btnextra3.Cursor = Cursors.Hand;
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferMenu menu = new TransferMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnlongterm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfercurrent_longterm menu = new Transfercurrent_longterm();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnsimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfercurrent_simple menu = new Transfercurrent_simple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
