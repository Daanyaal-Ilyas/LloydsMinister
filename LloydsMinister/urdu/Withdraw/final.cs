using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu.Withdraw
{
    public partial class final : Form
    {
        private System.Windows.Forms.Timer tmr;
        public final()
        {
            InitializeComponent();

            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                Application.Exit();
            };
            tmr.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;
            tmr.Start();

            ControlBox = false;
        }
    }
}
