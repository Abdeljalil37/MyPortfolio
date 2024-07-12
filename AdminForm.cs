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
    public partial class AdminForm : Form
    {
        public string cin;
        public AdminForm()
        {
            InitializeComponent();
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select * from Utilisateur where Util_id=@cin";
                Connexion.cmd.Parameters.AddWithValue("cin", cin);
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    bunifuTextBox1.Text = dr[0].ToString().Trim(new char[] { ' ' });
                    bunifuTextBox2.Text = dr[1].ToString().Trim(new char[] { ' ' });
                    bunifuTextBox3.Text = dr[3].ToString().Trim(new char[] { ' ' });
                    bunifuTextBox4.Text = dr[2].ToString().Trim(new char[] { ' ' });
                    bunifuTextBox5.Text = dr[5].ToString().Trim(new char[] { ' ' });
                    bunifuTextBox6.Text = dr[4].ToString().Trim(new char[] { ' ' });
                    bunifuTextBox8.Text = dr[7].ToString().Trim(new char[] { ' ' });
                }
                dr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void sauvgardebtn_Click(object sender, EventArgs e)
        {
            try
            {                
                Connexion.connecter();
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "update Utilisateur set Util_Nom=@nom,Util_Prenom=@prenom,Util_Phone=@tel,Util_Adresse=@adresse,Util_Email=@email,Util_Details=@details where  Util_id=@cin";
                    Connexion.cmd.Parameters.AddWithValue("cin", bunifuTextBox1.Text);
                    Connexion.cmd.Parameters.AddWithValue("nom", bunifuTextBox2.Text);
                    Connexion.cmd.Parameters.AddWithValue("prenom", bunifuTextBox4.Text);
                    Connexion.cmd.Parameters.AddWithValue("tel", bunifuTextBox3.Text);
                    Connexion.cmd.Parameters.AddWithValue("adresse", bunifuTextBox6.Text);
                    Connexion.cmd.Parameters.AddWithValue("email", bunifuTextBox5.Text);
                    Connexion.cmd.Parameters.AddWithValue("details", bunifuTextBox8.Text);
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("Les données d'utilisateur sont modifiées ");
                    
                    bunifuTextBox2.ReadOnly = true;
                    bunifuTextBox3.ReadOnly = true;
                    bunifuTextBox4.ReadOnly = true;
                    bunifuTextBox5.ReadOnly = true;
                    bunifuTextBox6.ReadOnly = true;
                    bunifuTextBox8.ReadOnly = true;
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void modifierbtn_Click(object sender, EventArgs e)
        {
            try { 
            
            bunifuTextBox2.ReadOnly = false;
            bunifuTextBox3.ReadOnly = false;
            bunifuTextBox4.ReadOnly = false;
            bunifuTextBox5.ReadOnly = false;
            bunifuTextBox6.ReadOnly = false;
            bunifuTextBox8.ReadOnly = false;
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}


    }
}
