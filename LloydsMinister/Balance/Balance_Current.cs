using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static LloydsMinister.Pin;
namespace LloydsMinister
{
    public partial class Balance_Current : Form
    {
        public Balance_Current()
        {
            InitializeComponent();
        }
        private void Balance_Current_Load(object sender, EventArgs e)
        {
            string input = pininput.Data;
            SQLiteConnection con = new SQLiteConnection(@"Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = 6565");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            string data = bc.Rows[0]["BalanceCurrent"].ToString();
            lbBalcurrentBal.Text = "£ " + data;

            BalanceCurrentBackbtn.Cursor = Cursors.Hand;
            BalanceCurrentextra1btn.Cursor = Cursors.Hand;
            BalanceCurrentextra2btn.Cursor = Cursors.Hand;
            BalanceCurrentextra3btn.Cursor = Cursors.Hand;
            BalanceCurrentextra4btn.Cursor = Cursors.Hand;
            BalCurrentExtra5kbtn.Cursor = Cursors.Hand;
        }

        private void BalanceCurrentextra5btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceMenu balance = new BalanceMenu();
            balance.ShowDialog();
            balance.Closed += (s, args) => this.Close();
        }
    }
}
