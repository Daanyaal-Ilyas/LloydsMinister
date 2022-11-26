using LloydsMinister.urdu.Transfer.Current;
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

namespace LloydsMinister.urdu.Transfer.Simple
{
    public partial class TransferSimpleLongother : Form
    {
        public TransferSimpleLongother()
        {
            InitializeComponent();
        }

        private void btntransferback_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferSimpleLong menu = new TransferSimpleLong();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            int data = Convert.ToInt32(txttransferammount.Text);
            if (baldata >= data)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - '" + txttransferammount.Text + "', BalanceLong = BalanceLong + '" + txttransferammount.Text + "' WHERE Pin = '" + pin_urdu.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final current = new Final();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                this.Hide();
                Nobal nobal = new Nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void TransferSimpleLongother_Load(object sender, EventArgs e)
        {
            btntransfer.Cursor = Cursors.Hand;
            btntransferback.Cursor = Cursors.Hand;
            btntransferextra2.Cursor = Cursors.Hand;
            btntransferextra3.Cursor = Cursors.Hand;
            btntransferextra4.Cursor = Cursors.Hand;
            btntransferextra5.Cursor = Cursors.Hand;
        }
    }
}
