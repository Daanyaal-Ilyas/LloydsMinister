using LloydsMinister.Deposit;
using Microsoft.Data.SqlClient;
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

namespace LloydsMinister
{
    public partial class Deposit_LongTerm : Form
    {
        public Deposit_LongTerm()
        {
            InitializeComponent();
        }
        string texten = "Deposit";
        string texturdu = "جمع";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void Deposit_LongTerm_Load(object sender, EventArgs e)
        {
            btnDepositBack.Cursor = Cursors.Hand;
            btn10LongDeposit.Cursor  = Cursors.Hand;
            btn20LongDeposit.Cursor  = Cursors.Hand;
            btn50LongDeposit.Cursor  = Cursors.Hand;
            btn100LongDeposit.Cursor = Cursors.Hand;
            btn150LongDeposit.Cursor = Cursors.Hand;
        }

        private void btnDepositBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositMenu menu = new DepositMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btn10LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO longterm_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',10)");
            string storeurdu = ("INSERT INTO longterm_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',10)");
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 10 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn20LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO longterm_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',20)");
            string storeurdu = ("INSERT INTO longterm_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',20)");
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 20 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn50LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO longterm_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',50)");
            string storeurdu = ("INSERT INTO longterm_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',50)");
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 50 WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
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
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn100LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO longterm_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',100)");
            string storeurdu = ("INSERT INTO longterm_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',100)");
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 100 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn150LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO longterm_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',150)");
            string storeurdu = ("INSERT INTO longterm_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',150)");
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 150 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }
    }
}
