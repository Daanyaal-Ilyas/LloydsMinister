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

namespace LloydsMinister
{
    public partial class Withdraw_Current : Form
    {
        public Withdraw_Current()
        {
            InitializeComponent();
        }
        private void Withdraw_Current_Load(object sender, EventArgs e)
        {
            btnWithdrawBack.Cursor = Cursors.Hand;
            btn10CurrentWithdraw.Cursor  = Cursors.Hand;
            btn20CurrentWithdraw.Cursor  = Cursors.Hand;
            btn50CurrentWithdraw.Cursor  = Cursors.Hand;
            btn100CurrentWithdraw.Cursor = Cursors.Hand;
            btn150CurrentWithdraw.Cursor = Cursors.Hand;
        }

        private void btnWithdrawBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawMenu menu = new WithdrawMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btn10CurrentWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 10 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn20CurrentWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 20 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn50CurrentWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 50 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn100CurrentWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 100 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn150CurrentWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceCurrent = BalanceCurrent - 150 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }
    }
}
