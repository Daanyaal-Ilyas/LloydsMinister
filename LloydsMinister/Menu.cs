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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lbMenuBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceMenu balance = new BalanceMenu();
            balance.ShowDialog();
            balance.Closed += (s, args) => this.Close();
        }

        private void lbMenuWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawMenu withdraw = new WithdrawMenu();
            withdraw.ShowDialog();
            withdraw.Closed += (s, args) => this.Close();
        }

        private void lbMenuStatement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatementMenu statement = new ViewStatementMenu();
            statement.ShowDialog();
            statement.Closed += (s, args) => this.Close();
        }

        private void lbMenuDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositMenu deposit = new DepositMenu();
            deposit.ShowDialog();
            deposit.Closed += (s, args) => this.Close();
        }

        private void lbMenuTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferMenu transfer = new TransferMenu();
            transfer.ShowDialog();
            transfer.Closed += (s, args) => this.Close();
        }

        private void lbMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbMenuBalance.Cursor   = Cursors.Hand;
            lbMenuWithdraw.Cursor  = Cursors.Hand;
            lbMenuStatement.Cursor = Cursors.Hand;
            lbMenuDeposit.Cursor   = Cursors.Hand;
            lbMenuTransfer.Cursor  = Cursors.Hand;
            lbMenuExit.Cursor      = Cursors.Hand;
        }
    }
}
