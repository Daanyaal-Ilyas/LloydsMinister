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
    public partial class WithdrawMenu : Form
    {
        public WithdrawMenu()
        {
            InitializeComponent();
        }

        private void WithdrawMenu_Load(object sender, EventArgs e)
        {
            btnWithdrawCurrent.Cursor  = Cursors.Hand;
            btnWithdrawLongTerm.Cursor = Cursors.Hand;
            btnWithdrawSimple.Cursor   = Cursors.Hand;
            btnWithdrawBack.Cursor     = Cursors.Hand;
        }

        private void btnWithdrawCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_Current current = new Withdraw_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnWithdrawLongTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_LongTerm longTerm = new Withdraw_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void btnWithdrawSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_SimpleDeposit simpleDeposit = new Withdraw_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void btnWithdrawBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
