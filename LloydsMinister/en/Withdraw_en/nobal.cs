using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.Withdraw_en
{
    public partial class nobal : Form
    {
        public nobal()
        {
            InitializeComponent();
        }

        private void btnWithdrawnobal_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawMenu withdraw = new WithdrawMenu();
            withdraw.ShowDialog();
            withdraw.Closed += (s, args) => this.Close();
        }

        private void nobal_Load(object sender, EventArgs e)
        {
          btnWithdrawnobal.Cursor = Cursors.Hand;
        }
    }
}
