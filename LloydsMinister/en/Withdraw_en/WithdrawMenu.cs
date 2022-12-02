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
    public partial class WithdrawMenu : Form
    {
        public WithdrawMenu()
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
        private void WithdrawMenu_Load(object sender, EventArgs e)
        {
            string text = ("Deposit Menu First button on your left is Current First button on your Right is Simple Deposit Second button on your left is Long Term Last button on your Right is Back");
            read(text);
            btnWithdrawCurrent.Cursor  = Cursors.Hand;
            btnWithdrawExtra.Cursor = Cursors.Hand;
            btnWithdrawSimple.Cursor   = Cursors.Hand;
            btnWithdrawBack.Cursor     = Cursors.Hand;
        }

        private void btnWithdrawCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_Current current = new Withdraw_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }


        private void btnWithdrawSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw_SimpleDeposit simpleDeposit = new Withdraw_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void btnWithdrawBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_en menu = new Menu_en();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
