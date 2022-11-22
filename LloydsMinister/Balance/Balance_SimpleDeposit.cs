using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SQLitePCL;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static LloydsMinister.Pin;
namespace LloydsMinister
{
    public partial class Balance_SimpleDeposit : Form
    {
        public Balance_SimpleDeposit()
        {
            InitializeComponent();
        }

        private void Balance_SimpleDeposit_Load(object sender, EventArgs e)
        {
            string input = pininput.Data;
            SQLiteConnection con = new SQLiteConnection(@"Data Source=D:\LloydsMinister\LloydsMinister\customer.db3");
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = 6565");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable bs = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            adapt.Fill(bs);
            string data = bs.Rows[0]["BalanceSimple"].ToString();
            lbBalSimpleBal.Text = "£ " + data;

            BalSimpleBackbtn.Cursor = Cursors.Hand;
            BalSimpleExtra1btn.Cursor = Cursors.Hand;
            BalSimpleExtra2btn.Cursor = Cursors.Hand;
            BalSimpleExtra3btn.Cursor = Cursors.Hand;
            BalSimpleExtra4btn.Cursor = Cursors.Hand;
            BalSimpleExtra5btn.Cursor = Cursors.Hand;
        }

        private void BalSimpleExtra5btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceMenu balance = new BalanceMenu();
            balance.ShowDialog();
            balance.Closed += (s, args) => this.Close();
        }
    }
}
