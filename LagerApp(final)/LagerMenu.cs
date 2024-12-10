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

namespace LagerApp_final_
{
    public partial class LagerMenu : Form
    {
        public LagerMenu()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string navn = textBoxNavn.Text;
            string beskrivelse = textBoxBeskriv.Text;
            string dato = textBoxDato.Text;
            int minimumsbeholdning = int.Parse(textBoxMinLager.Text);
            int maksimumsbeholdning = int.Parse(textBoxMaksLager.Text);
            int pris = int.Parse(textBoxPris.Text);


            Produkter Nyprodukt = new Produkter
            {
                Navn = navn,
                Beskrivelse = beskrivelse,
                Dato = dato,
                Minimumsbeholdning = minimumsbeholdning,
                Maksimumsbeholdning = maksimumsbeholdning,
                Pris = pris
            };

            Program.Database.AddProdukt(Nyprodukt);

            MessageBox.Show("Produkt was added");

        }

        private void buttonProduktSearch_Click(object sender, EventArgs e)
        {






        }
    }
}
