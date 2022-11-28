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
    public partial class Transfercurrentlong_other : Form
    {
        public Transfercurrentlong_other()
        {
            InitializeComponent();
        }

        string texten = "transferred";
        string texturdu = "منتقل";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void btntransfercurrentlongback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfercurrent_longterm menu = new Transfercurrent_longterm();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void Transfercurrentlong_other_Load(object sender, EventArgs e)
        {
            btntransfercurrentlongback.Cursor = Cursors.Hand;
            btntransfercurrentlongextra1.Cursor = Cursors.Hand;
            btntransfercurrentlongextra2.Cursor = Cursors.Hand;
            btntransfercurrentlongextra3.Cursor = Cursors.Hand;
            btntransfercurrentlongextra4.Cursor = Cursors.Hand;
            btntransfercurrentlongtransfer.Cursor = Cursors.Hand;
        }

        private void btntransfercurrentlongtransfer_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            int data = Convert.ToInt32(txttransfercurrentlongammount.Text);
            if (baldata >= data)
            {
                string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "','" + txttransfercurrentlongammount.Text + "')");
                string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "','" + txttransfercurrentlongammount.Text + "'))");
                string newquery = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - '" + txttransfercurrentlongammount.Text + "', BalanceLong = BalanceLong + '" + txttransfercurrentlongammount.Text + "' WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
