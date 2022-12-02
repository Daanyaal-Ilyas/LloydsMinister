using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.Transfer_en.Simple
{
    public partial class transfersimplelongterm : Form
    {
        public transfersimplelongterm()
        {
            InitializeComponent();
        }
        string texten = "transferred";
        string texturdu = "منتقل";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void btntransfer10_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            if (baldata >= 10)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',10)");
                string storeurdu = ("INSERT INTO simple_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',10)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10,BalanceLong = BalanceLong + 10 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btntransfer20_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            if (baldata >=20)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',20)");
                string storeurdu = ("INSERT INTO simple_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',20)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 20,BalanceLong = BalanceLong + 20 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btntransfer50_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            if (baldata >= 50)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',50)");
                string storeurdu = ("INSERT INTO simple_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',50)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 50,BalanceLong = BalanceLong + 50 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btntransfer100_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            if (baldata >= 100)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',100)");
                string storeurdu = ("INSERT INTO simple_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',100)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 100,BalanceLong = BalanceLong + 100 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
            Transfer_SimpleDeposit menu = new Transfer_SimpleDeposit();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btntransferother_Click(object sender, EventArgs e)
        {
            this.Hide();
            transfersimplelongother menu = new transfersimplelongother();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void transfersimplelongterm_Load(object sender, EventArgs e)
        {
            string text = ("First button on your left is £10 First button on your right is £20 second button on your left is £50  second button on your right is £100 last button on your left is Other last button on your right is back ");
            read(text);
            btntransfer10.Cursor = Cursors.Hand;
            btntransfer100.Cursor = Cursors.Hand;
            btntransfer20.Cursor = Cursors.Hand;
            btntransfer50.Cursor = Cursors.Hand;
            btntransferback.Cursor = Cursors.Hand;
            btntransferother.Cursor = Cursors.Hand;
        }
    }
}
