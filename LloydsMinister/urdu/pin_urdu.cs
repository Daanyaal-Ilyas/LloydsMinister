using LloydsMinister.urdu;
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

namespace LloydsMinister
{
    public partial class pin_urdu : Form
    {
        public static string SetValuepin = "";
        public pin_urdu()
        {
            InitializeComponent();

        }

        private void pin_urdu_Load(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetValuepin = enterPin1.Text;
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT Pin FROM card WHERE cardnum = '" + card.SetCard + "'AND Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable pin = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            adapt.Fill(pin);
            if (pin.Rows.Count > 0)
            {
                this.Hide();
                Auth m2 = new Auth();
                m2.ShowDialog();
                m2.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("غلط پن");
                this.Hide();
                card m2 = new card();
                m2.ShowDialog();
                m2.Closed += (s, args) => this.Close();
            }
        }
    }
}
