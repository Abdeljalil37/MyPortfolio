using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Younes_Entreprise
{
    public partial class DailyOrderForm : Form
    {

        public DailyOrderForm()
        {
            InitializeComponent();
        }
        private void DailyOrderForm_Load(object sender, EventArgs e)
        {
            try { 
            remplirgrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void remplirgrid()
        {
            try {
                Connexion.connecter();
            if (Connexion.dt.Rows != null)
            {
                    Connexion.dt.Clear();
            }
            Connexion.cmd.CommandText = "select ('FA'+convert(varchar(30),c.Cmd_id)) as Cmd_id,trim(Cli_Nom) as Cli_Nom,(TRIM(u.Util_Nom)+' '+TRIM(u.Util_Prenom))as Util_Nom,Cmd_Date,montant from Commande c,Utilisateur u,Client cl where c.Cli_id=cl.Cli_id and u.Util_id=c.Util_id and DATEDIFF(day,Cmd_Date,GETDATE())=0";
            SqlDataReader dr = Connexion.cmd.ExecuteReader();
                Connexion.dt.Load(dr);
            cmdgrid.DataSource = Connexion.dt;
            dr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
    }
}
