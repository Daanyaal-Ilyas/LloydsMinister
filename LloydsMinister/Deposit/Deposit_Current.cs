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

        private void pictureTriangle3_Click(object sender, EventArgs e)
        {            

        }
    }
}
