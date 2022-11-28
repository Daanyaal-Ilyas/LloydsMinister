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

namespace LloydsMinister.urdu.Deposit
{
    public partial class DepositSimple : Form
    {
        public DepositSimple()
        {
            InitializeComponent();
        }
        string texten = "Deposit";
        string texturdu = "جمع";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void btn10SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',10)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',10)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
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
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnDepositBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Depositmenu menu = new Depositmenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btn20SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',20)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',20)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 20 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
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
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn50SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',50)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',50)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 50 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
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
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn100SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',100)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',100)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 100 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
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
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn150SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + pin_urdu.SetValuepin + "',150)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + pin_urdu.SetValuepin + "',150)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 150 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
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
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void DepositSimple_Load(object sender, EventArgs e)
        {
            btn10SimpleDeposit.Cursor = Cursors.Hand;
            btn20SimpleDeposit.Cursor = Cursors.Hand;
            btn50SimpleDeposit.Cursor = Cursors.Hand;
            btn100SimpleDeposit.Cursor = Cursors.Hand;
            btn150SimpleDeposit.Cursor = Cursors.Hand;
            btnDepositBack.Cursor = Cursors.Hand;
        }
    }
}
