using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LloydsMinister.Pin;
using System.Data.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LloydsMinister
{
    public partial class Deposit_Current : Form
    {
        public Deposit_Current()
        {
            InitializeComponent();
        }

        private void Deposit_Current_Load(object sender, EventArgs e)
        {
            btnDepositBack.Cursor = Cursors.Hand;
        }

        private void btnDepositBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositMenu menu = new DepositMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btn10CurrentDeposit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source=D:\\LloydsMinister\\LloydsMinister\\customer.db3");
            string query = ("SELECT BalanceCurrent FROM customer WHERE Pin = '" + Pin.SetValuepin + "'");
            SQLiteCommand com = new SQLiteCommand(query, con);
        }
    }
}
