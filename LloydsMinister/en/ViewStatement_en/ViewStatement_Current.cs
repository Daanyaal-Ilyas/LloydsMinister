﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class ViewStatement_Current : Form
    {
        public ViewStatement_Current()
        {
            InitializeComponent();
        }

        private void ViewStatement_Current_Load(object sender, EventArgs e)
        {
            btnStatBack.Cursor = Cursors.Hand;
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT date,time,description,amount  FROM current_historyen WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            DataTable bc = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            adapter.Fill(bc);

            dataGridView1.DataSource = bc;

        }

        private void btnStatBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatementMenu menu = new ViewStatementMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
