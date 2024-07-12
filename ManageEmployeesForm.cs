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
    public partial class ManageEmployeesForm : Form
    {

        string id;
        public string cin;
        public string role;
        public ManageEmployeesForm()
        {
            InitializeComponent();
        }
        private void ManageEmployeesForm_Load(object sender, EventArgs e)
        {
            try { 
            comboemp();
            gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try {
                Connexion.connecter();
            Connexion.cmd.Parameters.Clear();
            Connexion.cmd.CommandText = "insert into Employee_Details values(@emp_id,@Emp_Date,@Heure_Arv,@Heure_Sor,@Hors_Serv,@En_Serv,@util_id,@Emp_Presence,@Emp_Retard,@Emp_CauseRetard)";
            Connexion.cmd.Parameters.AddWithValue("emp_id",comboBox1.SelectedValue);
            Connexion.cmd.Parameters.AddWithValue("Emp_Date", dateTimePicker2.Value);
            Connexion.cmd.Parameters.AddWithValue("Heure_Arv", dateTimePicker4.Text);
            Connexion.cmd.Parameters.AddWithValue("Heure_Sor", dateTimePicker5.Text);
            Connexion.cmd.Parameters.AddWithValue("Hors_Serv", dateTimePicker1.Value);
            Connexion.cmd.Parameters.AddWithValue("En_Serv", dateTimePicker3.Value);
            Connexion.cmd.Parameters.AddWithValue("Emp_Presence", bunifuTextBox4.Text);
            Connexion.cmd.Parameters.AddWithValue("Emp_Retard", bunifuTextBox3.Text);
            Connexion.cmd.Parameters.AddWithValue("Emp_CauseRetard", detailstxtbox.Text);
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("operation", "  ajouté Employé Details de " + comboBox1.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                MessageBox.Show("La présence d'employé est Ajoutée");
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gridview();
            vider();
        }

        private void viderbtn_Click(object sender, EventArgs e)
        {
            try { 
            vider();
                gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vider()
        {
            try { 
            id = null;
            comboBox1.Text =String.Empty ;
            comboBox2.Text = String.Empty;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            dateTimePicker5.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            bunifuTextBox4.Clear();
            bunifuTextBox3.Clear();
            detailstxtbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifierbtn_Click(object sender, EventArgs e)
        {
            try {
                Connexion.connecter();
            Connexion.cmd.Parameters.Clear();
            Connexion.cmd.CommandText = "update Employee_Details set Emp_id=@emp_id,Emp_Date=@Emp_Date,Heure_Arv=@Heure_Arv,Heure_Sor=@Heure_Sor,Hors_Serv=@Hors_Serv,En_Serv=@En_Serv,Util_id=@Util_id,Emp_Presence=@Emp_Presence,Emp_Retard=@Emp_Retard,Emp_CauseRetard=@Emp_CauseRetard where Emp_Num=@Emp_Num";
            Connexion.cmd.Parameters.AddWithValue("Emp_Num", Utlisiateurgrid.SelectedRows[0].Cells[0].Value.ToString());
            Connexion.cmd.Parameters.AddWithValue("emp_id", comboBox1.SelectedValue);
            Connexion.cmd.Parameters.AddWithValue("Emp_Date", dateTimePicker2.Value);
            Connexion.cmd.Parameters.AddWithValue("Heure_Arv", dateTimePicker4.Text);
            Connexion.cmd.Parameters.AddWithValue("Heure_Sor", dateTimePicker5.Text);
            Connexion.cmd.Parameters.AddWithValue("Hors_Serv", dateTimePicker1.Value);
            Connexion.cmd.Parameters.AddWithValue("En_Serv", dateTimePicker3.Value);
            Connexion.cmd.Parameters.AddWithValue("Emp_Presence", bunifuTextBox4.Text);
            Connexion.cmd.Parameters.AddWithValue("Emp_Retard", bunifuTextBox3.Text);
            Connexion.cmd.Parameters.AddWithValue("Emp_CauseRetard", detailstxtbox.Text);
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("operation", " modifié les données d'employé Details de " + comboBox1.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                MessageBox.Show("La présence d'employé est Modifiée");
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gridview();
            
        }

        private void supprimerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer ?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.connecter();
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = " delete from  Employee_Details where Emp_Num=@Emp_Num";
                    Connexion.cmd.Parameters.AddWithValue("Emp_Num", Utlisiateurgrid.SelectedRows[0].Cells[0].Value.ToString());
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", "  supprimé Employé Details de " + Utlisiateurgrid.SelectedRows[0].Cells[1].Value.ToString());
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("La présence d'employé est suprimée ");
                    Connexion.deconnecter();
                }
                gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }



        private void comboemp()
        {
            try {
                Connexion.connecter();
            DataTable dt = new DataTable();
            Connexion.cmd.CommandText = "select Emp_id,trim(Emp_Nom)as Emp_Nom from Employee";
            SqlDataReader dr = Connexion.cmd.ExecuteReader();
            dt.Load(dr);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Emp_Nom";
            comboBox1.ValueMember = "Emp_id";
            dr.Close();



            Connexion.cmd.CommandText = "select Emp_id,trim(Emp_Nom)as Emp_Nom from Employee";
            SqlDataReader drr = Connexion.cmd.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr[1].ToString());
            }
            drr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gridview()
        {
            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select Emp_Num,trim(e.Emp_Nom) as Emp_Nom,Emp_Date,Heure_Arv,Heure_Sor,Hors_Serv,En_Serv,TRIM(TRIM(Util_Nom)+' '+trim(Util_Prenom)) as Util_Nom,Emp_Presence,Emp_Retard,Emp_CauseRetard from Employee_Details em,Employee e,Utilisateur u 
                                                        where u.Util_id=em.Util_id and em.Emp_id=e.Emp_id", Connexion.cnx);
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

        private void Utlisiateurgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            id = Utlisiateurgrid.SelectedRows[0].Cells[0].Value.ToString().Trim(new char[] { ' ' });
            comboBox1.Text = Utlisiateurgrid.SelectedRows[0].Cells[1].Value.ToString().Trim(new char[] { ' ' });
            dateTimePicker2.Text = Utlisiateurgrid.SelectedRows[0].Cells[2].Value.ToString().Trim(new char[] { ' ' });
            dateTimePicker4.Text = Utlisiateurgrid.SelectedRows[0].Cells[3].Value.ToString().Trim(new char[] { ' ' });
            dateTimePicker5.Text = Utlisiateurgrid.SelectedRows[0].Cells[4].Value.ToString().Trim(new char[] { ' ' });
            dateTimePicker1.Text = Utlisiateurgrid.SelectedRows[0].Cells[5].Value.ToString().Trim(new char[] { ' ' });
            dateTimePicker3.Text = Utlisiateurgrid.SelectedRows[0].Cells[6].Value.ToString().Trim(new char[] { ' ' });
            bunifuTextBox4.Text = Utlisiateurgrid.SelectedRows[0].Cells[8].Value.ToString().Trim(new char[] { ' ' });
            bunifuTextBox3.Text = Utlisiateurgrid.SelectedRows[0].Cells[9].Value.ToString().Trim(new char[] { ' ' });
            detailstxtbox.Text = Utlisiateurgrid.SelectedRows[0].Cells[10].Value.ToString().Trim(new char[] { ' ' });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Emp_Nom] like '" + comboBox2.Text + "' ";
            Utlisiateurgrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
