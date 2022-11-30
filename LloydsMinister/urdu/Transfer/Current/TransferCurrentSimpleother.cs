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

namespace LloydsMinister.urdu.Transfer.Current
{
    public partial class TransferCurrentSimpleother : Form
    {
        public TransferCurrentSimpleother()
        {
            InitializeComponent();
        }
        string texten = "transferred";
        string texturdu = "منتقل";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void TransferCurrentSimpleother_Load(object sender, EventArgs e)
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
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            int data = Convert.ToInt32(txttransfercurrentsimpammount.Text);
            if (baldata >= data)
            {
                string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "','" + txttransfercurrentsimpammount.Text + "')");
                string storeurdu = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "','" + txttransfercurrentsimpammount.Text + "')");
                string newquery = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - '" + txttransfercurrentsimpammount.Text + "', BalanceSimple = BalanceSimple + '" + txttransfercurrentsimpammount.Text + "' WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = newquery;
                cs.CommandText = storeurdu;
                cd.CommandText = store;
                cs.CommandType = CommandType.Text;
                cd.CommandType = CommandType.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cs.ExecuteNonQuery();
                cd.ExecuteNonQuery();
                this.Hide();
                Final current = new Final();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                this.Hide();
                Nobal nobal = new Nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void btntransfercurrentsimpback_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferCurrentSimple menu = new TransferCurrentSimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
