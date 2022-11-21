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
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();

            pininput.Data = enterPin1.Text;
        }
        public static class pininput
        {
            public static string Data { get; set; }
        }
        //Useless Code
        private void enterPin1_TextChanged(object sender, EventArgs e)
        {

        }
        public void textEnter1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
