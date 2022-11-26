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

namespace LloydsMinister.Transfer_en.Simple
{
    public partial class transfersimplecurrentother : Form
    {
        public transfersimplecurrentother()
        {
            InitializeComponent();
        }

        private void tbtntransfer2_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            int data =Convert.ToInt32(txttransferamount.Text);
            if (baldata >= data)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - '" + txttransferamount.Text + "',BalanceCurrent = BalanceCurrent + '" + txttransferamount.Text + "' WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btntransferesback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfersimplecurrent menu = new Transfersimplecurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
