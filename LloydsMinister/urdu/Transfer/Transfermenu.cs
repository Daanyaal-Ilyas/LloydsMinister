using LloydsMinister.urdu.Transfer.Current;
using LloydsMinister.urdu.Transfer.LongTerm;
using LloydsMinister.urdu.Transfer.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.Transfer
{
    public partial class Transfermenu : Form
    {
        public Transfermenu()
        {
            InitializeComponent();
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu current = new menu();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void Transfermenu_Load(object sender, EventArgs e)
        {
            btnTransferBack.Cursor = Cursors.Hand;
            btnTransferCurrent.Cursor = Cursors.Hand;
            btnTransferSimple.Cursor = Cursors.Hand;
            BalanceExtra2btn.Cursor = Cursors.Hand;
            TransferLongTermbtn.Cursor = Cursors.Hand;
            BalanceExtrabtn.Cursor = Cursors.Hand;
        }

        private void btnTransferSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferSimple simple = new TransferSimple();
            simple.ShowDialog();
            simple.Closed += (s, args) => this.Close();
        }

        private void btnTransferCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferCurrent current = new TransferCurrent();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void TransferLongTermbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferLong longs = new TransferLong();
            longs.ShowDialog();
            longs.Closed += (s, args) => this.Close();
        }
    }
}
