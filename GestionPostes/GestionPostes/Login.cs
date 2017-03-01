using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionPostes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = -1;
            Program.cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT  COUNT(*) Utilisateur", Program.cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count = Convert.ToInt16(dr[0].ToString());
            }
            if (count != -1 && count == 1)
            {
                Menu Menu = new Menu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connexion Impossible.");
            }
            Program.cnx.Close();
        }
    }
}
