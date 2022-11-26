using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.Transfer
{
    public partial class Nobal : Form
    {
        public Nobal()
        {
            InitializeComponent();
        }

        private void btntransferdrawnobal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfermenu menu = new Transfermenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void Nobal_Load(object sender, EventArgs e)
        {
            btntransferdrawnobal.Cursor = Cursors.Hand;
        }
    }
}
