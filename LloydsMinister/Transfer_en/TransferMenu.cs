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

        private void TransferMenu_Load(object sender, EventArgs e)
        {
            btnTransferCurrent.Cursor  = Cursors.Hand;
            TransferLongTermbtn.Cursor = Cursors.Hand;
            btnTransferSimple.Cursor   = Cursors.Hand;
            btnTransferBack.Cursor     = Cursors.Hand;
        }

        private void btnTransferCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_Current current = new Transfer_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void TransferLongTermbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_LongTerm longTerm = new Transfer_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void btnTransferSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_SimpleDeposit simpleDeposit = new Transfer_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_en menu = new Menu_en();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        //useless code
        private void lbTranMenuCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lbTranMenuLongTerm_Click(object sender, EventArgs e)
        {

        }

        private void lbTranMenuSimple_Click(object sender, EventArgs e)
        {

        }

        private void lbTranMenuBack_Click(object sender, EventArgs e)
        {

        }
    }
}
