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
    public partial class TransferMenu : Form
    {
        public TransferMenu()
        {
            InitializeComponent();
        }

        private void lbTranMenuCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_Current current = new Transfer_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void lbTranMenuLongTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_LongTerm longTerm = new Transfer_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void lbTranMenuSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_SimpleDeposit simpleDeposit = new Transfer_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void lbTranMenuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void TransferMenu_Load(object sender, EventArgs e)
        {
            lbTranMenuCurrent.Cursor  = Cursors.Hand;
            lbTranMenuLongTerm.Cursor = Cursors.Hand;
            lbTranMenuSimple.Cursor   = Cursors.Hand;
            lbTranMenuBack.Cursor     = Cursors.Hand;
        }
    }
}
