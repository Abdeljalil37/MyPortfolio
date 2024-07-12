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
    public partial class UsersHistoryForm : Form
    {

        public UsersHistoryForm()
        {
            InitializeComponent();
        }

        private void UsersHistoryForm_Load(object sender, EventArgs e)
        {
            try { 
            rempliregrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rempliregrid()
        {
            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select * from operation_table", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                HistoryGrid.DataSource = Connexion.dt;
           //     HistoryGrid.Refresh();

                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chercherbtn_Click(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[date_oper]>'" + dateTimePicker1.Value + "' and [date_oper] <= '" + dateTimePicker2.Value + "'";
            HistoryGrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.connecter();
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "delete from operation_table where date_oper>@date1 and date_oper<=@date2";
                    Connexion.cmd.Parameters.AddWithValue("date1", dateTimePicker1.Value.ToString());
                    Connexion.cmd.Parameters.AddWithValue("date2", dateTimePicker2.Value.ToString());
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("L'historique est supprimé");
                    rempliregrid();
                    HistoryGrid.Refresh();
                }
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
                    Connexion.cmd.CommandText = "delete from operation_table where date_oper>@date1 and date_oper<=@date2";
                    Connexion.cmd.Parameters.AddWithValue("date1", dateTimePicker1.Value.ToString());
                    Connexion.cmd.Parameters.AddWithValue("date2", dateTimePicker2.Value.ToString());
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("L'historique est supprimé");
                    rempliregrid();
                    HistoryGrid.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
