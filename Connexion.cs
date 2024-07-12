using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Younes_Entreprise
{
    public static class Connexion
    {
      //   public SqlConnection cnx = new SqlConnection(@"server=.;database=Auto_Serv;User ID=abdo;password=abdo2005");
      //    public static SqlConnection cnx = new SqlConnection(@"server=DESKTOP-N16PLLL;database=Auto_Serv;User ID=Oussama;password=autoapp123");
        public static SqlConnection cnx = new SqlConnection(@"server=DESKTOP-3H4VPNA\MSSQLSERVER02;database=Auto_Serv;integrated security=true");
        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;
        public static DataTable dt;
        public static SqlDataReader dr;

        public static void connecter()
        {
            if (cnx.State != ConnectionState.Open)
            {

                cnx.Open();
            }
        }
        public static void deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

        }
    }
}
