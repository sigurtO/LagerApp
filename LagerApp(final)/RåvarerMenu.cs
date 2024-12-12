using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LagerApp_final_;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LagerApp_final_
{
    public partial class RåvarerMenu : Form
    {
        private MainMenu mainMenu; // declare form
        public RåvarerMenu()
        {
            InitializeComponent();
        }

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void RåvarerMenu_Load(object sender, EventArgs e)
		{

		}

		private void button1add_Click(object sender, EventArgs e)
		{

			string navn = textBox1Navn.Text;
			int antal = int.Parse(textBox2Antal.Text);
			int minimumsbeholdning = int.Parse(textBox3Min.Text);
			int maksimumsBeholdning = int.Parse(textBox4Maks.Text);
			string maal = textBox5Maal.Text;
			int vaegt = int.Parse(textBox6Vaegt.Text);
			string lokation = textBox7Lokation.Text;
			int materialeID = int.Parse(textBox8Materiale.Text);
			string materialeType = textBox9MaterialeType.Text;

			Raavare nyRaavare = new Raavare(navn, antal, minimumsbeholdning, maksimumsBeholdning, maal, vaegt, lokation, materialeID, materialeType);

			Program.Database.AddRaavare(nyRaavare);

            MessageBox.Show("Det indtastede blev tilføjet");
        }

        public void buttonRaavareSearch_Click(object sender, EventArgs e)
        {
            int RaavareID = int.Parse(textBoxRaavare.Text);
            var raavreListe = Program.Database.ReadRaavare(RaavareID);
            dataGridViewRaavare.DataSource = raavreListe;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainMenu = new MainMenu(); // creating new form
            mainMenu.Show(); //shows Main menu form after pressing login
            this.Hide(); // hides this form
        }
    }
			MessageBox.Show("Det indtastede blev tilføjet");
		}

		private void buttonOpdater_Click(object sender, EventArgs e)
		{
			try
			{
				// Parse ProduktID to identify the product to update
				if (!int.TryParse(textBox8Materiale.Text, out int materialeId))
				{
					MessageBox.Show("Please provide a valid MaterialeID.");
					return;
				}

				// Retrieve the existing product
				Raavare existingRaavare = Program.Database.GetRaavareById(materialeId);
				// Update only fields with new values
				if (!string.IsNullOrWhiteSpace(textBox1Navn.Text))
					existingRaavare.Navn = textBox1Navn.Text;

				if (int.TryParse(textBox2Antal.Text, out int antal))
					existingRaavare.Antal = antal;

				if (int.TryParse(textBox3Min.Text, out int minimumsbeholdning))
					existingRaavare.Minimumsbeholdning = minimumsbeholdning;

				if (int.TryParse(textBox4Maks.Text, out int maksimumsbeholdning))
					existingRaavare.Maksimumsbeholdning = maksimumsbeholdning;

				if (!string.IsNullOrWhiteSpace(textBox5Maal.Text))
					existingRaavare.Maal = textBox5Maal.Text;

				if (int.TryParse(textBox6Vaegt.Text, out int vaegt))
					existingRaavare.Vaegt = vaegt;


				if (!string.IsNullOrWhiteSpace(textBox7Lokation.Text))
					existingRaavare.Lokation = textBox7Lokation.Text;


				if (!string.IsNullOrWhiteSpace(textBox9MaterialeType.Text))
					existingRaavare.MaterialeType = textBox9MaterialeType.Text;
				
				// Save changes
				Program.Database.SaveUpdatedRaavare(existingRaavare);

				MessageBox.Show("Product was updated successfully.");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}

		}


	}
}



