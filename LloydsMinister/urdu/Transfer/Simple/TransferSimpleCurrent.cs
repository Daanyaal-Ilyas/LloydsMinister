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
    public partial class TransferSimpleCurrent : Form
    {
        public TransferSimpleCurrent()
        {
            InitializeComponent();
        }
        string texten = "transferred";
        string texturdu = "منتقل";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private void btntransferback_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferSimple menu = new TransferSimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void TransferSimpleCurrent_Load(object sender, EventArgs e)
        {
            btntransferother.Cursor = Cursors.Hand;
            btntransferback.Cursor = Cursors.Hand;
            btntransfer50.Cursor = Cursors.Hand;
            btntransfer20.Cursor = Cursors.Hand;
            btntransfer10.Cursor = Cursors.Hand;
            btntransfer100.Cursor = Cursors.Hand;
        }

        private void btntransfer10_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10,BalanceCurrent = BalanceCurrent + 10 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void btntransfer20_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 20,BalanceCurrent = BalanceCurrent + 20 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void btntransfer100_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 100,BalanceCurrent = BalanceCurrent + 100 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void btntransfer50_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceSimple FROM customer WHERE Pin = '" + pin_urdu.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceSimple"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 50,BalanceCurrent = BalanceCurrent + 50 WHERE Pin = '" + pin_urdu.SetValuepin + "'");
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

        private void btntransferother_Click(object sender, EventArgs e)
        {
            TransferSimpleCurrentother menu = new TransferSimpleCurrentother();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
