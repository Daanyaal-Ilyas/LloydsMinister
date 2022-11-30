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

namespace LloydsMinister.urdu.Transfer.LongTerm
{
    public partial class TransferLongSimpleother : Form
    {
        public TransferLongSimpleother()
        {
            InitializeComponent();
        }
        string texten = "transferred";
        string texturdu = "منتقل";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void btntransfer_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceLong FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceLong"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceLong = BalanceLong - '" + txttransferammount.Text + "',BalanceSimple = BalanceSimple + '" + txttransferammount.Text + "' WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void TransferLongSimpleother_Load(object sender, EventArgs e)
        {
            btntransfer.Cursor = Cursors.Hand;
            btntransferback.Cursor = Cursors.Hand;
            btntransferextra1.Cursor = Cursors.Hand;
            btntransferextra2.Cursor = Cursors.Hand;
            btntransferextra3.Cursor = Cursors.Hand;
            btntransferextra4.Cursor = Cursors.Hand;
        }

        private void btntransferback_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferLongSimple menu = new TransferLongSimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
