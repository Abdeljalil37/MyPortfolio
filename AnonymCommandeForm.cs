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
    public partial class AnonymCommandeForm : Form
    {
        float montant = 0;
        int cpt = -1, i;
        facture_dataset ds = new facture_dataset();
        public AnonymCommandeForm()
        {
            InitializeComponent();
        }

        private void AnonymCommandeForm_Load(object sender, EventArgs e)
        {
            try { 
            FournisseurList();
            productlist();
            bunifuTextBox1.Clear();
            bunifuTextBox3.Clear();
            totaltxtbox.Text = montant + " MAD";
            Connexion.dt.Columns.Add("Pro_Reference");
            Connexion.dt.Columns.Add("Pro_Designation");
            Connexion.dt.Columns.Add("Ent_qte");
            Connexion.dt.Columns.Add("Ent_PU");
            Connexion.dt.Columns.Add("Ent_total");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void productlist()
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.CommandText = "select Pro_id,Pro_Reference from Produit";
                SqlDataReader drpro = Connexion.cmd.ExecuteReader();
                DataTable dtpro = new DataTable();
                dtpro.Load(drpro);
                comboBox1.DataSource = dtpro;
                comboBox1.DisplayMember = "Pro_Reference";
                comboBox1.ValueMember = "Pro_id";
                drpro.Close();
                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBox1.Text = "";
                Connexion.deconnecter();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select Pro_Designation from Produit where Pro_Reference=@id ";
                Connexion.cmd.Parameters.AddWithValue("id", comboBox1.Text);
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    bunifuTextBox1.Text = dr[0].ToString();
                }
                dr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select Pro_Designation from Produit where Pro_Reference=@id ";
                Connexion.cmd.Parameters.AddWithValue("id", comboBox1.Text);
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    bunifuTextBox1.Text = dr[0].ToString();
                }
                dr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FournisseurList()
        {
            try {
                Connexion.connecter();
            Connexion.cmd.CommandText = "select Four_id,Four_Nom from Fournisseur";
            SqlDataReader drfour = Connexion.cmd.ExecuteReader();
            DataTable dtfour = new DataTable();
            dtfour.Load(drfour);
            fourcombox.DataSource = dtfour;
            fourcombox.DisplayMember = "Four_Nom";
            fourcombox.ValueMember = "Four_id";
            drfour.Close();
            fourcombox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            fourcombox.AutoCompleteSource = AutoCompleteSource.ListItems;
            fourcombox.Text = "";
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void fourcombox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select Four_Details from Fournisseur where Four_Nom=@id";
                Connexion.cmd.Parameters.AddWithValue("id", fourcombox.Text);
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    bunifuTextBox3.Text = dr[0].ToString();
                }
                dr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fourcombox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select Four_Details from Fournisseur where Four_Nom=@id";
                Connexion.cmd.Parameters.AddWithValue("id", fourcombox.Text);
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    bunifuTextBox3.Text = dr[0].ToString();
                }
                dr.Close();
                Connexion.deconnecter();
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

        private void ajouterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                montant = montant + float.Parse(newqtetxtb.Text) * float.Parse(prixtxtb.Text);
                totaltxtbox.Text = Math.Round(montant, 2) + " MAD";
                DataRow ligne;
                ligne = ds.Tables["stock"].NewRow();
                ligne["Ent_id"] = "BC " + cmdidtxtb.Text;
                ligne["Ent_Date"] = dateTimePicker1.Value.ToString();
                ligne["Four_Nom"] = fourcombox.Text;
                ligne["montant"] = totaltxtbox.Text;
                ligne["Pro_Reference"] = comboBox1.Text;
                ligne["Pro_Designation"] = bunifuTextBox1.Text;
                ligne["Ent_qte"] = newqtetxtb.Text;
                ligne["Four_Details"] = bunifuTextBox3.Text;
                ligne["Ent_PU"] = prixtxtb.Text;
                ligne["Ent_total"] = float.Parse(newqtetxtb.Text) * float.Parse(prixtxtb.Text);
                ligne["TVA"] = Math.Round(montant / 1.2 * 0.2, 2) + " MAD";
                ligne["HT"] = Math.Round(montant - montant / 1.2 * 0.2, 2) + " MAD";
                ds.Tables["stock"].Rows.Add(ligne);
                Connexion.dt.Rows.Add(comboBox1.Text, bunifuTextBox1.Text, newqtetxtb.Text, prixtxtb.Text, float.Parse(newqtetxtb.Text) * float.Parse(prixtxtb.Text));
                bunifuDataGridView1.DataSource = Connexion.dt;
                bunifuDataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viderbtn_Click(object sender, EventArgs e)
        {
            try { 
            comboBox1.Text=String.Empty;
            bunifuTextBox1.Text = String.Empty;
            newqtetxtb.Clear();
            prixtxtb.Clear();
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
                for (i = 0; i < ds.Tables["stock"].Rows.Count; i++)
                {
                    if (comboBox1.Text == ds.Tables["stock"].Rows[i][3].ToString())
                    {
                        cpt = i;
                        break;
                    }
                }
                ds.Tables["stock"].Rows[cpt].Delete();
                Connexion.dt.Rows[cpt].Delete();
                cpt = -1;
                bunifuDataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuDataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBox1.Text = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                bunifuTextBox1.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim(new char[] { ' ' });
                newqtetxtb.Text = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim(new char[] { ' ' });
                prixtxtb.Text = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim(new char[] { ' ' });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printblbtn_Click(object sender, EventArgs e)
        {
            
                try
                {
                    view v = new view();
                    boncommande bc = new boncommande();
                    bc.SetDataSource(ds.Tables["stock"]);
                    v.crystalReportViewer1.ReportSource = bc;
                    v.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

    }
}
