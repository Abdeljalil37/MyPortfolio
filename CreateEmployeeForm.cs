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
    public partial class CreateEmplyeeForm : Form
    {
        public string cin;
        public string role;
        public CreateEmplyeeForm()
        {
            InitializeComponent();
        }

        private void CreateEmplyeeForm_Load(object sender, EventArgs e)
        {

        }

        private void viderbtn_Click(object sender, EventArgs e)
        {
            try { 
            cintxtbox.Clear();
            nomtxtbox.Clear();
            phonetxtbox.Clear();
            adressetxtbox.Clear();
            emailtxtbox.Clear();
            salairetxtbox.Clear();
            detailstxtbox.Clear();
            typecombox.SelectedIndex = 0;
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
                Connexion.cmd.CommandText = "insert into Employee values(@cin,@nom,@tel,@adresse,@email,@depar,@date,@salaire,@details)";
                Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("nom", nomtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("tel", phonetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("adresse", adressetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("email", emailtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("depar", typecombox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("details", detailstxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("salaire", salairetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now.ToString().Trim(new char[] { ' ' }));
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", "  ajouté  l'Employé " + cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                MessageBox.Show("L'employé " + cintxtbox.Text+ "est ajouté " );
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
                int num;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select COUNT(*) from Employee where Emp_id=@id";
                Connexion.cmd.Parameters.AddWithValue("id", cintxtbox.Text.Trim(new char[] { ' ' }));
                num = (int)Connexion.cmd.ExecuteScalar();
                if (num > 0)
                {
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "update Employee set Emp_Nom=@nom,Emp_Phone=@tel,Emp_Adresse=@adresse,Emp_Email=@email,Emp_Departement=@depar,Emp_Salaire=@salaire,Emp_Details=@details where Emp_id=@cin";
                    Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("nom", nomtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("tel", phonetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("adresse", adressetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("email", emailtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("depar", typecombox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("details", detailstxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("salaire", salairetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " modifié les données d'Employé " + cintxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("Les données d'employés " + cintxtbox.Text + " sont modifiée ");
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de tel Employée");
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
                Connexion.cmd.CommandText = "select * from Employee where Emp_id=@id";
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    nomtxtbox.Text = dr[1].ToString();
                    phonetxtbox.Text = dr[2].ToString();
                    adressetxtbox.Text = dr[3].ToString();
                    emailtxtbox.Text = dr[4].ToString();
                    typecombox.Text = dr[5].ToString();
                    detailstxtbox.Text = dr[8].ToString();
                    salairetxtbox.Text = dr[7].ToString();
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
