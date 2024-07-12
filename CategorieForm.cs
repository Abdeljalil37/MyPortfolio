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
    public partial class CategorieForm : Form
    {
        string id;
        public string cin;
        public string role;
        public CategorieForm()
        {
            InitializeComponent();
        }

        private void ajouterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into Categorie values(@nom,@description)";
                Connexion.cmd.Parameters.AddWithValue("nom", cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("description", detailstxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", " ajouté une Catégorie" + id);
                Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                MessageBox.Show("La catégorie est ajoutée");
                rempliregrid();
                cintxtbox.Clear();
                detailstxtbox.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategorieForm_Load(object sender, EventArgs e)
        {
            try
            {
                rempliregrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void rempliregrid()
        {

            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select Cat_id,TRIM(Cat_Nom)as Cat_Nom,TRIM(Cat_Description) as Cat_Description from Categorie", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                Utlisiateurgrid.DataSource = Connexion.dt;
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifierbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "update Categorie set Cat_Nom=@nom,Cat_Description=@description where Cat_id=@id";
                Connexion.cmd.Parameters.AddWithValue("id", id);
                Connexion.cmd.Parameters.AddWithValue("nom", cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("description", detailstxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", " modifié les données de la Catégorie  " + id);
                Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                MessageBox.Show("La catégorie est modifiée");
                rempliregrid();
                cintxtbox.Clear();
                detailstxtbox.Clear();
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
                Connexion.connecter();
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "delete from Categorie where Cat_id=@id";
                    Connexion.cmd.Parameters.AddWithValue("id", id);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " supprimé La Catégorie " + id);
                    Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("La catégorie est supprimée");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            rempliregrid();
            cintxtbox.Clear();
            detailstxtbox.Clear();
        }

        private void Utlisiateurgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Utlisiateurgrid.SelectedRows[0].Cells[0].Value.ToString().Trim(new char[] { ' ' });
                cintxtbox.Text = Utlisiateurgrid.SelectedRows[0].Cells[1].Value.ToString().Trim(new char[] { ' ' });
                detailstxtbox.Text = Utlisiateurgrid.SelectedRows[0].Cells[2].Value.ToString().Trim(new char[] { ' ' });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void printinvbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                view v = new view();
                facture_dataset ds = new facture_dataset();
                string sql = "select  Pro_Reference,Pro_Designation,UnitesEnStock,round(Prix_dachat,2) as Prix_dachat,round((UnitesEnStock * Prix_dachat),2) as total,c.Cat_Nom from Produit p,Categorie c where p.Cat_id=c.Cat_id and c.Cat_id='" + Utlisiateurgrid.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, Connexion.cnx);
                sqlData.Fill(ds.Tables["produit"]);
                PrintByCategory pc = new PrintByCategory();
                pc.SetDataSource(ds.Tables["produit"]);
                v.crystalReportViewer1.ReportSource = pc;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", "imprimé l'inventaire par categorie " + Utlisiateurgrid.SelectedRows[0].Cells[0].Value.ToString());
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                v.Show();
            }
            catch
            {
                MessageBox.Show("Choisir un Categorie");
            }
        }
    }
}
