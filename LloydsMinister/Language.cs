using LloydsMinister.urdu;
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
    public partial class Language : Form
    {
        public Language()
        {
            InitializeComponent();
        }

        private void btnenglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            CardInsert menu = new CardInsert();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void btnurdu_Click(object sender, EventArgs e)
        {
            this.Hide();
            card menu = new card();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void Language_Load(object sender, EventArgs e)
        {
            btnenglish.Cursor = Cursors.Hand;
            btnurdu.Cursor = Cursors.Hand;
            btnextra1.Cursor = Cursors.Hand;
            btnextra2.Cursor = Cursors.Hand;
            btnextra3.Cursor = Cursors.Hand;
            btnextra4.Cursor = Cursors.Hand;
        }
    }
}
