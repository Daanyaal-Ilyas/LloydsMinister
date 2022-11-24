using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.Deposit
{

    public static class FormState
    {
        public static Form PreviousPage;
    }

    public partial class Final : Form
    {

        public Final()
        {
            InitializeComponent();
        }

        private void btnDepositMoneyBack_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }
    }
}
