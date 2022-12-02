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

namespace LloydsMinister.Withdraw_en
{
    public partial class nobal : Form
    {
        public nobal()
        {
            InitializeComponent();
        }

        private void btnWithdrawnobal_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawMenu withdraw = new WithdrawMenu();
            withdraw.ShowDialog();
            withdraw.Closed += (s, args) => this.Close();
        }
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void nobal_Load(object sender, EventArgs e)
        {
            string text = ("You don't have enough money to Withdraw button on your left is back");
            read(text);
            btnWithdrawnobal.Cursor = Cursors.Hand;
        }
    }
}
