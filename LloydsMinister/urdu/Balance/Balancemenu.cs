using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.Balance
{
    public partial class Balancemenu : Form
    {
        public Balancemenu()
        {
            InitializeComponent();
        }

        private void btnBalanceCurrentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance_Current current = new Balance_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void BalanceSimplebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance_Simple simple = new Balance_Simple();
            simple.ShowDialog();
            simple.Closed += (s, args) => this.Close();
        }

        private void btnlong_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance_Longterm longterm = new Balance_Longterm();
            longterm.ShowDialog();
            longterm.Closed += (s, args) => this.Close();
        }

        private void BalanceBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void Balancemenu_Load(object sender, EventArgs e)
        {
            btnBalanceCurrentbtn.Cursor = Cursors.Hand;
            btnlong.Cursor = Cursors.Hand;
            BalanceBackbtn.Cursor = Cursors.Hand;
            BalanceExtra2btn.Cursor = Cursors.Hand;
            BalanceExtrabtn.Cursor = Cursors.Hand;
            BalanceSimplebtn.Cursor = Cursors.Hand;
        }
    }
}
