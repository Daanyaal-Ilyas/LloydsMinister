using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            SQLiteConnection con = new SQLiteConnection("Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = " + input);
            SQLiteCommand com = new SQLiteCommand(query, con);

            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(dt);

            lbBalSimpleBalance.Text = dt.Rows[0]["BalanceSimple"].ToString();
        }
    }
}
