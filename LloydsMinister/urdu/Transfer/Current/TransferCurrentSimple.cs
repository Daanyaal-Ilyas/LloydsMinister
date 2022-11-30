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
    public partial class TransferCurrentSimple : Form
    {
        public TransferCurrentSimple()
        {
            InitializeComponent();
        }
        string texten = "transferred";
        string texturdu = "منتقل";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void TransferCurrentSimple_Load(object sender, EventArgs e)
        {
            btntranscurrentsimple10.Cursor = Cursors.Hand;
            btntranscurrentsimple20.Cursor = Cursors.Hand;
            btntranscurrentsimple50.Cursor = Cursors.Hand;
            btntranscurrentsimple100.Cursor = Cursors.Hand;
            btntranscurrentsimpleother.Cursor = Cursors.Hand;
            btnTransferBack.Cursor = Cursors.Hand;
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferCurrent menu = new TransferCurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btntranscurrentsimple10_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            if (baldata >= 10)
            {
                string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',10)");
                string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',10)");
                string newquery = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 10,BalanceSimple = BalanceSimple + 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void btntranscurrentsimple20_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            if (baldata >= 20)
            {
                string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',20)");
                string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',20)");
                string newquery = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 20,BalanceSimple = BalanceSimple + 20 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void btntranscurrentsimple100_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            if (baldata >= 100)
            {
                string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',100)");
                string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',100)");
                string newquery = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 100,BalanceSimple = BalanceSimple + 100 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void btntranscurrentsimple50_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            if (baldata >= 50)
            {
                string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',50)");
                string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',50)");
                string newquery = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 50,BalanceSimple = BalanceSimple + 50 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void btntranscurrentsimpleother_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferCurrentSimpleother menu = new TransferCurrentSimpleother();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
