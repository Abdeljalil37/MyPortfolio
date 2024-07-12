using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Younes_Entreprise
{
    public partial class CreateUserForm : Form
    {
        public string cin;
        public string role;
        public CreateUserForm()
        {
            InitializeComponent();
        }
        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void viderbtn_Click(object sender, EventArgs e)
        {
            try { 
            cintxtbox.Clear();
            nomtxtbox.Clear();
            prenomtxtbox.Clear();
            phonetxtbox.Clear();
            adressetxtbox.Clear();
            emailtxtbox.Clear();
            pswtxtbox.Clear();
            detailstxtbox.Clear();
            rolecombox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showpswbtn_Click(object sender, EventArgs e)
        {
            try { 
            if (pswtxtbox.UseSystemPasswordChar == true)
            {
                pswtxtbox.UseSystemPasswordChar = false;
                pswtxtbox.PasswordChar = '\0';
                showpswbtn.BackgroundImage = Properties.Resources.invisible_30px;
            }
            else if (pswtxtbox.UseSystemPasswordChar == false)
            {
                pswtxtbox.UseSystemPasswordChar = true;
                showpswbtn.BackgroundImage = Properties.Resources.eye_24px ;
            }
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
                Connexion.cmd.CommandText = "select COUNT(*) from Utilisateur where Util_id=@id";
                Connexion.cmd.Parameters.AddWithValue("id", cintxtbox.Text.Trim(new char[] { ' ' }));
                num = (int)Connexion.cmd.ExecuteScalar();
                if (num > 0)
                {
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "update Utilisateur set Util_Nom=@nom,Util_Prenom=@prenom,Util_Phone=@tel,Util_Adresse=@adresse,Util_Email=@email,Util_psw=@psw,Util_Details=@details,Role=@role where Util_id=@cin";
                    Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("nom", nomtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("prenom", prenomtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("tel", phonetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("adresse", adressetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("email", emailtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("psw", pswtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("details", detailstxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("role", rolecombox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " Il a modifié les données du Utilisateur " + cintxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("Les données d'utilisateur " + cintxtbox.Text + " sont modifiée");
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de tel Utilisateur");
                }
                Connexion.deconnecter();
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
                Connexion.cmd.CommandText = "  insert into Utilisateur(Util_id,Util_Nom,Util_Prenom,Util_Phone,Util_Adresse,Util_Email,Util_psw,Util_Details,Role) values(@cin,@nom,@prenom,@tel,@adresse,@email,@psw,@details,@role)";
                Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("nom", nomtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("prenom", prenomtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("tel", phonetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("adresse", adressetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("email", emailtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("psw", pswtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("details", detailstxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("role", rolecombox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", " Il a ajouté l'Utilisateur " + cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                MessageBox.Show("L'utilisateur " + cintxtbox.Text + " est ajouté");
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
                Connexion.cmd.CommandText = "select * from Utilisateur where Util_id=@id";
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    nomtxtbox.Text = dr[1].ToString();
                    prenomtxtbox.Text = dr[2].ToString();
                    phonetxtbox.Text = dr[3].ToString();
                    adressetxtbox.Text = dr[4].ToString();
                    emailtxtbox.Text = dr[5].ToString();
                    pswtxtbox.Text = dr[6].ToString();
                    detailstxtbox.Text = dr[7].ToString();
                    rolecombox.Text = dr[9].ToString();
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
