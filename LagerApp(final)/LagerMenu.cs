using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using LagerApp_final_;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LagerApp_final_
{
    public partial class LagerMenu : Form
    {
        private MainMenu mainMenu; // declare form
        public LagerMenu()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //string navn = textBoxProID.Text;
            //string beskrivelse = textBoxNavn.Text;
            //string dato = textBoxSalgsID.Text;
            //int minimumsbeholdning = int.Parse(textBoxAntal.Text);
            //int maksimumsbeholdning = int.Parse(textBoxMaal.Text);

            int produktId = int.Parse(textBoxProID.Text);
            string navn = textBoxNavn.Text;
            int salgsId = int.Parse(textBoxSalgsID.Text);
            int antal = int.Parse(textBoxAntal.Text);
            string vaegt = (textBoxVaegt.Text);
            string maal = textBoxMaal.Text;
            string beskrivelse = textBoxBeskriv.Text;
            string dato = textBoxDato.Text;
            int minimumsbeholdning = int.Parse(textBoxMinbehold.Text);
            int maksimumsbeholdning = int.Parse(textBoxMinbehold.Text);
            string moebeltype = textBoxMoebeltype.Text;
            string materialer = textBoxMaterialer.Text;
            int kostPris = int.Parse(textBoxKostpris.Text);
            int salgsPris = int.Parse(textBoxSalgspris.Text);



            Produkter Nyprodukt = new Produkter
            {
                ProduktID = produktId,
                Navn = navn,
                SalgsID = salgsId,
                Antal = antal,
                Vaegt = vaegt,
                Maal = maal,
                Beskrivelse = beskrivelse,
                Dato = dato,
                Minimumsbeholdning = minimumsbeholdning,
                Maksimumsbeholdning = maksimumsbeholdning,
                Moebeltype = moebeltype,
                Materialer = materialer,
                Kostpris = kostPris,
                SalgsPris = salgsPris

                //Navn = navn,
                //Beskrivelse = beskrivelse,
                //Dato = dato,
                //Minimumsbeholdning = minimumsbeholdning,
                //Maksimumsbeholdning = maksimumsbeholdning
                //Pris = pris
            };

            Program.Database.AddProdukt(Nyprodukt);

            MessageBox.Show("Produkt was added");

        }

        private void textBoxNavn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonProductSearch_Click(object sender, EventArgs e)
        {
            int ProduktID = int.Parse(textBoxProduktsøgning.Text);
            var produktListe = Program.Database.ReadProdukt(ProduktID);
            dataGridViewProdukter.DataSource = produktListe;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        private void button1Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse ProduktID to identify the product to update
                if (!int.TryParse(textBoxProID.Text, out int produktId))
                {
                    MessageBox.Show("Please provide a valid ProduktID.");
                    return;
                }

                // Retrieve the existing product
                Produkter existingProdukt = Program.Database.GetProduktById(produktId);
                // Update only fields with new values
                if (!string.IsNullOrWhiteSpace(textBoxNavn.Text))
                    existingProdukt.Navn = textBoxNavn.Text;

                if (int.TryParse(textBoxSalgsID.Text, out int salgsId))
                    existingProdukt.SalgsID = salgsId;

                if (int.TryParse(textBoxAntal.Text, out int antal))
                    existingProdukt.Antal = antal;

                if (!string.IsNullOrWhiteSpace(textBoxVaegt.Text))
                    existingProdukt.Vaegt = textBoxVaegt.Text;

                if (!string.IsNullOrWhiteSpace(textBoxMaal.Text))
                    existingProdukt.Maal = textBoxMaal.Text;

                if (!string.IsNullOrWhiteSpace(textBoxBeskriv.Text))
                    existingProdukt.Beskrivelse = textBoxBeskriv.Text;

                if (!string.IsNullOrWhiteSpace(textBoxDato.Text))
                    existingProdukt.Dato = textBoxDato.Text;

                if (int.TryParse(textBoxMinbehold.Text, out int minimumsbeholdning))
                    existingProdukt.Minimumsbeholdning = minimumsbeholdning;

                if (int.TryParse(textBoxMaxbehold.Text, out int maksimumsbeholdning))
                    existingProdukt.Maksimumsbeholdning = maksimumsbeholdning;

                if (!string.IsNullOrWhiteSpace(textBoxMoebeltype.Text))
                    existingProdukt.Moebeltype = textBoxMoebeltype.Text;

                if (!string.IsNullOrWhiteSpace(textBoxMaterialer.Text))
                    existingProdukt.Materialer = textBoxMaterialer.Text;

                if (int.TryParse(textBoxKostpris.Text, out int kostPris))
                    existingProdukt.Kostpris = kostPris;

                if (int.TryParse(textBoxSalgspris.Text, out int salgsPris))
                    existingProdukt.SalgsPris = salgsPris;

                // Save changes
                Program.Database.SaveUpdatedProdukt(existingProdukt);

                MessageBox.Show("Product was updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void buttonExportToCVS_Click(object sender, EventArgs e)
        {
            int produktID = int.Parse(textBoxProduktsøgning.Text);

            // Path to documents for all computers
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "file.csv");

            // Run code from database
            Program.Database.ExportToCsv(produktID, filePath);

            MessageBox.Show($"Data has been exported to {filePath}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainMenu = new MainMenu(); // creating new form
            mainMenu.Show(); //shows Main menu form after pressing login
            this.Hide(); // hides this form
        }

        private void buttonFjernProdukt_Click(object sender, EventArgs e)
        {


            if (int.TryParse(textBoxFjernProdukt.Text, out int produktID))
            {
                Program.Database.DeleteProdukt(produktID); 
            }
            else
            {
                MessageBox.Show("Indtast et gyldigt ID!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
