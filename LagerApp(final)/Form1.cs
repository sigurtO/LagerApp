using LagerApp_final_;
using Microsoft.Data.SqlClient;
namespace LagerApp_final_
{
    public partial class Form1 : Form
    {
        private MainMenu mainMenu; // declare form
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            MedarbejderLogin login = Program.Database.ReadWorker(username, password);
            if (login != null)
            {
                mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Forkert Login");
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
