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
    public partial class StockGridviewForm : Form
    {

        public string cin;
        public string role;
        public StockGridviewForm()
        {
            InitializeComponent();
        }
        private void StockGridviewForm_Load(object sender, EventArgs e)
        {
            try { 
            rempliredatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rempliredatagrid()
        {

            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select Ent_id,s.Pro_id,Pro_Reference,Pro_Designation,c.Cat_Nom,s.QTE,s.prix_dachat,s.prix_vente,p.Pro_Description,f.Four_Nom,ROUND(Taxe,2) as Taxe,Ent_Date,montant 
                                                        from Stock s,Produit p,Fournisseur f,Categorie c where s.Pro_id=p.Pro_id and f.Four_id=s.Four_id and p.Cat_id=c.Cat_id", Connexion.cnx);
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

        private void chercherbtn_Click(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Ent_Date]>='" + dateTimePicker1.Value + "' and [Ent_Date]<'" + dateTimePicker2.Value + "' ";
            prodgrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cherchetxtb_TextChange(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = Connexion.dt;
                bs.Filter = "[Pro_Reference] like '%" + cherchetxtb.Text + "%' or [Pro_Designation] like '%" + cherchetxtb.Text + "%' or [Pro_Description] like '%" + cherchetxtb.Text + "%' or [Cat_Nom] like '%" + cherchetxtb.Text + "%' or [Four_Nom] like '%" + cherchetxtb.Text + "%'";
                prodgrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
