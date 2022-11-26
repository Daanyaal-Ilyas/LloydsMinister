using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.Deposit
{
    public partial class Depositmenu : Form
    {
        public Depositmenu()
        {
            InitializeComponent();
        }

        private void btnDepositCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositCurrent menu = new DepositCurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void Depositmenu_Load(object sender, EventArgs e)
        {
            btnDepositBack.Cursor = Cursors.Hand;
            btnDepositCurrent.Cursor = Cursors.Hand;
            btnDepositLong.Cursor = Cursors.Hand;
            btnDepositSimple.Cursor = Cursors.Hand;
            BalanceExtra2btn.Cursor = Cursors.Hand;
            BalanceExtrabtn.Cursor = Cursors.Hand;
        }

        private void btnDepositSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositSimple menu = new DepositSimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnDepositLong_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositLongTerm menu = new DepositLongTerm();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnDepositBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
