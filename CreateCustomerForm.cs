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
    public partial class CreateCustomerForm : Form
    {
        public string cin;
        public string role;
        public CreateCustomerForm()
        {
            InitializeComponent();
        }

        private void CreateCustomerForm_Load(object sender, EventArgs e)
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
            try {
                Connexion.connecter();
                Connexion.cmd.CommandText = "select top 1 CAST(SUBSTRING(Cli_id,3, 50) as int)+1 as id from Client order by id DESC";
                SqlDataReader drr = Connexion.cmd.ExecuteReader();
                if (drr.Read())
                {
                    cintxtbox.Text = "CL" + drr[0].ToString();
                }
                else
                {
                    cintxtbox.Text = "CL1";
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
            typecombox.SelectedIndex = 0;
            cintxtbox.Clear();
            nomtxtbox.Text = String.Empty;
            phonetxtbox.Text = "";
            adressetxtbox.Text = "";
            emailtxtbox.Text = "";
            dateTimePicker1.Text = "";
            detailstxtbox.Text = "";
            bunifuTextBox1.Text = String.Empty;
            bunifuTextBox2.Text = String.Empty;
            bunifuTextBox3.Text = String.Empty;
            bunifuTextBox4.Text = String.Empty;
            bunifuTextBox5.Text = String.Empty;
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
                Connexion.cmd.CommandText = "insert into Client values(@cin,@nom,@tel,@adresse,@email,@type,@idutil,@detailcli,@rc,@ice,@patente,@fiscal,@cnss,@vidange)";
                Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("nom", nomtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("tel", phonetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("adresse", adressetxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("email", emailtxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("vidange", dateTimePicker1.Value);
                Connexion.cmd.Parameters.AddWithValue("type", typecombox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("detailcli", detailstxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("idutil", cin);
                Connexion.cmd.Parameters.AddWithValue("rc", bunifuTextBox4.Text);
                Connexion.cmd.Parameters.AddWithValue("ice", bunifuTextBox3.Text);
                Connexion.cmd.Parameters.AddWithValue("patente", bunifuTextBox2.Text);
                Connexion.cmd.Parameters.AddWithValue("fiscal", bunifuTextBox1.Text);
                Connexion.cmd.Parameters.AddWithValue("cnss", bunifuTextBox5.Text);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", " ajouté le Client " + cintxtbox.Text.Trim(new char[] { ' ' }));
                Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                MessageBox.Show("Le client " + cintxtbox.Text + " est ajouté ");

                typecombox.SelectedIndex = 0;
                cintxtbox.Clear();
                nomtxtbox.Text = String.Empty;
                phonetxtbox.Text = "";
                adressetxtbox.Text = "";
                emailtxtbox.Text = "";
                dateTimePicker1.Value =DateTime.Now;
                detailstxtbox.Text = "";
                bunifuTextBox1.Text = String.Empty;
                bunifuTextBox2.Text = String.Empty;
                bunifuTextBox3.Text = String.Empty;
                bunifuTextBox4.Text = String.Empty;
                bunifuTextBox5.Text = String.Empty;
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
                Connexion.cmd.CommandText = "select COUNT(*) from Client where Cli_id=@id";
                Connexion.cmd.Parameters.AddWithValue("id", cintxtbox.Text.Trim(new char[] { ' ' }));
                num = (int)Connexion.cmd.ExecuteScalar();
                if (num > 0)
                {
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "update Client set Cli_Nom=@nom,Cli_Phone=@tel,Cli_Adresse=@adresse,Cli_Email=@email,Date_Vidange=@vidange,Cli_Type=@type,Util_id=@idutil,detailcli=@detailcli,RC=@rc,ICE=@ice,PATENTE=@patente,ID_FISCAL=@fiscal,CNSS=@cnss where Cli_id=@cin";
                    Connexion.cmd.Parameters.AddWithValue("cin", cintxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("nom", nomtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("tel", phonetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("adresse", adressetxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("email", emailtxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("vidange", dateTimePicker1.Value);
                    Connexion.cmd.Parameters.AddWithValue("type", typecombox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("idutil", cin);
                    Connexion.cmd.Parameters.AddWithValue("detailcli", detailstxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("rc", bunifuTextBox4.Text);
                    Connexion.cmd.Parameters.AddWithValue("ice", bunifuTextBox3.Text);
                    Connexion.cmd.Parameters.AddWithValue("patente", bunifuTextBox2.Text);
                    Connexion.cmd.Parameters.AddWithValue("fiscal", bunifuTextBox1.Text);
                    Connexion.cmd.Parameters.AddWithValue("cnss", bunifuTextBox5.Text);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", "modifié les données du Client " + cintxtbox.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("Les données du Client " + cintxtbox.Text + " sont modifiée ");
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de tel Client");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void typecombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if(typecombox.Text.Equals("Societe"))
            {
                bunifuTextBox1.Enabled = true;
                bunifuTextBox2.Enabled = true;
                bunifuTextBox3.Enabled = true;
                bunifuTextBox4.Enabled = true;
                bunifuTextBox5.Enabled = true;
            }
            else
            {
                bunifuTextBox1.Enabled = false;
                bunifuTextBox2.Enabled = false;
                bunifuTextBox3.Enabled = false;
                bunifuTextBox4.Enabled = false;
                bunifuTextBox5.Enabled = false;
            }
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
                Connexion.cmd.CommandText = "select * from Client where Cli_id=@id";
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    nomtxtbox.Text = dr[1].ToString();
                    phonetxtbox.Text = dr[2].ToString();
                    adressetxtbox.Text = dr[3].ToString();
                    emailtxtbox.Text = dr[4].ToString();
                    typecombox.Text = dr[5].ToString();           
                    detailstxtbox.Text = dr[7].ToString();
                    bunifuTextBox4.Text = dr[8].ToString();
                    bunifuTextBox3.Text = dr[9].ToString();
                    bunifuTextBox2.Text = dr[10].ToString();
                    bunifuTextBox1.Text = dr[11].ToString();
                    bunifuTextBox5.Text = dr[12].ToString();
                    dateTimePicker1.Text = dr[13].ToString();

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
