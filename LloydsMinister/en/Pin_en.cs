using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class Pin_en : Form
    {
        public Pin_en()
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
        private void Pin_Load(object sender, EventArgs e)
        {
            string text = "Enter Pin  Last button on your right is Enter";
            read(text);
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetValuepin = enterPin1.Text;
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT Pin FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable pin = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            adapt.Fill(pin);
            if(pin.Rows.Count > 0)
            {
                this.Hide();
                Menu_en m2 = new Menu_en();
                m2.ShowDialog();
                m2.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Pin");
                this.Hide();
                CardInsert m2 = new CardInsert();
                m2.ShowDialog();
                m2.Closed += (s, args) => this.Close();
            }
            
        }
        public static string SetValuepin = "";
    }
}
