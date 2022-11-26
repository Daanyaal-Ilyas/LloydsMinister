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

namespace LloydsMinister.urdu.Balance
{
    public partial class Balance_Simple : Form
    {
        public Balance_Simple()
        {
            InitializeComponent();
        }

        private void Balance_Simple_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            string data = bc.Rows[0]["BalanceSimple"].ToString();
            lbBalsimpleBal.Text = "£ " + data;

            //cursor
            btnBalanceBack.Cursor = Cursors.Hand;
        }

        private void btnBalanceBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balancemenu menu = new Balancemenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
