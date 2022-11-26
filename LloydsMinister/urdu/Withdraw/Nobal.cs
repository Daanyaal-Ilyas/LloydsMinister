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

namespace LloydsMinister.urdu.Withdraw
{
    public partial class Nobal : Form
    {
        public Nobal()
        {
            InitializeComponent();
        }

        private void btnWithdrawnobal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdrawmenu withdraw = new Withdrawmenu();
            withdraw.ShowDialog();
            withdraw.Closed += (s, args) => this.Close();
        }

        private void Nobal_Load(object sender, EventArgs e)
        {
            btnWithdrawnobal.Cursor = Cursors.Hand;
        }
    }
}
