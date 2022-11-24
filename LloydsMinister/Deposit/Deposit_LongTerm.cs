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
        protected string path = (@"Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
        public Deposit_LongTerm()
        {
            InitializeComponent();
        }

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
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 10 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn20LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 20 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn50LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 50 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn100LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 100 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn150LongDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 150 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }
    }
}
