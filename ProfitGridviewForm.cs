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
    public partial class ProfitGridviewForm : Form
    {


        public ProfitGridviewForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfitGridviewForm_Load(object sender, EventArgs e)
        {
            try { 
            remplirgrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void remplirgrid()
        {
            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select Cmd_Date as Date,round(SUM(montant),2) as montant,round((sum(montant) - sum(montant - (montant/100*remise))),2) as 'la Remise', round(sum(montant - (montant/100*remise)),2) as 'Montant final' 
                                                        from Commande group by Cmd_Date", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                profitgrid.DataSource = Connexion.dt;
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
