using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.Transfer_en.LongTerm
{
    public partial class Transferlongsimpleother : Form
    {
        public Transferlongsimpleother()
        {
            InitializeComponent();
        }
        string texten = "transferred";
        string texturdu = "منتقل";
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void Transferlongsimpleother_Load(object sender, EventArgs e)
        {
            string text = "Enter the ammount  Last button on your left is Transfer Last button Back";
            read(text);
            btntransfer.Cursor = Cursors.Hand;
            btntransferback.Cursor = Cursors.Hand;
            btntransferextra1.Cursor = Cursors.Hand;
            btntransferextra2.Cursor = Cursors.Hand;
            btntransferextra3.Cursor = Cursors.Hand;
            btntransferextra4.Cursor = Cursors.Hand;
        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceLong FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceLong"]);
            int data = Convert.ToInt32(txttransferammount.Text);
            if (baldata >= data)
            {
                string store = ("INSERT INTO longterm_historyen (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texten + "','" + Pin_en.SetValuepin + "','" + txttransferammount.Text + "')");
                string storeurdu = ("INSERT INTO longterm_historyurdu (date,time,description,Pin,amount) VALUES ('" + date + "','" + time + "','" + texturdu + "','" + Pin_en.SetValuepin + "','" + txttransferammount.Text + "'))");
                string newquery = ("UPDATE customer SET  BalanceLong = BalanceLong - '" + txttransferammount.Text + "', BalanceSimple = BalanceSimple + '" + txttransferammount.Text + "' WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                SQLiteCommand cd = new SQLiteCommand(store, con);
                SQLiteCommand cs = new SQLiteCommand(storeurdu, con);
                cmd.CommandText = newquery;
                cs.CommandText = storeurdu;
                cd.CommandText = store;
                cs.CommandType = CommandType.Text;
                cd.CommandType = CommandType.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cs.ExecuteNonQuery();
                cd.ExecuteNonQuery();
                this.Hide();
                final current = new final();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                this.Hide();
                nobal nobal = new nobal();
                nobal.ShowDialog();
                nobal.Closed += (s, args) => this.Close();
            }
            con.Close();
        }

        private void btntransferback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transferlongsimple menu = new Transferlongsimple();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
