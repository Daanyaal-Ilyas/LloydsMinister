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

namespace LloydsMinister.urdu.ViewStatement
{
    public partial class viewstatmentlong : Form
    {
        public viewstatmentlong()
        {
            InitializeComponent();
        }

        private void btnStatBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewstatmentmenu menu = new viewstatmentmenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void viewstatmentlong_Load(object sender, EventArgs e)
        {
            btnStatBack.Cursor = Cursors.Hand;
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT date,time,description,amount  FROM longterm_historyurdu WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);

            dataGridView1.DataSource = bc;
        }
    }
}
