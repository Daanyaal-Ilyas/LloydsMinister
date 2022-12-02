using SQLite;
using System.Speech;
using System.Speech.Synthesis;

namespace LloydsMinister
{

    public partial class CardInsert : Form
    {
        public CardInsert()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Pin_en p2 = new Pin_en();
            p2.ShowDialog();
            p2.Closed += (s, args) => this.Close();
            
        }

        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void CardInsert_Load(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;
            string text = "Insert card";
            read(text);
            
        }
    }
}