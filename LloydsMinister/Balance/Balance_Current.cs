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
    public partial class Balance_Current : Form
    {
        public Balance_Current()
        {
            InitializeComponent();
        }
        private void Balance_Current_Load(object sender, EventArgs e)
        {
            string input = pininput.Data;
            SQLiteConnection con = new SQLiteConnection("Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
            string query = "SELECT BalanceCurrent FROM customer WHERE Pin = " + input;
            SQLiteCommand com = new SQLiteCommand(query, con);

            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            string data = bc.Rows[0]["BalanceCurrent"].ToString();

            lbBalcurrentBal.Text = "£ " + data;
        }
    }
}
