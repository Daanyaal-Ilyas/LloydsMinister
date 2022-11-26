using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.Transfer.Simple
{
    public partial class TransferSimple : Form
    {
        public TransferSimple()
        {
            InitializeComponent();
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfermenu menu = new Transfermenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btncurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferSimpleCurrent menu = new TransferSimpleCurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnlongterm_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferSimpleLong menu = new TransferSimpleLong();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void TransferSimple_Load(object sender, EventArgs e)
        {
            btncurrent.Cursor = Cursors.Hand;
            btnextra1.Cursor = Cursors.Hand;
            btnextra2.Cursor = Cursors.Hand;
            btnextra3.Cursor = Cursors.Hand;
            btnlongterm.Cursor = Cursors.Hand;
            btnTransferBack.Cursor = Cursors.Hand;
        }
    }
}
