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
    public partial class EmployeesGridviewForm : Form
    {
        public string cin;
        public string role;
        public EmployeesGridviewForm()
        {
            InitializeComponent();
        }

        private void EmployeesGridviewForm_Load(object sender, EventArgs e)
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
                Connexion.adapter = new SqlDataAdapter(@"select Emp_id,Emp_Nom,Emp_Phone,Emp_Adresse,Emp_Email,Emp_Departement,Emp_Salaire,Emp_Details from Employee", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                empgrid.DataSource = Connexion.dt;
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cherchetxtb_TextChange(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Emp_Nom] like '%" + cherchetxtb.Text + "%' or [Emp_id] like '%" + cherchetxtb.Text + "%'";
            empgrid.DataSource = bs;
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
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer ?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.connecter();
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "delete from Employee where Emp_id=@id";
                    Connexion.cmd.Parameters.AddWithValue("id", empgrid.SelectedRows[0].Cells[0].Value.ToString().Trim(new char[] { ' ' }));
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", "  supprimé  l'Employé " + empgrid.SelectedRows[0].Cells[0].Value.ToString());
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    rempliredatagrid();
                    MessageBox.Show("Les données d'Employé sont supprimmées");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
