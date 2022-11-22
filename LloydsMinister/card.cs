using SQLite;

namespace LloydsMinister
{
    public partial class CardInsert : Form
    {
        public CardInsert()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Pin p2 = new Pin();
            p2.ShowDialog();
            p2.Closed += (s, args) => this.Close();
            
        }

        private void CardInsert_Load(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;
            if (System.IO.File.Exists("C:\\Users\\omaid\\OneDrive\\Documents\\GitHub\\LloydsMinister\\LloydsMinister\\customer.db3"))
            {
                // nothing happens because you got the db already
            }

            else
            {
                var db = new SQLiteConnection("C:\\Users\\omaid\\OneDrive\\Documents\\GitHub\\LloydsMinister\\LloydsMinister\\customer.db3");

                db.CreateTable<DB>();
                db.Close();
            }
        }
    }
}