using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteCommand = System.Data.SQLite.SQLiteCommand;
using SQLiteConnection = System.Data.SQLite.SQLiteConnection;

namespace LloydsMinister.urdu
{
    public partial class card : Form
    {
        public card()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pin_urdu p2 = new pin_urdu();
            p2.ShowDialog();
            p2.Closed += (s, args) => this.Close();
        }
        public static string SetCard = "";
        private void card_Load(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;

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
