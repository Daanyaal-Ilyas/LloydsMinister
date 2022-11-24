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
    public partial class Withdraw_SimpleDeposit : Form
    {
        protected string path = (@"Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
        public Withdraw_SimpleDeposit()
        {
            InitializeComponent();
        }

        private void Withdraw_SimpleDeposit_Load(object sender, EventArgs e)
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

        private void btnWith3_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnWith4_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 20 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnWith1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 50 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnWith5_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 100 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnWith2_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 150 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }
    }
}
