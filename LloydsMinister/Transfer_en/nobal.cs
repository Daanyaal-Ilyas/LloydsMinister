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
        private System.Windows.Forms.Timer tmr;
        public nobal()
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

        private void btntransferdrawnobal_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransferMenu menu = new TransferMenu();
            menu.ShowDialog();
            menu.Closed += (s, args) => this.Close();
        }

        private void nobal_Load(object sender, EventArgs e)
        {
            btntransferdrawnobal.Cursor = Cursors.WaitCursor;
        }
    }
}
