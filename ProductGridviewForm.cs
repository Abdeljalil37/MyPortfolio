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
    public partial class ProductGridviewForm : Form
    {

        public string cin;
        public string role;
        public ProductGridviewForm()
        {
            InitializeComponent();
        }

        private void ProductGridviewForm_Load(object sender, EventArgs e)
        {
            try { 
            rempliredatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void rempliredatagrid()
        {
            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select Pro_id,Pro_Reference,Pro_Designation,UnitesEnStock,round(Prix_dachat,2) as Prix_dachat,round(Prix_Vente,2) as Prix_Vente,round(Taxe,2) as Taxe, round((Prix_Vente-Prix_dachat),2) as 'Benifice',Pro_Description,c.Cat_Nom,f.Four_Nom 
                                                        from Produit p,Categorie c,Fournisseur f where p.Cat_id=c.Cat_id and f.Four_id=p.Four_id", Connexion.cnx);
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

        private void supprimerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.connecter();
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.Parameters.AddWithValue("id", prodgrid.SelectedRows[0].Cells[0].Value.ToString().Trim(new char[] { ' ' }));
                    Connexion.cmd.CommandText = "delete from Produit where Pro_id=@id";
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " supprimé le Produit " + prodgrid.SelectedRows[0].Cells[1].Value.ToString().Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("Le produit est supprimé");
                    rempliredatagrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cherchetxtb_TextChange(object sender, EventArgs e)
        {
            try { 
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
