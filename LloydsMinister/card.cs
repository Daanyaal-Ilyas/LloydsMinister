using SQLite;

namespace LloydsMinister
{

    public partial class CardInsert : Form
    {
        protected string path = (@"C:\Users\omaid\OneDrive\Documents\GitHub\LloydsMinister\LloydsMinister\customer.db3");
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
            if (System.IO.File.Exists(path))
            {
                // nothing happens because you got the db already
            }

            else
            {
                var db = new SQLiteConnection(path);

                db.CreateTable<DB>();
                db.Close();
            }
        }
    }
}