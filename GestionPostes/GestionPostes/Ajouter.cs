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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
            
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            DataRow dar = Program.DtInfo.NewRow();
            dar[1] = txt_IDVille.Text;
            dar[2] = txt_Res.Text;
            dar[3] = txt_Poste.Text;
            dar[4] = txt_Origine.Text;
            dar[5] = txt_Extreiter.Text;
            dar[6] = txt_PKD.Text;
            dar[7] = txt_PKF.Text;
            dar[8] = txt_Longeur.Text;
            Program.DtInfo.Rows.Add(dar);
            MessageBox.Show("Ajouter", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            Program.da = new SqlDataAdapter("Select * from Infos", Program.cnx);
            Program.da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da.Fill(Program.ds);
            Program.DtInfo = Program.ds.Tables[0];

            Program.cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT IDVille FROM Ville", Program.cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_IDVille.Items.Add(dr[0].ToString());
            }
            Program.cnx.Close();
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmb = new SqlCommandBuilder(Program.da);
            Program.da.Update(Program.DtInfo.Select("","",DataViewRowState.Added));
            Program.da.Update(Program.DtInfo.Select("", "", DataViewRowState.ModifiedCurrent));
            Program.da.Update(Program.DtInfo.Select("", "", DataViewRowState.Deleted));
            MessageBox.Show("Enregistrer", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txt_PKF.Text);
            int y =  Convert.ToInt16(txt_PKD.Text);
           int result = x - y;
           txt_Longeur.Text = result.ToString();
        }
    }
}
