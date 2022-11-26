using LloydsMinister.urdu.Withdraw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.ViewStatement
{
    public partial class Withdrawmenu : Form
    {
        public Withdrawmenu()
        {
            InitializeComponent();
        }

        private void Withdrawmenu_Load(object sender, EventArgs e)
        {
            btnWithdrawBack.Cursor = Cursors.Hand;
            btnWithdrawCurrent.Cursor = Cursors.Hand;
            btnWithdrawExtra.Cursor = Cursors.Hand;
            btnWithdrawSimple.Cursor = Cursors.Hand;
            BalanceExtra2btn.Cursor = Cursors.Hand;
            BalanceExtrabtn.Cursor = Cursors.Hand;
        }

        private void btnWithdrawBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu current = new menu();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnWithdrawSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawSimple current = new WithdrawSimple();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnWithdrawCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawCurrent current = new WithdrawCurrent();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }
    }
}
