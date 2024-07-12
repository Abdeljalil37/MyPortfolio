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
    public partial class CreateSupplierForm : Form
    {
        public string cin;
        public string role;
        public CreateSupplierForm()
        {
            InitializeComponent();
        }
        private void CreateSupplierForm_Load(object sender, EventArgs e)
        {
            try { 
            cinnumbrer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cinnumbrer()
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.CommandText = "select top 1 CAST(SUBSTRING(Four_id,2, 50) as int)+1 as id from Fournisseur order by id DESC";
                SqlDataReader drr = Connexion.cmd.ExecuteReader();
                if (drr.Read())
                {
                    cintxtbox.Text = "F" + drr[0].ToString();
                }
                else
                {
                    cintxtbox.Text = "F1";
                }
                drr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viderbtn_Click(object sender, EventArgs e)
        {
            try { 
            cintxtbox.Clear();
            nomtxtbox.Clear();
            phonetxtbox.Clear();
            adressetxtbox.Clear();
            emailtxtbox.Clear();
            villetxtb.Clear();
            detailstxtbox.Clear();
            phone3txt.Clear();
            phone2txt.Clear();
                cinnumbrer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
        private void ajouterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into Fournisseur values(@cin,@nom,@tel,@adresse,@email,@ville,@detail,@Four_Phone2,@Four_Phone3)";
                Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("nom", nomtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("tel", phonetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("adresse", adressetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("email", emailtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("ville", villetxtb.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("detail", detailstxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("Four_Phone2", phone2txt.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("Four_Phone3", phone3txt.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", " ajouté le Fournisseur " + cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                MessageBox.Show("Le Fournisseur " + cintxtbox.Text + " est ajouté ");
                cintxtbox.Clear();
                nomtxtbox.Clear();
                phonetxtbox.Clear();
                adressetxtbox.Clear();
                emailtxtbox.Clear();
                villetxtb.Clear();
                detailstxtbox.Clear();
                phone3txt.Clear();
                phone2txt.Clear();
                cinnumbrer();
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
                int num;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select COUNT(*) from Fournisseur where Four_id=@id";
                Connexion.cmd.Parameters.AddWithValue("id", cintxtbox.Text.Trim(new char[] { ' ' }));
                num = (int)Connexion.cmd.ExecuteScalar();
                if (num > 0)
                {
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "update Fournisseur set Four_Nom=@nom,Four_Phone=@tel,Four_Adresse=@adresse,Four_Phone2=@Four_Phone2,Four_Phone3=@Four_Phone3,Four_Email=@email,Four_Ville=@ville,Four_Details=@detail where Four_id=@cin";
                    Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("nom", nomtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("tel", phonetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("adresse", adressetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("email", emailtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("ville", villetxtb.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("detail", detailstxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("Four_Phone2", phone2txt.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("Four_Phone3", phone3txt.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", "modifié les données du Fournisseur " + cintxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("Les données du Fournisseur " + cintxtbox.Text + " sont modifiée");
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de tel Fournisseur");
                }
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cherchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.Parameters.AddWithValue("id", cintxtbox.Text);
                Connexion.cmd.CommandText = "select * from Fournisseur where Four_id=@id";
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    nomtxtbox.Text = dr[1].ToString();
                    phonetxtbox.Text = dr[2].ToString();
                    adressetxtbox.Text = dr[3].ToString();
                    emailtxtbox.Text = dr[4].ToString();
                    villetxtb.Text = dr[5].ToString();
                    detailstxtbox.Text = dr[6].ToString();
                    phone2txt.Text = dr[7].ToString();
                    phone3txt.Text = dr[8].ToString();
                }
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
