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
    public partial class DepositMenu : Form
    {
        public DepositMenu()
        {
            InitializeComponent();
        }

        private void lbDepMenuCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit_Current current = new Deposit_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void lbDepMenuLongTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit_LongTerm longTerm = new Deposit_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void lbDepMenuSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit_SimpleDeposit simpleDeposit = new Deposit_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void lbDepMenuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void DepositMenu_Load(object sender, EventArgs e)
        {
            lbDepMenuCurrent.Cursor  = Cursors.Hand;
            lbDepMenuLongTerm.Cursor = Cursors.Hand;
            lbDepMenuSimple.Cursor   = Cursors.Hand;
            lbDepMenuBack.Cursor     = Cursors.Hand;
        }
    }
}
