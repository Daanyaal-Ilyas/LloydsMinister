using LloydsMinister.Transfer_en.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class Transfer_SimpleDeposit : Form
    {
        public Transfer_SimpleDeposit()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void Transfer_SimpleDeposit_Load(object sender, EventArgs e)
        {
            btnTransferBack.Cursor = Cursors.Hand;
            btncurrent.Cursor = Cursors.Hand;
            btnlongterm.Cursor = Cursors.Hand;
            btnextra3.Cursor = Cursors.Hand;
            btnextra2.Cursor = Cursors.Hand;
            btnextra1.Cursor = Cursors.Hand;
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferMenu menu = new TransferMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btncurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfersimplecurrent menu = new Transfersimplecurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnlongterm_Click(object sender, EventArgs e)
        {
            this.Hide();
            transfersimplelongterm menu = new transfersimplelongterm();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
