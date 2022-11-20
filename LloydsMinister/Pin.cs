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
    public partial class Pin : Form
    {
        public Pin()
        {
            InitializeComponent();
        }

        private void Pin_Load(object sender, EventArgs e)
        {
            textEnter1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu m2 = new Menu();
            m2.ShowDialog();
        }

        private void enterPin1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textEnter1_Click(object sender, EventArgs e)
        {
            if (enterPin1.Text == "1234")
            {
                new Menu().Show();
                this.Hide();
            }
            else if (enterPin1.Text != "1234")
            {
                MessageBox.Show("You have not entered the correct pin. Please enter the correct Pin");
                enterPin1.Clear();
                enterPin1.Focus();
            }
        }
    }
}
