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
    public partial class ManageEmpGridviewForm : Form
    {

        public string cin;
        public string role;
        public ManageEmpGridviewForm()
        {
            InitializeComponent();
        }

        private void ManageEmpGridviewForm_Load(object sender, EventArgs e)
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
                Connexion.adapter = new SqlDataAdapter(@"select Emp_Num,ed.Emp_id,Emp_Nom,Emp_Date,(TRIM(u.Util_Nom)+' '+TRIM(u.Util_Prenom))as Util_Nom,Heure_Arv,Heure_Sor,Hors_Serv,En_Serv,Emp_Presence,Emp_Retard,Emp_CauseRetard from Employee_Details ed,Employee e,Utilisateur u 
                                                        where e.Emp_id=ed.Emp_id and u.Util_id=ed.Util_id", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                Empdetailgird.DataSource = Connexion.dt;
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void cherchedatebtn_Click(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Emp_Date]>='" + dateTimePicker5.Value + "' and [Emp_Date]<'" + dateTimePicker4.Value + "'";
            Empdetailgird.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cherchenombtn_Click(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Emp_Nom] like '%" + cherchtxt.Text + "%' and [Emp_Date]>='" + dateTimePicker5.Value + "' and [Emp_Date]<'" + dateTimePicker4.Value + "' ";
            Empdetailgird.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cherchtxt_TextChange(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Emp_Nom] like '%" + cherchtxt.Text + "%' ";
            Empdetailgird.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void absencebtn_Click(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Emp_Nom] like '%" + cherchtxt.Text + "%' and [Emp_Date]>='" + dateTimePicker5.Value + "' and [Emp_Date]<'" + dateTimePicker4.Value + "'and [Emp_Presence]='0'";
            Empdetailgird.DataSource = bs;
            int absence = int.Parse(Empdetailgird.RowCount.ToString());
            if (absence < 1)
            {
                bunifuTextBox5.Text = "0";
            }
            else
            {
                bunifuTextBox5.Text = absence.ToString();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
