using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister
{
    public partial class Transfer_Current : Form
    {
        public Transfer_Current()
        {
            InitializeComponent();
        }

        private void Transfer_Current_Load(object sender, EventArgs e)
        {
            btnTransferBack.Cursor = Cursors.Hand;
            btnlongterm.Cursor = Cursors.Hand;
            btnsimple.Cursor = Cursors.Hand;
        }

        private void btnTransferBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferMenu menu = new TransferMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnlongterm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_LongTerm menu = new Transfer_LongTerm();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnsimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer_SimpleDeposit menu = new Transfer_SimpleDeposit();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }
    }
}
