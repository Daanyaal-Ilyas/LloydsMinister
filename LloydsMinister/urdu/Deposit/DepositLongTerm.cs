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
    public partial class DepositLongTerm : Form
    {
        public DepositLongTerm()
        {
            InitializeComponent();
        }

        private void btn10Deposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn20Deposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 20 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn50Deposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 50 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn100Deposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 100 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            //opens the message page to say "that it has been deposited"
            this.Hide();
            final current = new final();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btn150Deposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("UPDATE customer SET  BalanceLong = BalanceLong + 150 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
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

        private void DepositLongTerm_Load(object sender, EventArgs e)
        {
            btn100Deposit.Cursor = Cursors.Hand;
            btn10Deposit.Cursor = Cursors.Hand;
            btn20Deposit.Cursor = Cursors.Hand;
            btn50Deposit.Cursor = Cursors.Hand;
            btn150Deposit.Cursor = Cursors.Hand;
            btnDepositBack.Cursor = Cursors.Hand;
        }
    }
}
