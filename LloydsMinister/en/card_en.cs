using SQLite;
using System.Data.SQLite;
using System.Data;
using System.Speech;
using System.Speech.Synthesis;
using SQLiteCommand = System.Data.SQLite.SQLiteCommand;
using SQLiteConnection = System.Data.SQLite.SQLiteConnection;

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
            SetCard = cardbox.Text;
            this.Hide();
            Pin_en p2 = new Pin_en();
            p2.ShowDialog();
            p2.Closed += (s, args) => this.Close();
            
        }
        public static string SetCard = "";
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

            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT cardnum  FROM card");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(bc);
            string data = bc.Rows[0]["cardnum"].ToString();
            string data2 = bc.Rows[1]["cardnum"].ToString();
            cardbox.Items.Add(data);
            cardbox.Items.Add(data2);
        }
    }
}