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
    public partial class TransferSimpleCurrentother : Form
    {
        public TransferSimpleCurrentother()
        {
            InitializeComponent();
        }
        string texten = "transferred";
        string texturdu = "منتقل";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void tbtntransfer2_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            int data = Convert.ToInt32(txttransferamount.Text);
            if (baldata >= data)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - '" + txttransferamount.Text + "', BalanceCurrent = BalanceCurrent + '" + txttransferamount.Text + "' WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void TransferSimpleCurrentother_Load(object sender, EventArgs e)
        {
            btntransferesback.Cursor = Cursors.Hand;
            btntransferextras1.Cursor = Cursors.Hand;
            btntransferextras2.Cursor = Cursors.Hand;
            btntransferextras3.Cursor = Cursors.Hand;
            btntransferextras4.Cursor = Cursors.Hand;
            tbtntransfer2.Cursor = Cursors.Hand;
        }

        private void btntransferesback_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferSimpleCurrent menu = new TransferSimpleCurrent();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
