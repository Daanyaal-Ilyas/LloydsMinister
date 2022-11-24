using LloydsMinister.Deposit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class Deposit_SimpleDeposit : Form
    {
        protected string path = (@"Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
        public Deposit_SimpleDeposit()
        {
            InitializeComponent();
        }

        private void Deposit_SimpleDeposit_Load(object sender, EventArgs e)
        {
            btnDepositBack.Cursor = Cursors.Hand;
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
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 10 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn20SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 20 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn50SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 50 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn100SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 100 WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            this.Hide();
            Final current = new Final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn150SimpleDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("UPDATE customer SET  BalanceSimple = BalanceSimple + 150 WHERE Pin = '" + Pin.SetValuepin + "'");
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
