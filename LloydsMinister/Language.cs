using LloydsMinister.urdu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class Language : Form
    {
        public Language()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void btnenglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardInsert menu = new CardInsert();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void btnurdu_Click(object sender, EventArgs e)
        {
            this.Hide();
            card menu = new card();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void Language_Load(object sender, EventArgs e)
        {
            string text = ("Please Pick Your Language First button on your Left is English and First button on your right is Urdu  ");
            read(text);
            btnenglish.Cursor = Cursors.Hand;
            btnurdu.Cursor = Cursors.Hand;
            btnextra1.Cursor = Cursors.Hand;
            btnextra2.Cursor = Cursors.Hand;
            btnextra3.Cursor = Cursors.Hand;
            btnextra4.Cursor = Cursors.Hand;
        }
    }
}
