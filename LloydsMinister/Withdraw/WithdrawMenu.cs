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

        private void lbWithMenuCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_Current current = new Withdraw_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void lbWithMenuLongTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_LongTerm longTerm = new Withdraw_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void lbWithMenuSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_SimpleDeposit simpleDeposit = new Withdraw_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void lbWithMenuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void WithdrawMenu_Load(object sender, EventArgs e)
        {
            lbWithMenuCurrent.Cursor = Cursors.Hand;
            lbWithMenuLongTerm.Cursor = Cursors.Hand;
            lbWithMenuSimple.Cursor = Cursors.Hand;
            lbWithMenuBack.Cursor = Cursors.Hand;
        }
    }
}
