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
    public partial class ViewStatementMenu : Form
    {
        public ViewStatementMenu()
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
        private void ViewStatementMenu_Load(object sender, EventArgs e)
        {
            btnViewStatCurrent.Cursor  = Cursors.Hand;
            btnViewStatLongTerm.Cursor = Cursors.Hand;
            btnViewStatSimple.Cursor   = Cursors.Hand;
            btnViewStatBack.Cursor     = Cursors.Hand;
            BalanceExtra2btn.Cursor = Cursors.Hand;
            BalanceExtrabtn.Cursor = Cursors.Hand;
            string text = ("Deposit Menu First button on your left is Current First button on your Right is Simple Deposit Second button on your left is Long Term Last button on your Right is Back");
            read(text);
        }

        private void btnViewStatCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_Current current = new ViewStatement_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnViewStatLongTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_LongTerm longTerm = new ViewStatement_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void btnViewStatSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_SimpleDeposit simpleDeposit = new ViewStatement_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void btnViewStatBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_en menu = new Menu_en();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
