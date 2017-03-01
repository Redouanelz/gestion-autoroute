using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionPostes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter Ajouter = new Ajouter();
            Ajouter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultez Consultez = new Consultez();
            Consultez.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
