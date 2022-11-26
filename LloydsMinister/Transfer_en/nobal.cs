using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.Transfer_en
{
    public partial class nobal : Form
    {
        public nobal()
        {
            InitializeComponent();

        }

        private void btntransferdrawnobal_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferMenu menu = new TransferMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void nobal_Load(object sender, EventArgs e)
        {
            btntransferdrawnobal.Cursor = Cursors.Hand;
        }
    }
}
