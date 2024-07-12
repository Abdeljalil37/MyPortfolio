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
    public partial class ChangePasswordForm : Form
    {
        public string cin;
        public string role;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            try { 
            cintxtbox.Text = cin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showpswbtn_Click(object sender, EventArgs e)
        {
            try { 
            if (oldpswtxtbox.UseSystemPasswordChar == true)
            {
                oldpswtxtbox.UseSystemPasswordChar = false;
                oldpswtxtbox.PasswordChar = '\0';
                showpswbtn.BackgroundImage = Properties.Resources.invisible_30px;
            }
            else if (oldpswtxtbox.UseSystemPasswordChar == false)
            {
                oldpswtxtbox.UseSystemPasswordChar = true;
                showpswbtn.BackgroundImage = Properties.Resources.eye_24px;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showpswbtn2_Click(object sender, EventArgs e)
        {
            try { 
            if (newpswtxtbox.UseSystemPasswordChar == true)
            {
                newpswtxtbox.UseSystemPasswordChar = false;
                newpswtxtbox.PasswordChar = '\0';
                showpswbtn2.BackgroundImage = Properties.Resources.invisible_30px;
            }
            else if (newpswtxtbox.UseSystemPasswordChar == false)
            {
                newpswtxtbox.UseSystemPasswordChar = true;
                showpswbtn2.BackgroundImage = Properties.Resources.eye_24px ;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sauvgarderbtn_Click(object sender, EventArgs e)
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
                    Connexion.cmd.CommandText = "select Util_psw from Utilisateur where Util_id=@cin";
                    Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text);
                    SqlDataReader dr = Connexion.cmd.ExecuteReader();
                    dr.Read();
                    string ancienepasw = dr[0].ToString().Trim(new char[] { ' ' });
                    dr.Close();
                    if (oldpswtxtbox.Text.Equals(ancienepasw))
                    {
                        dr.Close();
                        if (newpswtxtbox.Text.Equals(cpswtxtbox.Text))
                        {
                            Connexion.cmd.CommandText = "update Utilisateur set Util_psw=@password where Util_id=@cin";
                            Connexion.cmd.Parameters.AddWithValue("password", newpswtxtbox.Text);
                            Connexion.cmd.ExecuteNonQuery();
                            MessageBox.Show("Le mot de passe est changé ");
                        }
                        else
                        {
                            MessageBox.Show("Le mot de passe ne correspond pas");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ancien mot de passe incorrect");
                    }
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


    }
}
