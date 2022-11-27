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
    public partial class viewstatmentmenu : Form
    {
        public viewstatmentmenu()
        {
            InitializeComponent();
        }

        private void viewstatmentmenu_Load(object sender, EventArgs e)
        {
            btnViewStatBack.Cursor = Cursors.Hand;
            btnViewStatCurrent.Cursor = Cursors.Hand;
            btnViewStatLongTerm.Cursor = Cursors.Hand;
            btnViewStatSimple.Cursor = Cursors.Hand;
            BalanceExtra2btn.Cursor = Cursors.Hand;
            BalanceExtrabtn.Cursor = Cursors.Hand;
        }

        private void btnViewStatBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnViewStatSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewstatmentsimple menu = new viewstatmentsimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnViewStatCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewstatmentcurrent menu = new viewstatmentcurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnViewStatLongTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewstatmentlong menu = new viewstatmentlong();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
