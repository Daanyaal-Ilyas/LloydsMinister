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
using static LloydsMinister.Pin_en;
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
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '"+Pin_en.SetValuepin+"'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable bs = new DataTable();
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            adapt.Fill(bs);
            string data = bs.Rows[0]["BalanceSimple"].ToString();
            lbBalSimpleBal.Text = "£ " + data;


            //cursor 
            
        

            btnBalanceBack.Cursor= Cursors.Hand;
        }

        private void btnBalanceBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BalanceMenu menu = new BalanceMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();

        }
    }
}

