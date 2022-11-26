using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.Transfer.LongTerm
{
    public partial class TransferLong : Form
    {
        public TransferLong()
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
            TransferLongCurrent menu = new TransferLongCurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnsimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferLongSimple menu = new TransferLongSimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void TransferLong_Load(object sender, EventArgs e)
        {
            btncurrent.Cursor = Cursors.Hand;
            btnextra1.Cursor = Cursors.Hand;
            btnextra2.Cursor = Cursors.Hand;
            btnextra3.Cursor = Cursors.Hand;
            btnsimple.Cursor = Cursors.Hand;
            btnTransferBack.Cursor = Cursors.Hand;
        }
    }
}
