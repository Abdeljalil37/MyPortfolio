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
    public partial class ClientGridviewForm : Form
    {

        public string cin;
        public string role;

        public ClientGridviewForm()
        {
            InitializeComponent();
        }

        private void ClientGridviewForm_Load(object sender, EventArgs e)
        {
            try
            {

                rempliregridview();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void rempliregridview()
        {
            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select Cli_id,Cli_Nom,Cli_Phone,Cli_Adresse,Cli_Email,Date_Vidange,Cli_Type,Util_Nom,RC,ICE,PATENTE,ID_FISCAL,CNSS,detailcli from Client c,Utilisateur u 
                                                         where u.Util_id=c.Util_id order by CAST(SUBSTRING(Cli_id,3, 50) as int)+1 DESC", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                clientgrid.DataSource = Connexion.dt;
                Connexion.deconnecter();
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
                Connexion.connecter();
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer ?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "delete from Client where Cli_id=@cin";
                    Connexion.cmd.Parameters.AddWithValue("cin", clientgrid.SelectedRows[0].Cells[0].Value.ToString().Trim(new char[] { ' ' }));
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " supprimé le Client " + clientgrid.SelectedRows[0].Cells[1].Value.ToString().Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("Le Client " + clientgrid.SelectedRows[0].Cells[2].Value.ToString().Trim(new char[] { ' ' }) + " est supprimé ");
                    rempliregridview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cintxtbox_TextChange(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = Connexion.dt;
                bs.Filter = "[Cli_Nom] like '%" + cintxtbox.Text + "%' or [Util_Nom] like '%" + cintxtbox.Text + "%' or [Cli_id] like '%" + cintxtbox.Text + "%' or [Cli_Type] like '%" + cintxtbox.Text + "%'";
                clientgrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void clientgrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                clientgrid.Rows[e.RowIndex].Height = 100;
                clientgrid.Rows[e.RowIndex].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            }
        }

        private void clientgrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                clientgrid.Rows[e.RowIndex].Height = 60;
                clientgrid.Rows[e.RowIndex].DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            }
        }
    }
}
