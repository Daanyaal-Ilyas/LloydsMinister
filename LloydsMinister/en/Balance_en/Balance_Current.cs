﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static LloydsMinister.Pin_en;
using static LloydsMinister.path;
using System.Speech.Synthesis;
using System.Globalization;

namespace LloydsMinister
{
    public partial class Balance_Current : Form
    {
        
        public Balance_Current()
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
        private void Balance_Current_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '"+Pin_en.SetValuepin+"'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            string data = bc.Rows[0]["BalanceCurrent"].ToString();
            lbBalcurrentBal.Text = "£ " + data;

            string text = ("Your Balance is " + lbBalcurrentBal.Text + "Your Last button on your right is Back");
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
