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

namespace LloydsMinister.en
{
    public partial class Auth : Form
    {
        public Auth()
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
        private void Auth_Load(object sender, EventArgs e)
        {
            string text = "Enter Auth code  Last button on your right is Enter";
            read(text);
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT code FROM auth WHERE code = '" + enterPin1.Text + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable pin = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            adapt.Fill(pin);
            if (pin.Rows.Count > 0)
            {
                this.Hide();
                Menu_en m2 = new Menu_en();
                m2.ShowDialog();
                m2.Closed += (s, args) => this.Close();
            }
            else
            {
                string text = "Wrong code";
                read(text);
                MessageBox.Show("Wrong code");
                this.Hide();
                Pin_en m2 = new Pin_en();
                m2.ShowDialog();
                m2.Closed += (s, args) => this.Close();
            }

        }
    }
}
