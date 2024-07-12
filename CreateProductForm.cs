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
    public partial class CreateProductForm : Form
    {
        public string cin;
        public string role;
        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {
            try { 
            CategoriesNames();
            SuplliersNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void CategoriesNames()
        {
            try {
                Connexion.connecter();
            Connexion.cmd.CommandText = "select Cat_id,TRIM(Cat_Nom)as Cat_Nom from Categorie";
            SqlDataReader drcat = Connexion.cmd.ExecuteReader();
            DataTable dtcat = new DataTable();
            dtcat.Load(drcat);
            catcombox.DataSource = dtcat;
            catcombox.DisplayMember = "Cat_Nom";
            catcombox.ValueMember = "Cat_id";
            drcat.Close();
                catcombox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                catcombox.AutoCompleteSource = AutoCompleteSource.ListItems;

                Connexion.cmd.CommandText = "select MAX(Pro_id)+1 from Produit";
            SqlDataReader drr = Connexion.cmd.ExecuteReader();
            if (drr.Read())
            {
                if (drr[0].ToString().Length > 0)
                {
                    bunifuTextBox1.Text = drr[0].ToString();
                }
                else
                {
                    bunifuTextBox1.Text = "1";
                }
            }
            drr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SuplliersNames()
        {
            try {
                Connexion.connecter();
                Connexion.cmd.CommandText = "select Four_id,Four_Nom as Four_Nom from Fournisseur";
            SqlDataReader drfor = Connexion.cmd.ExecuteReader();
            DataTable dtfor = new DataTable();
            dtfor.Load(drfor);
            fourcombox.DataSource = dtfor;
            fourcombox.DisplayMember = "Four_Nom";
            fourcombox.ValueMember = "Four_id";
            drfor.Close();
                fourcombox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                fourcombox.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            try
            {
                Connexion.connecter();
                reftxtb.Clear();
                desprotxtb.Clear();
                qtetxtb.Clear();
                prixatxtb.Clear();
                prixvtxtb.Clear();
                ttctxtb.Clear();
                detailstxtbox.Clear();
                catcombox.SelectedIndex = 0;
                fourcombox.SelectedIndex = 0;
                Connexion.cmd.CommandText = "select MAX(Pro_id)+1 from Produit";
                SqlDataReader drr = Connexion.cmd.ExecuteReader();
                if (drr.Read())
                {
                    if (drr[0].ToString().Length > 0)
                    {
                        bunifuTextBox1.Text = drr[0].ToString();
                    }
                    else
                    {
                        bunifuTextBox1.Text = "1";
                    }
                }
                drr.Close();
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
                Connexion.cmd.CommandText = "insert into Produit values(@Pro_Reference,@Pro_Designation,@UnitesEnStock,@Prix_dachat,@Prix_Vente,@taux,@Pro_Description,@Cat_id,@Four_id)";

                Connexion.cmd.Parameters.AddWithValue("Pro_Reference", reftxtb.Text);
                Connexion.cmd.Parameters.AddWithValue("Pro_Designation", desprotxtb.Text);
                Connexion.cmd.Parameters.AddWithValue("UnitesEnStock", qtetxtb.Text);
                Connexion.cmd.Parameters.AddWithValue("Prix_dachat", Math.Round(float.Parse(prixatxtb.Text), 2));
                Connexion.cmd.Parameters.AddWithValue("Prix_Vente", Math.Round(float.Parse(prixvtxtb.Text), 2));
                Connexion.cmd.Parameters.AddWithValue("taux", Math.Round(float.Parse(ttctxtb.Text), 2));
                Connexion.cmd.Parameters.AddWithValue("Pro_Description", detailstxtbox.Text);
                Connexion.cmd.Parameters.AddWithValue("Cat_id", catcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("Four_id", fourcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();


                /////
                Connexion.cmd.CommandText = "insert into Stock values(@Four_id,@util_id,@date,(select max(pro_id) from Produit),@Prix_dachat,@Prix_Vente,@UnitesEnStock,@montant)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("montant", float.Parse(qtetxtb.Text) * float.Parse(prixatxtb.Text));
                Connexion.cmd.ExecuteNonQuery();
                ////////
                MessageBox.Show("Le produit " + reftxtb.Text + " est ajouté");

                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("operation", " ajouté le Produit " + reftxtb.Text);
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                vider();
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
                Connexion.cmd.CommandText = "select COUNT(*) from Produit where Pro_id=@Pro_id";
                Connexion.cmd.Parameters.AddWithValue("Pro_id", bunifuTextBox1.Text.Trim(new char[] { ' ' }));
                num = (int)Connexion.cmd.ExecuteScalar();
                if (num > 0)
                {
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "update Produit set Pro_Reference=@Pro_Reference,Pro_Designation=@Pro_Designation,UnitesEnStock=@UnitesEnStock,Prix_dachat=@prixdachat,Prix_Vente=@prixvente,Taxe=@taxe,Pro_Description=@Pro_Description,Cat_id=@Cat_id,Four_id=@Four_id where Pro_id=@Pro_id";
                    Connexion.cmd.Parameters.AddWithValue("Pro_Reference", reftxtb.Text);
                    Connexion.cmd.Parameters.AddWithValue("Pro_id", bunifuTextBox1.Text);
                    Connexion.cmd.Parameters.AddWithValue("Pro_Designation", desprotxtb.Text);
                    Connexion.cmd.Parameters.AddWithValue("UnitesEnStock", qtetxtb.Text);
                    Connexion.cmd.Parameters.AddWithValue("prixdachat", Math.Round(float.Parse(prixatxtb.Text), 2));
                    Connexion.cmd.Parameters.AddWithValue("prixvente", Math.Round(float.Parse(prixvtxtb.Text), 2));
                    Connexion.cmd.Parameters.AddWithValue("taxe", Math.Round(float.Parse(ttctxtb.Text), 2));
                    Connexion.cmd.Parameters.AddWithValue("Pro_Description", detailstxtbox.Text);
                    Connexion.cmd.Parameters.AddWithValue("Cat_id", catcombox.SelectedValue);
                    Connexion.cmd.Parameters.AddWithValue("Four_id", fourcombox.SelectedValue);
                    Connexion.cmd.ExecuteNonQuery();

                    Connexion.cmd.CommandText = "update Stock set prix_dachat=@prixdachat,Prix_Vente=@prixvente,QTE=@UnitesEnStock,montant=@montant,Four_id=@Four_id where Ent_id=(select top 1 Ent_id from Stock where Pro_id=@Pro_id order by Ent_Date DESC)";
                    Connexion.cmd.Parameters.AddWithValue("montant", float.Parse(qtetxtb.Text) * float.Parse(prixatxtb.Text));
                    Connexion.cmd.ExecuteNonQuery();

                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " modification des données de Produit " + reftxtb.Text.Trim(new char[] { ' ' }));
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("Le produit " + reftxtb.Text + " est modifié ");
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de tel Produit");
                }
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /* try
             {
                 int num;
                 Connexion.cmd.Parameters.Clear();
                 Connexion.cmd.CommandText = "select COUNT(*) from Produit where Pro_id=@Pro_id";
                 Connexion.cmd.Parameters.AddWithValue("Pro_id", bunifuTextBox1.Text.Trim(new char[] { ' ' }));
                 num = (int)Connexion.cmd.ExecuteScalar();
                 if (num > 0)
                 {
                     Connexion.cmd.Parameters.Clear();
                     Connexion.cmd.CommandText = "update Produit set Pro_Reference=@Pro_Reference,Pro_Designation=@Pro_Designation,UnitesEnStock=@UnitesEnStock,Prix_dachat=@prixdachat,Prix_Vente=@prixvente,Taxe=@taxe,Pro_Description=@Pro_Description,Cat_id=@Cat_id,Four_id=@Four_id where Pro_id=@Pro_id";
                     Connexion.cmd.Parameters.AddWithValue("Pro_Reference", reftxtb.Text);
                     Connexion.cmd.Parameters.AddWithValue("Pro_id", bunifuTextBox1.Text);
                     Connexion.cmd.Parameters.AddWithValue("Pro_Designation", desprotxtb.Text);
                     Connexion.cmd.Parameters.AddWithValue("UnitesEnStock", qtetxtb.Text);
                     Connexion.cmd.Parameters.AddWithValue("prixdachat", float.Parse(prixatxtb.Text));
                     Connexion.cmd.Parameters.AddWithValue("prixvente", float.Parse(prixvtxtb.Text));
                     Connexion.cmd.Parameters.AddWithValue("taxe", float.Parse(ttctxtb.Text));
                     Connexion.cmd.Parameters.AddWithValue("Pro_Description", detailstxtbox.Text);
                     Connexion.cmd.Parameters.AddWithValue("Cat_id", catcombox.SelectedValue);
                     Connexion.cmd.Parameters.AddWithValue("Four_id", fourcombox.SelectedValue);
                     Connexion.cmd.ExecuteNonQuery();
                     Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                     Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                     Connexion.cmd.Parameters.AddWithValue("operation", " modification des données de Produit " + reftxtb.Text.Trim(new char[] { ' ' }));
                     Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                     Connexion.cmd.ExecuteNonQuery();
                     MessageBox.Show("Le produit " + reftxtb.Text + " est modifié ");
                 }
                 else
                 {
                     MessageBox.Show("Il n'y a pas de tel Produit");
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }

        private void prixatxtb_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (prixatxtb.Text.Length > 0)
                {
                    ttctxtb.Text = (Math.Round(float.Parse(prixatxtb.Text) / 1.2 * 0.2, 2)).ToString();
                }
                else
                {
                    ttctxtb.Text = "0";
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
                Connexion.cmd.Parameters.AddWithValue("id", bunifuTextBox1.Text);
                Connexion.cmd.CommandText = "select * from Produit where Pro_id=@id";
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    reftxtb.Text = dr[1].ToString();
                    desprotxtb.Text = dr[2].ToString();
                    qtetxtb.Text = dr[3].ToString();
                    prixatxtb.Text = dr[4].ToString();
                    prixvtxtb.Text = dr[5].ToString();
                    ttctxtb.Text = dr[6].ToString();
                    detailstxtbox.Text = dr[7].ToString();
                    catcombox.SelectedValue = dr[8].ToString();
                    fourcombox.SelectedValue = dr[9].ToString();
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
