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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connexionbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd = new SqlCommand(@"select * from Utilisateur where Util_id=@email and Util_psw=@motdepasse", Connexion.cnx);
                Connexion.cmd.Parameters.AddWithValue("email", usernametxt.Text);
                Connexion.cmd.Parameters.AddWithValue("motdepasse", pswtxtbox.Text);
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    MainForm mf = new MainForm();
                    //    form.label9.Text= dr[0].ToString().Trim(new char[] { ' ' });
                    mf.cin = dr[0].ToString().Trim(new char[] { ' ' });
                    //  ds.label1.Text= dr[0].ToString().Trim(new char[] { ' ' });
                    mf.role = dr[9].ToString().Trim(new char[] { ' ' });
                    mf.usernamelbl.Text = dr[1].ToString().Trim(new char[] { ' ' }) + " " + dr[2].ToString().Trim(new char[] { ' ' });
                    dr.Close();
                    mf.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Pseudo ou le mot de passe incorrecte");
                }
                Connexion.deconnecter();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void showpswbtn_Click(object sender, EventArgs e)
        {
            try { 
            if (pswtxtbox.UseSystemPasswordChar == true) {
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
    }
}
