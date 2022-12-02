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
    public partial class BalanceMenu : Form
    {
        public BalanceMenu()
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
        private void BalanceMenu_Load(object sender, EventArgs e)
        {
            string text = ("Balance Menu First button on your left is Current First button on your Right is Simple Deposit Second button on your left is Long Term Last button on your Right is Back");
            read(text);
            btnBalanceCurrentbtn.Cursor  = Cursors.Hand;
            BalanceLongTermbtn.Cursor    = Cursors.Hand;
            BalanceSimplebtn.Cursor      = Cursors.Hand;
            BalanceBackbtn.Cursor        = Cursors.Hand;
        }

        private void btnBalanceCurrentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance_Current current = new Balance_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void BalanceLongTermbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance_LongTerm longTerm = new Balance_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void BalanceSimplebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balance_SimpleDeposit simpleDeposit = new Balance_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void BalanceBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_en menu = new Menu_en();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
