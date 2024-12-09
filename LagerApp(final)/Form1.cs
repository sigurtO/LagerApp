using LagerApp_final_;
using Microsoft.Data.SqlClient;
namespace LagerApp_final_
{
    public partial class Form1 : Form
    {
        private MainMenu mainMenu; // declare form
        private Database _database;
        public Form1()
        {

            InitializeComponent();
            string connectionString = "Server=localhost;Database=ProjectLager;Trusted_Connection=True;TrustServerCertificate=True";
            _database = new Database(connectionString);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            var (MedarbejderID, Password) = _database.ReadWorker();

            if (MedarbejderID != null && Password != null)
            {
                if (password == Password && username == MedarbejderID)
                {
                    mainMenu = new MainMenu(); // creating new form
                    mainMenu.Show(); //shows Main menu form after pressing login
                    this.Hide(); // hides this form
                }
                else
                {
                    MessageBox.Show("Forkert Login");
                }
            }

        }

        private void buttonSkipLogin_Click(object sender, EventArgs e)
        {
            mainMenu = new MainMenu(); // creating new form
            mainMenu.Show(); //shows Main menu form after pressing login
            this.Hide(); // hides this form
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
