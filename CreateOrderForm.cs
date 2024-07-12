using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Younes_Entreprise
{
    public partial class CreateOrderForm : Form
    {
        int qte = 0;

        string id;
        double montant = 0;
        public string cin;
        public string role;
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientcombobox();
                combocmd();

                label13.Text = ".";
                label16.Text = ".";
                prixtxtb.Text = "";
                totaltxtbox.Text = "";
                clientcombox.Text = "";
                bunifuTextBox1.Text = "0";
                ProductsName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void remplircmdgrid()
        {

            if (cmdcombox.SelectedIndex >= 0)
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select p.Pro_id,p.Pro_Reference,p.Pro_Designation,d.Cmd_Qte,Round(d.Cmd_PrixUnitaire-d.Cmd_PrixUnitaire/1.2*0.2,2) as Cmd_PrixUnitaire,p.Pro_Description,round(round((d.Cmd_Qte*d.Cmd_PrixUnitaire),2)-round((d.Cmd_Qte*d.Cmd_PrixUnitaire),2)/1.2*0.2,2) as total 
                                                        from Details_Commande d,Produit p where p.Pro_id=d.Pro_id and Cmd_id=@id order by order_date", Connexion.cnx);
                Connexion.adapter.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@id",
                    Value = Convert.ToInt32(cmdcombox.Text),
                    SqlDbType = SqlDbType.Int
                });

                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                prodgrid.DataSource = Connexion.dt;


                Connexion.cmd.Parameters.Clear();
                Connexion.cmd = new SqlCommand(@"select * from Commande where Cmd_id=@id", Connexion.cnx);
                Connexion.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(cmdcombox.Text));
                SqlDataReader drr = Connexion.cmd.ExecuteReader();
                if (drr.Read())
                {
                    totaltxtbox.Text = drr[4].ToString();
                    totaltxtbox.Text = Math.Round((float.Parse(totaltxtbox.Text) - float.Parse(totaltxtbox.Text) / 1.2 * 0.2), 2).ToString();
                    montant = double.Parse(drr[4].ToString());
                    dateTimePicker1.Text = drr[3].ToString();
                    dateTimePicker2.Text = drr[5].ToString();
                    clientcombox.SelectedValue = drr[1].ToString();
                    cmdidtxtb.Text = drr[0].ToString();
                    bunifuTextBox1.Text = drr[6].ToString();
                    comboBox1.Text = drr[7].ToString();
                }
                drr.Close();
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
            }
        }
        private void combocmd()
        {
            try
            {
                Connexion.connecter();
                DataTable dtcmd = new DataTable();

                Connexion.cmd.CommandText = "select Cmd_id,Cmd_id as cmd_nom from Commande order by Cmd_id desc";
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmdcombox.Items.Add(dr[0].ToString());
                }
                dr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void clientcombobox()
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.CommandText = "select Cli_id,TRIM(Cli_Nom) as Cli_Nom from Client";

                SqlDataReader drcli = Connexion.cmd.ExecuteReader();
                DataTable dtcli = new DataTable();
                dtcli.Load(drcli);
                clientcombox.DataSource = dtcli;
                clientcombox.DisplayMember = "Cli_Nom";
                clientcombox.ValueMember = "Cli_id";
                drcli.Close();

                Connexion.cmd.CommandText = "select MAX(Cmd_id)+1 from Commande";
                SqlDataReader drr = Connexion.cmd.ExecuteReader();
                if (drr.Read())
                {
                    if (drr[0].ToString().Length > 0)
                    {
                        cmdidtxtb.Text = drr[0].ToString();
                    }
                    else
                    {
                        cmdidtxtb.Text = "1";
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
        private void ProductsName()
        {

            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select Pro_id, trim(Pro_Designation) as 'Pro_Designation'  from Produit ", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                DataRow dr = Connexion.dt.NewRow();
                dr["Pro_Designation"] = "";
                dr["Pro_id"] = 0;
                Connexion.dt.Rows.InsertAt(dr, 0);
                prodcombox.ValueMember = "Pro_id";
                prodcombox.DisplayMember = "Pro_Designation";
                prodcombox.DataSource = Connexion.dt;
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
                Connexion.cmd.CommandText = "insert into Commande values(@cli_id,@util_id,@cmd_date,@montant,@echance,@remise,@clipaiement)";
                Connexion.cmd.Parameters.AddWithValue("cli_id", clientcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("cmd_date", dateTimePicker1.Value);
                Connexion.cmd.Parameters.AddWithValue("echance", dateTimePicker2.Value);
                Connexion.cmd.Parameters.AddWithValue("montant", 0);
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("remise", Math.Round(float.Parse(bunifuTextBox1.Text), 2));
                Connexion.cmd.Parameters.AddWithValue("clipaiement", comboBox1.Text);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@date)";
                Connexion.cmd.Parameters.AddWithValue("operation", " ajouté la Commande " + cmdidtxtb.Text);
                Connexion.cmd.Parameters.AddWithValue("date", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                ajouterbtn.Visible = false;
                totaltxtbox.Text = "0";
                combocmd();
                cmdidtxtb.Text = cmdcombox.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void vidercmdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                prodcombox.Text = String.Empty;
                qtetxtb.Text = String.Empty;
                prixtxtb.Text = String.Empty;
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
                int num;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select COUNT(*) from Commande where Cmd_id=@id";
                Connexion.cmd.Parameters.AddWithValue("id", cmdidtxtb.Text);
                num = (int)Connexion.cmd.ExecuteScalar();
                if (num > 0)
                {
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "update Commande set Cmd_Date=@date,Remise=@remise, Cli_id=@cli_id,Echeance=@echance, Cli_Paiement=@clipaiement where Cmd_id=@id";
                    Connexion.cmd.Parameters.AddWithValue("date", dateTimePicker1.Value);
                    Connexion.cmd.Parameters.AddWithValue("cli_id", clientcombox.SelectedValue);
                    Connexion.cmd.Parameters.AddWithValue("id", cmdcombox.Text);
                    Connexion.cmd.Parameters.AddWithValue("echance", dateTimePicker2.Value);
                    Connexion.cmd.Parameters.AddWithValue("remise", float.Parse(bunifuTextBox1.Text));
                    Connexion.cmd.Parameters.AddWithValue("clipaiement", comboBox1.Text);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", "modifié les données de la Commande " + cmdidtxtb.Text);
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("La commande est modifiée ");
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de tel Commande");
                }
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(qtetxtb.Text) <= qte)
                {
                    Connexion.connecter();
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "insert into Details_Commande values (@cmd_id,@pro_id,@prix,@qte,@ordate)";
                    Connexion.cmd.Parameters.AddWithValue("cmd_id", cmdcombox.Text);
                    Connexion.cmd.Parameters.AddWithValue("pro_id", prodcombox.SelectedValue);
                    Connexion.cmd.Parameters.AddWithValue("prix", float.Parse(prixtxtb.Text));
                    Connexion.cmd.Parameters.AddWithValue("qte", int.Parse(qtetxtb.Text));
                    Connexion.cmd.Parameters.AddWithValue("ordate", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();


                    Connexion.cmd.CommandText = "update Commande set montant= round((montant+(@qte*@prix)),2) where Cmd_id=@cmd_id";
                    Connexion.cmd.ExecuteNonQuery();


                    Connexion.cmd.CommandText = "update Produit set UnitesEnStock=UnitesEnStock-@qte where Pro_id=@pro_id";
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();

                    qtetxtb.Clear();
                    prixtxtb.Clear();
                    prodcombox.Text = "";
                    remplircmdgrid();

                }
                else
                {
                    MessageBox.Show("Cette quantité est supérieure à la quantité en stock");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void vidbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //vider 
                clientcombobox();
                comboBox1.Text = String.Empty;
                bunifuTextBox1.Text = "0";
                clientcombox.Text = null;
                totaltxtbox.Text = "";
                cmdcombox.SelectedIndex = 0;
                prodcombox.Text = String.Empty;
                qtetxtb.Text = String.Empty;
                prixtxtb.Text = String.Empty;
                prodgrid.Refresh();
                ajouterbtn.Visible = true;
                dateTimePicker2.Value = DateTime.Now;
                prodgrid.Controls.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void printbcbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                view v = new view();
                facture_dataset ds = new facture_dataset();
                string sql = "select Echeance,'DEVIS 22/'+convert(varchar(30),c.Cmd_id) as Cmd_id,ICE,Cmd_Date,convert(varchar(50),ROUND((montant-(montant/100*Remise)),2))+' MAD'as montant,convert(varchar(50),ROUND((montant/1.2*0.2),2))+' MAD' as TVA,convert(varchar(50),ROUND((montant-(montant/1.2*0.2)),2))+' MAD' as HT,Cli_Nom,Cli_Adresse,Cli_Phone,p.Pro_Reference,p.Pro_Designation,d.Cmd_Qte,ROUND((d.Cmd_PrixUnitaire-(d.Cmd_PrixUnitaire/1.2*0.2)),2)as Cmd_PrixUnitaire,ROUND((d.total-(d.total/1.2*0.2)),2)as total,convert(varchar(50),Remise)+' %' as Remise from Commande c,Utilisateur u,Client cl,Produit p,Details_Commande d where c.Cli_id=cl.Cli_id and u.Util_id=c.Util_id and p.Pro_id=d.Pro_id and c.Cmd_id=d.Cmd_id  and c.Cmd_id='" + cmdcombox.Text + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, Connexion.cnx);
                sqlData.Fill(ds.Tables["commande"]);
                Devis dv = new Devis();
                dv.SetDataSource(ds.Tables["commande"]);
                v.crystalReportViewer1.ReportSource = dv;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", "imprimé le Devis " + prodgrid.SelectedRows[0].Cells[0].Value.ToString());
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                v.Show();
            }
            catch
            {
                MessageBox.Show("Choisir une Commande");
            }

        }
        private void printblbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                view v = new view();
                facture_dataset ds = new facture_dataset();
                string sql = "select ('BL22/'+convert(varchar(30),c.Cmd_id)) as Cmd_id,Cmd_Date,ICE,convert(varchar(50),ROUND((montant-(montant/100*Remise)),2))+' MAD'as montant,convert(varchar(50),ROUND((montant),2))+' MAD' as HT,Cli_Nom,Cli_Adresse,Cli_Phone,p.Pro_Reference,p.Pro_Designation,d.Cmd_Qte, ROUND((d.Cmd_PrixUnitaire),2)as Cmd_PrixUnitaire, ROUND((d.total),2)as total,convert(varchar(50),Remise)+' %' as Remise from Commande c,Utilisateur u,Client cl,Produit p,Details_Commande d where c.Cli_id=cl.Cli_id and u.Util_id=c.Util_id and p.Pro_id=d.Pro_id and c.Cmd_id=d.Cmd_id  and c.Cmd_id='" + cmdcombox.Text + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, Connexion.cnx);
                sqlData.Fill(ds.Tables["commande"]);
                bonlivraison bl = new bonlivraison();
                bl.SetDataSource(ds.Tables["commande"]);
                v.crystalReportViewer1.ReportSource = bl;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", "imprimé le Bon De Livraison " + prodgrid.SelectedRows[0].Cells[0].Value.ToString());
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                v.Show();
            }
            catch
            {
                MessageBox.Show("Choisir une Vente");
            }

        }
        private void printbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                view v = new view();
                facture_dataset ds = new facture_dataset();
                string sql = "select ICE,('FA22/'+convert(varchar(30),c.Cmd_id)) as Cmd_id,Cmd_Date,convert(varchar(50),ROUND((montant-(montant/100*Remise)),2))+' MAD'as montant,convert(varchar(50),ROUND((montant/1.2*0.2),2))+' MAD' as TVA,convert(varchar(50),ROUND((montant-(montant/1.2*0.2)),2))+' MAD' as HT,Cli_Nom,Cli_Adresse,c.Cli_Paiement,Cli_Phone,p.Pro_Reference,p.Pro_Designation,d.Cmd_Qte,ROUND((d.Cmd_PrixUnitaire-(d.Cmd_PrixUnitaire/1.2*0.2)),2)as Cmd_PrixUnitaire,ROUND((d.total-(d.total/1.2*0.2)),2)as total ,convert(varchar(50),Remise)+' %' as Remise from Commande c,Utilisateur u,Client cl,Produit p,Details_Commande d where c.Cli_id=cl.Cli_id and u.Util_id=c.Util_id and p.Pro_id=d.Pro_id and c.Cmd_id=d.Cmd_id  and c.Cmd_id='" + cmdcombox.Text + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, Connexion.cnx);
                sqlData.Fill(ds.Tables["commande"]);
                Connexion.cmd.CommandText = "select ROUND(montant-(montant/100*Remise),2) as montant from commande where Cmd_id='" + cmdcombox.Text + "'";

                string montantalpha = ((double)Connexion.cmd.ExecuteScalar()).ToLettres();
                for (int i = 0; i < ds.Tables["commande"].Rows.Count; i++)
                {
                    ds.Tables["commande"].Rows[i]["montantalpha"] = montantalpha;
                }

                facture_commande fa = new facture_commande();
                fa.SetDataSource(ds.Tables["commande"]);
                v.crystalReportViewer1.ReportSource = fa;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", "imprimé la Facture " + prodgrid.SelectedRows[0].Cells[0].Value.ToString());
                Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();
                v.Show();
            }
            catch
            {
                MessageBox.Show("Choisir une Commande");
            }

        }
        private void modifybtn2_Click(object sender, EventArgs e)
        {

            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.Parameters.AddWithValue("cmd_id", cmdcombox.Text);
                Connexion.cmd.Parameters.AddWithValue("pro_id", prodcombox.SelectedValue);
                Connexion.cmd.Parameters.AddWithValue("prix", float.Parse(prixtxtb.Text));
                Connexion.cmd.Parameters.AddWithValue("qte", int.Parse(qtetxtb.Text));
                Connexion.cmd.CommandText = "update Produit set UnitesEnStock=UnitesEnStock+(select Cmd_Qte from Details_Commande where Pro_id=@pro_id and Cmd_id=@cmd_id) where Pro_id=@pro_id";
                Connexion.cmd.ExecuteNonQuery();

                Connexion.cmd.CommandText = "update Commande set montant= round((montant-(select total from Details_Commande where Pro_id=@pro_id and Cmd_id=@cmd_id)),2) where Cmd_id=@cmd_id";
                Connexion.cmd.ExecuteNonQuery();

                Connexion.cmd.CommandText = "UPDATE Details_Commande set Cmd_PrixUnitaire=@prix,Cmd_Qte=@qte where Pro_id=@pro_id and Cmd_id=@cmd_id";
                Connexion.cmd.ExecuteNonQuery();


                Connexion.cmd.CommandText = "update Commande set montant= round((montant+(@qte*@prix)),2) where Cmd_id=@cmd_id";
                Connexion.cmd.ExecuteNonQuery();


                Connexion.cmd.CommandText = "update Produit set UnitesEnStock=UnitesEnStock-@qte where Pro_id=@pro_id";
                Connexion.cmd.ExecuteNonQuery();
                Connexion.deconnecter();

                remplircmdgrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer ?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.connecter();
                    Connexion.cmd.Parameters.Clear();
                    Connexion.cmd.CommandText = "delete from Details_Commande where Cmd_id=@cmd_id and Pro_id=@pro_id";
                    Connexion.cmd.Parameters.AddWithValue("cmd_id", cmdcombox.Text);
                    Connexion.cmd.Parameters.AddWithValue("pro_id", prodcombox.SelectedValue);
                    Connexion.cmd.Parameters.AddWithValue("prix", float.Parse(prixtxtb.Text));
                    Connexion.cmd.Parameters.AddWithValue("qte", int.Parse(qtetxtb.Text));
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", "Supprimé les données de " + cmdidtxtb.Text);
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();


                    Connexion.cmd.CommandText = "update Commande set montant=round((montant-(@qte*@prix)),2) where Cmd_id=@cmd_id";
                    Connexion.cmd.ExecuteNonQuery();


                    Connexion.cmd.CommandText = "update Produit set UnitesEnStock=UnitesEnStock+@qte where Pro_id=@pro_id";
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("Le produit est supprimé de la commande ");

                    Connexion.deconnecter();
                    remplircmdgrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void prodgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = prodgrid.SelectedRows[0].Cells[1].Value.ToString().Trim(new char[] { ' ' });
                prodcombox.Text = prodgrid.SelectedRows[0].Cells[2].Value.ToString().Trim(new char[] { ' ' });
                qtetxtb.Text = prodgrid.SelectedRows[0].Cells[3].Value.ToString().Trim(new char[] { ' ' });
                prixtxtb.Text = Math.Round((double.Parse(prodgrid.SelectedRows[0].Cells[4].Value.ToString()) * 1.2), 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (bunifuTextBox1.Text.Length != 0)
                {
                    totaltxtbox.Text = (Math.Round((montant - montant / 100 * float.Parse(bunifuTextBox1.Text)), 2)).ToString();
                }
                else
                {
                    totaltxtbox.Text = (Math.Round(montant, 2)).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmdcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                remplircmdgrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void prodcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "select UnitesEnStock, Prix_Vente,Prix_dachat from Produit where Pro_Designation=@id ";
                Connexion.cmd.Parameters.AddWithValue("@id", prodcombox.Text);
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    label16.Text = dr[0].ToString();
                    qte = int.Parse(dr[0].ToString());
                    prixtxtb.Text = dr[1].ToString();
                    label13.Text = dr[2].ToString();
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
