using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace GestionPostes
{
    static class Program
    {

        public static SqlConnection cnx = new SqlConnection(@"Data Source=RLZ-PC\RLZ;Initial Catalog=GestionPoste;Integrated Security=True");
        public static DataTable DtInfo = new DataTable();
        public static DataTable DtConsulter = new DataTable();

        public static DataSet ds = new DataSet();
        public static SqlDataAdapter da;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
