using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LloydsMinister.urdu
{
    public partial class card : Form
    {
        public card()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pin_urdu p2 = new pin_urdu();
            p2.ShowDialog();
            p2.Closed += (s, args) => this.Close();
        }

        private void card_Load(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;
            if (System.IO.File.Exists(path.path2))
            {
                // nothing happens because you got the db already
            }

            else
            {
                var db = new SQLiteConnection(path.path2);

                db.CreateTable<DB>();
                db.Close();
            }
        }
    }
}
