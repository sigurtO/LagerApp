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

namespace LagerApp_final_
{
    public partial class RåvarerMenu : Form
    {
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
    }
}



