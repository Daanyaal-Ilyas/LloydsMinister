using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.Transfer.Current
{
    public partial class TransferCurrent : Form
    {
        public TransferCurrent()
        {
            InitializeComponent();
        }

        private void TransferCurrent_Load(object sender, EventArgs e)
        {
            btnlongterm.Cursor = Cursors.Hand;
            btnsimple.Cursor = Cursors.Hand;
            btnextra1.Cursor = Cursors.Hand;
            btnextra2.Cursor = Cursors.Hand;
            btnextra3.Cursor = Cursors.Hand;
            btnTransferBack.Cursor = Cursors.Hand;
        }

        private void btnlongterm_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferCurrentLong menu = new TransferCurrentLong();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnsimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferCurrentSimple menu = new TransferCurrentSimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfermenu menu = new Transfermenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
