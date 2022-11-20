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
            if (System.IO.File.Exists("D:\\LloydsMinister\\LloydsMinister\\customer.db3"))
            {

            }
            else
            {
                var db = new SQLiteConnection("D:\\LloydsMinister\\LloydsMinister\\customer.db3");

                db.CreateTable<DB>();
                db.Close();
            }
        }
    }
}