using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LagerApp_final_
{
    public partial class OrdreMenu : Form
    {
        private MainMenu mainMenu; // declare form
        public OrdreMenu()
        {
            InitializeComponent();

            var kundeListe = Program.Database.ReadAllKunde();
            dataGridViewOrdre.DataSource = kundeListe;
            dataGridViewOrdre.Columns["KundeNavn"].DisplayIndex = 0;
            dataGridViewOrdre.Columns["KundeID"].DisplayIndex = 1;

        }

        public void buttonOrdreSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                var kundeListe = Program.Database.ReadAllKunde();
                dataGridViewOrdre.DataSource = kundeListe;
                dataGridViewOrdre.Columns["KundeNavn"].DisplayIndex = 0;
                dataGridViewOrdre.Columns["KundeID"].DisplayIndex = 1;
            }
            else
            {
                int OrdreID = int.Parse(textBox1.Text);
                var ordreListe = Program.Database.ReadOrdre(OrdreID);
                dataGridViewOrdre.DataSource = ordreListe;

                // Change the order of the columns
                dataGridViewOrdre.Columns["KundeID"].DisplayIndex = 0;
                dataGridViewOrdre.Columns["KundeNavn"].DisplayIndex = 1;
                dataGridViewOrdre.Columns["OrdreId"].DisplayIndex = 2;
                dataGridViewOrdre.Columns["Info"].DisplayIndex = 3;
                dataGridViewOrdre.Columns["Dato"].DisplayIndex = 4;
                dataGridViewOrdre.Columns["Leverandoer"].DisplayIndex = 5;
            }
        }



        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainMenu = new MainMenu(); // creating new form
            mainMenu.Show(); //shows Main menu form after pressing login
            this.Hide(); // hides this form
        }

        private void dataGridViewOrdre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}