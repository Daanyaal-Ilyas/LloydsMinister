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

namespace LloydsMinister.urdu
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
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
                menu m2 = new menu();
                m2.ShowDialog();
                m2.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("غلط کوڈ");
                this.Hide();
                pin_urdu m2 = new pin_urdu();
                m2.ShowDialog();
                m2.Closed += (s, args) => this.Close();
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }
    }
}
