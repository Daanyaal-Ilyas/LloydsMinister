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
using static LloydsMinister.Pin;
namespace LloydsMinister
{
    public partial class Balance_Current : Form
    {
        protected string path = (@"Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
        public Balance_Current()
        {
            InitializeComponent();
        }
        private void Balance_Current_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '"+Pin.SetValuepin+"'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);
            string data = bc.Rows[0]["BalanceCurrent"].ToString();
            lbBalcurrentBal.Text = "£ " + data;

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
