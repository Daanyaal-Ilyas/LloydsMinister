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

namespace LloydsMinister.Transfer_en.LongTerm
{
    public partial class Transferlongsimpleother : Form
    {
        public Transferlongsimpleother()
        {
            InitializeComponent();
        }

        private void Transferlongsimpleother_Load(object sender, EventArgs e)
        {
            btntransfer.Cursor = Cursors.Hand;
            btntransferback.Cursor = Cursors.Hand;
            btntransferextra1.Cursor = Cursors.Hand;
            btntransferextra2.Cursor = Cursors.Hand;
            btntransferextra3.Cursor = Cursors.Hand;
            btntransferextra4.Cursor = Cursors.Hand;
        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceLong FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceLong"]);
            int data = Convert.ToInt32(txttransferammount.Text);
            if (baldata >= data)
            {
                string newquery = ("UPDATE customer SET  BalanceLong = BalanceLong - '" + txttransferammount.Text + "', BalanceSimple = BalanceSimple + '" + txttransferammount.Text + "' WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                final current = new final();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                this.Hide();
                nobal nobal = new nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void btntransferback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferlongsimple menu = new Transferlongsimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
