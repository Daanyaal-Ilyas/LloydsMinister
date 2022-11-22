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
using static LloydsMinister.Pin;

namespace LloydsMinister
{
    public partial class Balance_LongTerm : Form
    {
        public Balance_LongTerm()
        {
            InitializeComponent();
        }

        private void Balance_LongTerm_Load(object sender, EventArgs e)
        {
            string input = pininput.Data;
            SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\omaid\OneDrive\Documents\GitHub\LloydsMinister\LloydsMinister\customer.db3");
            con.Open();
            string query = ("SELECT BalanceLong FROM customer WHERE Pin = 6565");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable bl = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            adapt.Fill(bl);
            string data = bl.Rows[0]["BalanceLong"].ToString();
            lbBalLongTermBalance.Text = "£ " + data;

<<<<<<< HEAD
            //cursor
            btnBalanceBack.Cursor = Cursors.Hand;
        }

        private void btnBalanceBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceMenu menu = new BalanceMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
=======
            BalLongTermBackbtn.Cursor = Cursors.Hand;
            BalLongTermExtra1btn.Cursor = Cursors.Hand;
            BalLongTermExtra2btn.Cursor = Cursors.Hand;
            BalLongTermExtra3btn.Cursor = Cursors.Hand;
            BalLongTermExtra4btn.Cursor = Cursors.Hand;
            BalLongTermExtra5btn.Cursor = Cursors.Hand;

        }

        private void BalLongTermExtra5btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceMenu balance = new BalanceMenu();
            balance.ShowDialog();
            balance.Closed += (s, args) => this.Close();
>>>>>>> aad93185930da9c8e245b29e9b49d1c2d88acd79
        }
    }
}
