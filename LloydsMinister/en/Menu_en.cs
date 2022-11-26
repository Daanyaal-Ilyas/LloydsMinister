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
    public partial class Menu_en : Form
    {
        public Menu_en()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnMenuBalance.Cursor   = Cursors.Hand;
            btnMenuWithdraw.Cursor  = Cursors.Hand;
            btnMenuStatement.Cursor = Cursors.Hand;
            btnMenuDeposit.Cursor   = Cursors.Hand;
            btnMenuTransfer.Cursor  = Cursors.Hand;
            btnMenuExit.Cursor      = Cursors.Hand;
        }

        private void btnMenuBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceMenu balance = new BalanceMenu();
            balance.ShowDialog();
            balance.Closed += (s, args) => this.Close();
        }

        private void btnMenuWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawMenu withdraw = new WithdrawMenu();
            withdraw.ShowDialog();
            withdraw.Closed += (s, args) => this.Close();
        }

        private void btnMenuStatement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatementMenu statement = new ViewStatementMenu();
            statement.ShowDialog();
            statement.Closed += (s, args) => this.Close();
        }

        private void btnMenuDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositMenu deposit = new DepositMenu();
            deposit.ShowDialog();
            deposit.Closed += (s, args) => this.Close();
        }

        private void btnMenuTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferMenu transfer = new TransferMenu();
            transfer.ShowDialog();
            transfer.Closed += (s, args) => this.Close();
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //useless code

        private void lbMenuBalance_Click(object sender, EventArgs e)
        {

        }

        private void lbMenuWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void lbMenuStatement_Click(object sender, EventArgs e)
        {

        }

        private void lbMenuDeposit_Click(object sender, EventArgs e)
        {

        }

        private void lbMenuTransfer_Click(object sender, EventArgs e)
        {

        }

        private void lbMenuExit_Click(object sender, EventArgs e)
        {

        }
        private void menuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
