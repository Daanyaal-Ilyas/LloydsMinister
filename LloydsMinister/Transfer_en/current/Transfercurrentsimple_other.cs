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

namespace LloydsMinister.Transfer_en.current
{
    public partial class Transfercurrentsimple_other : Form
    {
        public Transfercurrentsimple_other()
        {
            InitializeComponent();
        }
        private void Transfercurrentsimple_other_Load(object sender, EventArgs e)
        {
            btntransfercurrentsimpback.Cursor = Cursors.Hand;
            btntransfercurrentsimpextra1.Cursor = Cursors.Hand;
            btntransfercurrentsimpextra2.Cursor = Cursors.Hand;
            btntransfercurrentsimpextra3.Cursor = Cursors.Hand;
            btntransfercurrentsimpextra4.Cursor = Cursors.Hand;
            btntransfercurrentsimptransfer.Cursor = Cursors.Hand;
        }
        private void btntransfercurrentsimptransfer_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            int data = Convert.ToInt32(txttransfercurrentsimpammount.Text);
            if (baldata >= data)
            {
                string newquery = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - '" + txttransfercurrentsimpammount.Text + "', BalanceSimple = BalanceSimple + '" + txttransfercurrentsimpammount.Text + "' WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
    }
}
