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

        private void lbStatMenuCurrent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_Current current = new ViewStatement_Current();
            current.ShowDialog();
            current.Closed += (s, args) => this.Close();
        }

        private void lbStatMenuLongTerm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_LongTerm longTerm = new ViewStatement_LongTerm();
            longTerm.ShowDialog();
            longTerm.Closed += (s, args) => this.Close();
        }

        private void lbStatMenuSimple_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStatement_SimpleDeposit simpleDeposit = new ViewStatement_SimpleDeposit();
            simpleDeposit.ShowDialog();
            simpleDeposit.Closed += (s, args) => this.Close();
        }

        private void lbStatMenuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void ViewStatementMenu_Load(object sender, EventArgs e)
        {
            lbStatMenuCurrent.Cursor  = Cursors.Hand;
            lbStatMenuLongTerm.Cursor = Cursors.Hand;
            lbStatMenuSimple.Cursor   = Cursors.Hand;
            lbStatMenuBack.Cursor     = Cursors.Hand;
        }
    }
}
