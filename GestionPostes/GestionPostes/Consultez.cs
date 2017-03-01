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
    public partial class Consultez : Form
    {
        public Consultez()
        {
            InitializeComponent();
        }

        private void Consultez_Load(object sender, EventArgs e)
        {
            Program.cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT IDVille FROM Ville", Program.cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            Program.cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.DtConsulter.Clear();
            Program.da = new SqlDataAdapter("Select * from Infos WHERE IDVille = "+ comboBox1.Text, Program.cnx);
            Program.da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da.Fill(Program.ds, "Consulter");
            Program.DtConsulter = Program.ds.Tables["Consulter"];
            dataGridView1.DataSource = Program.DtConsulter;
   
        }
    }
}
