﻿using LloydsMinister.Withdraw;
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

namespace LloydsMinister
{
    public partial class Withdraw_SimpleDeposit : Form
    {
        public Withdraw_SimpleDeposit()
        {
            InitializeComponent();
        }

        private void Withdraw_SimpleDeposit_Load(object sender, EventArgs e)
        {
            btnWithdrawBack.Cursor = Cursors.Hand;
            btn10SimpleWithdraw.Cursor  = Cursors.Hand;
            btn20SimpleWithdraw.Cursor  = Cursors.Hand;
            btn50SimpleWithdraw.Cursor  = Cursors.Hand;
            btn100SimpleWithdraw.Cursor = Cursors.Hand;
            btn150SimpleWithdraw.Cursor = Cursors.Hand;
        }

        private void btnWithdrawBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            WithdrawMenu menu = new WithdrawMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btn10SimpleWithdraw_Click(object sender, EventArgs e)
        {

            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            string salary = ("SELECT salary FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            SQLiteCommand sal = new SQLiteCommand(salary, con);
            DataTable bc = new DataTable();
            DataTable sl = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            SQLiteDataAdapter ad = new SQLiteDataAdapter(sal);
            adapter.Fill(bc);
            ad.Fill(sl);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            int saldata = Convert.ToInt32(sl.Rows[0]["salary"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else if (saldata >= 30000)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 10 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("you dont have enough money to withdraw");
                Application.Exit();
            }
            con.Close();
        }

        private void btn20SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            string salary = ("SELECT salary FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            SQLiteCommand sal = new SQLiteCommand(salary, con);
            DataTable bc = new DataTable();
            DataTable sl = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            SQLiteDataAdapter ad = new SQLiteDataAdapter(sal);
            adapter.Fill(bc);
            ad.Fill(sl);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            int saldata = Convert.ToInt32(sl.Rows[0]["salary"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 20 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else if (saldata >= 30000)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 20 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("you dont have enough money to withdraw");
                Application.Exit();
            }
            con.Close();
        }
        private void btn50SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            string salary = ("SELECT salary FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            SQLiteCommand sal = new SQLiteCommand(salary, con);
            DataTable bc = new DataTable();
            DataTable sl = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            SQLiteDataAdapter ad = new SQLiteDataAdapter(sal);
            adapter.Fill(bc);
            ad.Fill(sl);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            int saldata = Convert.ToInt32(sl.Rows[0]["salary"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 50 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else if (saldata >= 30000)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 50 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("you dont have enough money to withdraw");
                Application.Exit();
            }
            con.Close();
        }
        private void btn100SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            string salary = ("SELECT salary FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            SQLiteCommand sal = new SQLiteCommand(salary, con);
            DataTable bc = new DataTable();
            DataTable sl = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            SQLiteDataAdapter ad = new SQLiteDataAdapter(sal);
            adapter.Fill(bc);
            ad.Fill(sl);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            int saldata = Convert.ToInt32(sl.Rows[0]["salary"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 100 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else if (saldata >= 30000)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 100 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("you dont have enough money to withdraw");
                Application.Exit();
            }
            con.Close();
        }
        private void btn150SimpleWithdraw_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(path.path1);
            con.Open();
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            string salary = ("SELECT salary FROM customer WHERE Pin = '" + Pin_en.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
            SQLiteCommand sal = new SQLiteCommand(salary, con);
            DataTable bc = new DataTable();
            DataTable sl = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(com);
            SQLiteDataAdapter ad = new SQLiteDataAdapter(sal);
            adapter.Fill(bc);
            ad.Fill(sl);
            int baldata = Convert.ToInt32(bc.Rows[0]["BalanceCurrent"]);
            int saldata = Convert.ToInt32(sl.Rows[0]["salary"]);
            if (baldata >= 10)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 150 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else if (saldata >= 30000)
            {
                string newquery = ("UPDATE customer SET  BalanceSimple = BalanceSimple - 150 WHERE Pin = '" + Pin_en.SetValuepin + "'");
                SQLiteCommand cmd = new SQLiteCommand(newquery, con);
                com.CommandText = newquery;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                this.Hide();
                Final2 current = new Final2();
                current.ShowDialog();
                current.Closed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("you dont have enough money to withdraw");
                Application.Exit();
            }
            con.Close();
        }
    }
}