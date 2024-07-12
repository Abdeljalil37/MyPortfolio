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
    public partial class SupplierGridviewForm : Form
    {

        public string cin;
        public string role;
        public SupplierGridviewForm()
        {
            InitializeComponent();
        }

        private void SupplierGridviewForm_Load(object sender, EventArgs e)
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
                Connexion.adapter = new SqlDataAdapter(@"select * from Fournisseur", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                fourgrid.DataSource = Connexion.dt;
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cintxtbox_TextChanged(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Four_Nom] like '%" + cintxtbox.Text + "%' or [Four_id] like '%" + cintxtbox.Text + "%'";
            fourgrid.DataSource = bs;
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
                    Connexion.cmd.CommandText = "delete from Fournisseur where Four_id=@id";
                    Connexion.cmd.Parameters.AddWithValue("id", fourgrid.SelectedRows[0].Cells[0].Value.ToString().Trim(new char[] { ' ' }));
                    Connexion.cmd.ExecuteNonQuery();

                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " supprimé le Fournisseur " + fourgrid.SelectedRows[0].Cells[0].Value.ToString());
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("Le Fournisseur est supprimé");
                    rempliredatagrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void fourgrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                fourgrid.Rows[e.RowIndex].Height = 100;
                fourgrid.Rows[e.RowIndex].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            }
        }

        private void fourgrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                fourgrid.Rows[e.RowIndex].Height = 60;
                fourgrid.Rows[e.RowIndex].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            }
        }
    }
}
