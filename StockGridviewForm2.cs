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
    public partial class StockGridviewForm2 : Form
    {

        public StockGridviewForm2()
        {

            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockGridviewForm2_Load(object sender, EventArgs e)
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
                Connexion.adapter = new SqlDataAdapter(@"select Pro_id,Pro_Reference,Pro_Designation,UnitesEnStock,Prix_dachat,Prix_Vente,Taxe,Pro_Description,c.Cat_Nom,f.Four_Nom 
                                                        from Produit p,Categorie c,Fournisseur f where UnitesEnStock > 0 and p.Cat_id=c.Cat_id and f.Four_id=p.Four_id", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                prodgrid.DataSource = Connexion.dt;
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
