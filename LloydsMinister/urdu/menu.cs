using LloydsMinister.urdu.Balance;
using LloydsMinister.urdu.Deposit;
using LloydsMinister.urdu.Transfer;
using LloydsMinister.urdu.ViewStatement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnMenuBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balancemenu menu = new Balancemenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnMenuDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Depositmenu menu = new Depositmenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnMenuWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdrawmenu menu = new Withdrawmenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnMenuTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfermenu menu = new Transfermenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnMenuStatement_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewstatmentmenu menu = new viewstatmentmenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            btnMenuBalance.Cursor = Cursors.Hand;
            btnMenuDeposit.Cursor = Cursors.Hand;
            btnMenuExit.Cursor = Cursors.Hand;
            btnMenuStatement.Cursor = Cursors.Hand;
            btnMenuTransfer.Cursor = Cursors.Hand;
            btnMenuWithdraw.Cursor = Cursors.Hand;
        }
    }
}
