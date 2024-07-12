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
   
    public partial class NewStockForm : Form
    {

        public string cin;
        public string role;
        string id;
        public NewStockForm()
        {
            InitializeComponent();
        }

        private void NewStockForm_Load(object sender, EventArgs e)
        {
            try
            {

            FournisseurList();
                ProductsName();
                rempliregrid();
                prixlbl.Text = "Prix Recent";
                label2.Text = "Prix Recent";
                label8.Text = "Quantité";
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
                Connexion.adapter = new SqlDataAdapter(@"select Ent_id,s.Pro_id,Pro_Reference,Pro_Designation,c.Cat_Nom,s.QTE,round(s.prix_dachat,2) as prix_dachat,round(s.prix_vente,2) as prix_vente,p.Pro_Description,f.Four_Nom,ROUND(Taxe,2) as Taxe,Ent_Date,montant from Stock s,Produit p,Fournisseur f,Categorie c 
                                                        where s.Pro_id=p.Pro_id and f.Four_id=s.Four_id and p.Cat_id=c.Cat_id", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                prodgrid.DataSource = Connexion.dt;
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Anonym_Click(object sender, EventArgs e)
        {
            try { 
            AnonymCommandeForm acf = new AnonymCommandeForm();
            acf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ProductsName()
        {

            try { 
                Connexion.connecter();
                Connexion.cmd.CommandText = "select Pro_id,Pro_Designation  from Produit";
                SqlDataReader drpro = Connexion.cmd.ExecuteReader();
                DataTable dtpro = new DataTable();
                dtpro.Load(drpro);     
                prodcombox.DataSource = dtpro;
                prodcombox.DisplayMember = "Pro_Designation";
                prodcombox.ValueMember = "Pro_id";
            drpro.Close();
            prodcombox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                prodcombox.AutoCompleteSource = AutoCompleteSource.ListItems;
                prodcombox.Text = "";
            Connexion.deconnecter();
            /*Connexion.cmd.Parameters.Clear();
            Connexion.cmd.CommandText = "select Prix_dachat,Prix_Vente from Produit where Pro_Designation=@pro_id";
            Connexion.cmd.Parameters.AddWithValue("pro_id", prodcombox.Text);
            SqlDataReader dr = Connexion.cmd.ExecuteReader();
            if (dr.Read())
            {
                prixlbl.Text = dr[0].ToString();
                label2.Text = dr[1].ToString();
            }
            dr.Close();
        */
        }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
}
        private void FournisseurList()
        {
            try
            {
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

        private void ajouterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into Stock values(@four_id,@util_id,@entdate,@pro_id,@pa,@pv,@qte,@montant)";
                Connexion.cmd.Parameters.AddWithValue("entdate", dateTimePicker1.Value);
                Connexion.cmd.Parameters.AddWithValue("four_id", fourcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("pro_id", prodcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("qte", int.Parse(newqtetxtb.Text));
                Connexion.cmd.Parameters.AddWithValue("pa", Math.Round(float.Parse(prixtxtb.Text),2));
                Connexion.cmd.Parameters.AddWithValue("pv", Math.Round(float.Parse(bunifuTextBox1.Text),2));
                Connexion.cmd.Parameters.AddWithValue("montant",Math.Round( (int.Parse(newqtetxtb.Text) * float.Parse(prixtxtb.Text)),2));
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.ExecuteNonQuery();

                Connexion.cmd.CommandText = "update Produit set UnitesEnStock=UnitesEnStock+@qte,Prix_dachat=@pa,Prix_Vente=@pv,taxe=(@pa/1.2*0.2),Four_id=@four_id where Pro_id=@pro_id";
                Connexion.cmd.ExecuteNonQuery();

                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                Connexion.cmd.Parameters.AddWithValue("operation", " ajouté le Stock " + prodcombox.Text);
                Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                MessageBox.Show("Une nouvelle quantité été ajoutée");
                rempliregrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void prodcombox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { 
                Connexion.connecter();
            Connexion.cmd.Parameters.Clear();
            Connexion.cmd.CommandText = "select Prix_dachat,Prix_Vente,UnitesEnStock from Produit where Pro_Designation=@pro_id";
            Connexion.cmd.Parameters.AddWithValue("pro_id", prodcombox.Text);
            SqlDataReader dr = Connexion.cmd.ExecuteReader();
            if (dr.Read())
            {
                prixlbl.Text = dr[0].ToString();
                label2.Text = dr[1].ToString();
                    label8.Text = dr[2].ToString();
                   
            }
            dr.Close();
            Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cherchetxtb_TextChange(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = Connexion.dt;
                bs.Filter = "[Pro_Reference] like '%" + cherchetxtb.Text + "%' or [Pro_Designation] like '%" + cherchetxtb.Text + "%' or [Pro_Description] like '%" + cherchetxtb.Text + "%' or [Cat_Nom] like '%" + cherchetxtb.Text + "%' or [Four_Nom] like '%" + cherchetxtb.Text + "%'";
                prodgrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viderbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //id = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                prodcombox.Text = prodgrid.SelectedRows[0].Cells[2].Value.ToString();
                newqtetxtb.Text = prodgrid.SelectedRows[0].Cells[3].Value.ToString().Trim(new char[] { ' ' });
                prixtxtb.Text = prodgrid.SelectedRows[0].Cells[4].Value.ToString().Trim(new char[] { ' ' });
                dateTimePicker1.Value = DateTime.Now;
                fourcombox.Text = "";
                prodcombox.Text = "";
                newqtetxtb.Clear();
                prixtxtb.Clear();
                bunifuTextBox1.Clear();
                prixlbl.Text = "Prix Recent";
                label2.Text = "Prix Recent";
            }
            catch(Exception ex)
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
                    Connexion.cmd.CommandText = "delete from Stock where Ent_id=@id";
                    Connexion.cmd.Parameters.AddWithValue("id", prodgrid.SelectedRows[0].Cells[0].Value);
                    Connexion.cmd.Parameters.AddWithValue("pro_id", prodcombox.SelectedValue);
                    Connexion.cmd.Parameters.AddWithValue("qte", newqtetxtb.Text);
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.ExecuteNonQuery();

                    Connexion.cmd.CommandText = "update Produit set UnitesEnStock=UnitesEnStock-@qte,Prix_dachat=(select top 1 prix_dachat from Stock where Pro_id=@pro_id order by Ent_Date DESC),Prix_Vente=(select top 1 Prix_Vente from Stock where Pro_id=@pro_id order by Ent_Date DESC),taxe=(select top 1 ROUND(prix_dachat/1.2*0.2,2) from Stock where Pro_id=1009 order by Ent_Date DESC),Four_id=(select top 1 Four_id from Stock where Pro_id=@pro_id order by Ent_Date DESC) where Pro_id=@pro_id";
                    Connexion.cmd.ExecuteNonQuery();

                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                    Connexion.cmd.Parameters.AddWithValue("operation", " supprimer le Stock " + prodcombox.Text);
                    Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("Supprimer La Nouvelle Quantité ");
                    rempliregrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
           
        }

        private void prodgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            id = prodgrid.SelectedRows[0].Cells[0].Value.ToString();
            prodcombox.Text = prodgrid.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = prodgrid.SelectedRows[0].Cells[11].Value.ToString();
            fourcombox.Text = prodgrid.SelectedRows[0].Cells[9].Value.ToString();
            newqtetxtb.Text = prodgrid.SelectedRows[0].Cells[5].Value.ToString();
            prixtxtb.Text = prodgrid.SelectedRows[0].Cells[6].Value.ToString();
            bunifuTextBox1.Text = prodgrid.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prodcombox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select Prix_dachat,Prix_Vente,UnitesEnStock from Produit where Pro_Designation=@pro_id";
                Connexion.cmd.Parameters.AddWithValue("pro_id", prodcombox.Text);
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    prixlbl.Text = dr[0].ToString();
                    label2.Text = dr[1].ToString();
                    label8.Text = dr[2].ToString();
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
