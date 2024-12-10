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
				SalgsPris =	salgsPris

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

		private void label14_Click(object sender, EventArgs e)
		{

		}
	}
}
