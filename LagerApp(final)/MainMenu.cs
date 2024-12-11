using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagerApp_final_
{
    public partial class MainMenu : Form
    {
        private LagerMenu lagerMenu;
        private OrdreMenu ordreMenu;
        private RåvarerMenu råvarerMenu;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonLagerStyring_Click(object sender, EventArgs e)
        {
            lagerMenu = new LagerMenu();
            lagerMenu.Show();
            this.Hide();

        }

        private void Ordrehandle_Click(object sender, EventArgs e)
        {
            ordreMenu = new OrdreMenu();
            ordreMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//Den hedder button1Raavarer//
        {
            råvarerMenu = new RåvarerMenu();
            råvarerMenu.Show();
            this.Hide();
        }
    }
}
