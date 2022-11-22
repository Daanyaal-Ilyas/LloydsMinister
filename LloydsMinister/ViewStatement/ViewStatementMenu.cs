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
    public partial class ViewStatementMenu : Form
    {
        public ViewStatementMenu()
        {
            InitializeComponent();
        }

        private void ViewStatementMenu_Load(object sender, EventArgs e)
        {
            btnViewStatCurrent.Cursor  = Cursors.Hand;
            btnViewStatLongTerm.Cursor = Cursors.Hand;
            btnViewStatSimple.Cursor   = Cursors.Hand;
            btnViewStatBack.Cursor     = Cursors.Hand;
        }

        private void btnViewStatCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_Current current = new ViewStatement_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void btnViewStatLongTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_LongTerm longTerm = new ViewStatement_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void btnViewStatSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_SimpleDeposit simpleDeposit = new ViewStatement_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void btnViewStatBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        //useless code
        private void lbStatMenuCurrent_Click(object sender, EventArgs e)
        {

        }

        private void lbStatMenuLongTerm_Click(object sender, EventArgs e)
        {

        }

        private void lbStatMenuSimple_Click(object sender, EventArgs e)
        {

        }

        private void lbStatMenuBack_Click(object sender, EventArgs e)
        {

        }
    }
}
