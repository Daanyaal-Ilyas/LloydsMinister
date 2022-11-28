using LloydsMinister.urdu.ViewStatement;
using LloydsMinister.Withdraw;
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

namespace LloydsMinister.urdu.Withdraw
{
    public partial class WithdrawSimple : Form
    {
        public WithdrawSimple()
        {
            InitializeComponent();
        }
        string texten = "withdrawn";
        string texturdu = "واپس لے لیا";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void btn10SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple,salary FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            int saldata = Convert.ToInt32(bc.Rows[0]["salary"]);
            if (baldata >= 10)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',10)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',10)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
            else if (saldata >= 30000)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',10)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',10)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
                Nobal nobal = new Nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void btn20SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple,salary FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            int saldata = Convert.ToInt32(bc.Rows[0]["salary"]);
            if (baldata >= 20)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',20)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',20)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 20 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
            else if (saldata >= 30000)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',10)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',10)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
                Nobal nobal = new Nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void btn50SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple,salary FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            int saldata = Convert.ToInt32(bc.Rows[0]["salary"]);
            if (baldata >= 50)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',50)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',50)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 50 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
            else if (saldata >= 30000)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',10)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',10)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
                Nobal nobal = new Nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void btn100SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple,salary FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            int saldata = Convert.ToInt32(bc.Rows[0]["salary"]);
            if (baldata >= 100)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',100)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',100)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 100 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
            else if (saldata >= 30000)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',10)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',10)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
                Nobal nobal = new Nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void btn150SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple,salary FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            int saldata = Convert.ToInt32(bc.Rows[0]["salary"]);
            if (baldata >= 150)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',150)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',150)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 150 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
            else if (saldata >= 30000)
            {
                string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',10)");
                string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',10)");
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = query;
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
                Nobal nobal = new Nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void btnWithdrawBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdrawmenu menu = new Withdrawmenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void WithdrawSimple_Load(object sender, EventArgs e)
        {
            btn10SimpleWithdraw.Cursor = Cursors.Hand;
            btn20SimpleWithdraw.Cursor = Cursors.Hand;
            btn50SimpleWithdraw.Cursor = Cursors.Hand;
            btn100SimpleWithdraw.Cursor = Cursors.Hand;
            btn150SimpleWithdraw.Cursor = Cursors.Hand;
            btnWithdrawBack.Cursor = Cursors.Hand;
        }
    }
}
