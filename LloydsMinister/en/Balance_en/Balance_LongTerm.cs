using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LloydsMinister.Pin_en;
using static LloydsMinister.path;
using System.Speech.Synthesis;

namespace LloydsMinister
{
    public partial class Balance_LongTerm : Form
    {
        public Balance_LongTerm()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sp = new SpeechSynthesizer();
        private void read(string text)
        {
            sp.Dispose();
            sp = new SpeechSynthesizer();
            sp.SpeakAsync(text);
        }
        private void Balance_LongTerm_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceLong FROM customer WHERE Pin = '"+Pin_en.SetValuepin+"'");
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapt = new SQLiteDataAdapter(cmd);
            DataTable bl = new DataTable();
            adapt.Fill(bl);
            string data = bl.Rows[0]["BalanceLong"].ToString();
            lbBalLongTermBalance.Text = "£ " + data;
            string text = ("Your Balance is " + lbBalLongTermBalance.Text + "Your Last button on your right is Back");
            read(text);
            //cursor
            btnBalanceBack.Cursor = Cursors.Hand;
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
