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
    public partial class UtilisateurGridviewForm : Form
    {

        public string cin;
        public string role;
        public UtilisateurGridviewForm()
        {
            InitializeComponent();
        }
        private void UtilisateurGridviewForm_Load(object sender, EventArgs e)
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
                Connexion.adapter = new SqlDataAdapter(@"select trim(Util_id) as Util_id,trim(Util_Nom)as Util_Nom,trim(Util_Prenom)as Util_Prenom,trim(Util_Phone)as Util_Phone,trim(Util_Adresse)as Util_Adresse,trim(Util_Email)as Util_Email,trim(Util_Details)as Util_Details,trim(Role)as Role 
                                                         from Utilisateur", Connexion.cnx);
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

        private void supprimerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.connecter();
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "delete from Utilisateur where Util_id=@id";
                    Connexion.cmd.Parameters.AddWithValue("@id", Utlisiateurgrid.SelectedRows[0].Cells[0].Value.ToString());
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " Il a supprimé l'Utilisateur " + Utlisiateurgrid.SelectedRows[0].Cells[0].Value.ToString());
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("L'utilisateur est supprimé");
                    rempliredatagrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cintxtbox_TextChange(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Util_id] like '%" + cintxtbox.Text + "%' or [Util_Nom] like '%" + cintxtbox.Text + "%' or [Util_Prenom] like '%" + cintxtbox.Text + "%'";
            Utlisiateurgrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
