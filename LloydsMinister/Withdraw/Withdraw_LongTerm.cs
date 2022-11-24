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
    public partial class Withdraw_LongTerm : Form
    {
        protected string path = (@"Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
        public Withdraw_LongTerm()
        {
            InitializeComponent();
        }

        private void Withdraw_LongTerm_Load(object sender, EventArgs e)
        {
            btnWithdrawBack.Cursor = Cursors.Hand;
        }

        private void btnWithdrawBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawMenu menu = new WithdrawMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void pictureTriangle3_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong - 10 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void pictureTriangle4_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong - 20 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void pictureTriangle1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong - 50 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void pictureTriangle5_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong - 100 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been Withdrawn"
            Final2 current = new Final2();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void pictureTriangle2_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong - 150 WHERE Pin = '" + Pin.SetValuepin + "'");
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
