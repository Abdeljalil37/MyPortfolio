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
    public partial class PaymentEmpForm : Form
    {

        string id;
        public string cin;
        public string role;
        public PaymentEmpForm()
        {
            InitializeComponent();
        }
        private void PaymentEmpForm_Load(object sender, EventArgs e)
        {
            try { 
            comboemp();

            rempliregrid();
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
                Connexion.cmd.CommandText = "insert into Employee_Payment values(@emp_id,@util_id,@date,@montant,@method)";
                Connexion.cmd.Parameters.AddWithValue("emp_id", clientcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("date", dateTimePicker1.Value.ToString());
                Connexion.cmd.Parameters.AddWithValue("montant", bunifuTextBox1.Text);
                Connexion.cmd.Parameters.AddWithValue("method", comboBox1.Text);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("operation", " ajouté un Payment d'Employé " + clientcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                MessageBox.Show("Le paiement a été effectué ");
                rempliregrid();
                vider();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void rempliregrid()
        {

            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select em.Pay_id,trim(e.Emp_Nom)as Emp_Nom,Pay_Date,TRIM(TRIM(Util_Nom)+' '+trim(Util_Prenom)) as Util_Nom,Pay_Montant,Pay_Method  
                                                        from Employee_Payment em,Employee e,Utilisateur u where u.Util_id=em.Util_id and em.Emp_id=e.Emp_id", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                paymentgrid.DataSource = Connexion.dt;
                Connexion.deconnecter();
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
            clientcombox.DataSource = dt;
            clientcombox.DisplayMember = "Emp_Nom";
            clientcombox.ValueMember = "Emp_id";
            dr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viderbtn_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void vider()
        {
            try { 
            clientcombox.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            bunifuTextBox1.Clear();
            comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "update Employee_Payment set Emp_id=@emp_id,Pay_Date=@date,Pay_Montant=@montant,Pay_Method=@method where Pay_id=@id";
                Connexion.cmd.Parameters.AddWithValue("id", paymentgrid.SelectedRows[0].Cells[0].Value.ToString());
                Connexion.cmd.Parameters.AddWithValue("emp_id", clientcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("date", dateTimePicker1.Value.ToString());
                Connexion.cmd.Parameters.AddWithValue("montant", bunifuTextBox1.Text);
                Connexion.cmd.Parameters.AddWithValue("method", comboBox1.Text);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("operation", " modifié les données d'un Payment d'Employé " + clientcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                MessageBox.Show("Le paiement a été modifié ");
                rempliregrid();
       
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
                    Connexion.cmd.CommandText = "delete from Employee_Payment where Pay_id=@id";
                    Connexion.cmd.Parameters.AddWithValue("id", paymentgrid.SelectedRows[0].Cells[0].Value.ToString());
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", "supprimé un Payment d'Employé " + paymentgrid.SelectedRows[0].Cells[1].Value.ToString());
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("Le paiement a été supprimé ");
                    rempliregrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Emp_Nom] like '%" + bunifuTextBox2.Text + "%' ";
            paymentgrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void paymentgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            id = paymentgrid.SelectedRows[0].Cells[0].Value.ToString();
            clientcombox.Text = paymentgrid.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = paymentgrid.SelectedRows[0].Cells[2].Value.ToString();
            bunifuTextBox1.Text = paymentgrid.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.Text = paymentgrid.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
