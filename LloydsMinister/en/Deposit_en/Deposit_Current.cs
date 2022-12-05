using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LloydsMinister.Pin_en;
using static LloydsMinister.path;
using LloydsMinister.Deposit;
using System.Speech.Synthesis;

namespace LloydsMinister
{
    public partial class Deposit_Current : Form
    {
        public Deposit_Current()
        {
            InitializeComponent();
        }
        string texten = "Deposit";
        string texturdu = "جمع";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void Deposit_Current_Load(object sender, EventArgs e)
        {
            string text = ("Deposit current menu First button on your left is £10 First button on your right is £20 second button on your left is £50  second button on your right is £100 last button on your left is £150 last button on your right is back ");
            read(text);
            btnDepositBack.Cursor = Cursors.Hand;
            btn10CurrentDeposit.Cursor  = Cursors.Hand;
            btn20CurrentDeposit.Cursor  = Cursors.Hand;
            btn50CurrentDeposit.Cursor  = Cursors.Hand;
            btn100CurrentDeposit.Cursor = Cursors.Hand;
            btn150CurrentDeposit.Cursor = Cursors.Hand;
        }

        private void btnDepositBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositMenu menu = new DepositMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btn10CurrentDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',10)");
            string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',10)");
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent + 10 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btn20CurrentDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',20)");
            string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',20)");
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent + 20 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btn50CurrentDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',50)");
            string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',50)");
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent + 50 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btn100CurrentDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',100)");
            string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',100)");
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent + 100 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btn150CurrentDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO current_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',150)");
            string storeurdu = ("INSERT INTO current_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',150)");
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent + 150 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
