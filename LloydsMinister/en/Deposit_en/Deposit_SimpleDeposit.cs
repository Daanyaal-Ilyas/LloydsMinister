using LloydsMinister.Deposit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class Deposit_SimpleDeposit : Form
    {
        public Deposit_SimpleDeposit()
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
        private void Deposit_SimpleDeposit_Load(object sender, EventArgs e)
        {
            string text = ("Deposit Simple Deposit menu First button on your left is £10 First button on your right is £20 second button on your left is £50  second button on your right is £100 last button on your left is £150 last button on your right is back ");
            read(text);
            btnDepositBack.Cursor      = Cursors.Hand;
            btn10SimpleDeposit.Cursor  = Cursors.Hand;
            btn20SimpleDeposit.Cursor  = Cursors.Hand;
            btn50SimpleDeposit.Cursor  = Cursors.Hand;
            btn100SimpleDeposit.Cursor = Cursors.Hand;
            btn150SimpleDeposit.Cursor = Cursors.Hand;
        }

        private void btnDepositBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositMenu menu = new DepositMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btn10SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',10)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',10)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 10 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btn20SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',20)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',20)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 20 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btn50SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',50)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',50)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 50 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btn100SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',100)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',100)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 100 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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

        private void btn150SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string store = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "',150)");
            string storeurdu = ("INSERT INTO simple_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "',150)");
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 150 WHERE Pin = '" + Pin_en.SetValuepin + "'");
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
