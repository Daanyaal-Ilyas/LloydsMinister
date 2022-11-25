using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.Withdraw
{
    public partial class Final2 : Form
    {
        private System.Windows.Forms.Timer tmr;
        public Final2()
        {
            InitializeComponent();

            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Hide();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;
            tmr.Start();

            ControlBox = false;
        }

        private void Final2_Load(object sender, EventArgs e)
        {

        }
    }
}
