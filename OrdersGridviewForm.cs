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
    public partial class OrdersGridviewForm : Form
    {

        public string cin;
        public string role;
        public OrdersGridviewForm()
        {
            InitializeComponent();
        }

        private void OrdersGridviewForm_Load(object sender, EventArgs e)
        {
            try { 
            remliregrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void remliregrid()
        {
            try
            {
                Connexion.connecter();
                Connexion.adapter = new SqlDataAdapter(@"select c.Cmd_id,Cli_Nom,Cmd_Date,round(montant,2) as montant,round((montant/100*Remise),2) as Remise,round((montant - (montant/100*Remise)),2) as 'Montant_final' ,Cli_Paiement,Echeance,(TRIM(u.Util_Nom)+' '+TRIM(u.Util_Prenom))as Util_Nom 
                                                        from Commande c,Utilisateur u,Client cl where c.Cli_id=cl.Cli_id and u.Util_id=c.Util_id", Connexion.cnx);
                Connexion.dt = new DataTable();
                Connexion.adapter.Fill(Connexion.dt);
                cmdgrid.DataSource = Connexion.dt;
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
                DialogResult dialogResult = MessageBox.Show("Vous voulez le supprimer?", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.connecter();
                    Connexion.cmd.CommandText = "delete from Details_Commande where Cmd_id='" + cmdgrid.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.cmd.CommandText = "delete from commande where  Cmd_id='" + cmdgrid.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    Connexion.cmd.ExecuteNonQuery();

                    Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                    Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                    Connexion.cmd.Parameters.AddWithValue("operation", " supprimé la commande " + cmdgrid.SelectedRows[0].Cells[0].Value.ToString());
                    Connexion.cmd.Parameters.AddWithValue("dateoper", DateTime.Now);
                    Connexion.cmd.ExecuteNonQuery();
                    Connexion.deconnecter();
                    MessageBox.Show("La Commande est supprimée ");
                    remliregrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cherchetxtb_TextChange(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "convert([Cmd_id], System.String) like '%" + cherchetxtb.Text + "%' or [Cli_Nom] like '%" + cherchetxtb.Text + "%'";
            cmdgrid.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cherchebtn_Click(object sender, EventArgs e)
        {
            try { 
            BindingSource bs = new BindingSource();
            bs.DataSource = Connexion.dt;
            bs.Filter = "[Cmd_Date]>='" + dateTimePicker1.Value + "' and [Cmd_Date]<'" + dateTimePicker2.Value + "'";
            cmdgrid.DataSource = bs;
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
                Connexion.connecter();
                view v = new view();
                facture_dataset ds = new facture_dataset();
                string sql = "select ('BL22/'+convert(varchar(30),c.Cmd_id)) as Cmd_id,Cmd_Date,ICE,convert(varchar(50),ROUND((montant-(montant/100*Remise)),2))+' MAD'as montant,convert(varchar(50),ROUND((montant),2))+' MAD' as HT,Cli_Nom,Cli_Adresse,Cli_Phone,p.Pro_Reference,p.Pro_Designation,d.Cmd_Qte, ROUND((d.Cmd_PrixUnitaire),2)as Cmd_PrixUnitaire, ROUND((d.total),2)as total,convert(varchar(50),Remise)+' %' as Remise from Commande c,Utilisateur u,Client cl,Produit p,Details_Commande d where c.Cli_id=cl.Cli_id and u.Util_id=c.Util_id and p.Pro_id=d.Pro_id and c.Cmd_id=d.Cmd_id and c.Cmd_id='" + cmdgrid.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, Connexion.cnx);
                sqlData.Fill(ds.Tables["commande"]);
                bonlivraison bl = new bonlivraison();
                bl.SetDataSource(ds.Tables["commande"]);
                v.crystalReportViewer1.ReportSource = bl;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", "imprimé le Bon De Livraison " + cmdgrid.SelectedRows[0].Cells[0].Value.ToString());
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

        private void printfabtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                view v = new view();
                facture_dataset ds = new facture_dataset();
                string sql = "select ICE,('FA22/'+convert(varchar(30),c.Cmd_id)) as Cmd_id,Cmd_Date,convert(varchar(50),ROUND((montant-(montant/100*Remise)),2))+' MAD'as montant,convert(varchar(50),ROUND((montant/1.2*0.2),2))+' MAD' as TVA,convert(varchar(50),ROUND((montant-(montant/1.2*0.2)),2))+' MAD' as HT,Cli_Nom,Cli_Adresse,c.Cli_Paiement,Cli_Phone,p.Pro_Reference,p.Pro_Designation,d.Cmd_Qte,ROUND((d.Cmd_PrixUnitaire-(d.Cmd_PrixUnitaire/1.2*0.2)),2)as Cmd_PrixUnitaire,ROUND((d.total-(d.total/1.2*0.2)),2)as total,convert(varchar(50),Remise)+' %' as Remise from Commande c,Utilisateur u,Client cl,Produit p,Details_Commande d where c.Cli_id=cl.Cli_id and u.Util_id=c.Util_id and p.Pro_id=d.Pro_id and c.Cmd_id=d.Cmd_id  and c.Cmd_id='" + cmdgrid.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, Connexion.cnx);
                sqlData.Fill(ds.Tables["commande"]);
                Connexion.cmd.CommandText = "select ROUND((montant-(montant/100*Remise)),2) as montant from commande where Cmd_id='" + cmdgrid.SelectedRows[0].Cells[0].Value.ToString() + "'";
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
                Connexion.cmd.Parameters.AddWithValue("operation", "imprimé la Facture " + cmdgrid.SelectedRows[0].Cells[0].Value.ToString());
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

        private void printbcbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                view v = new view();
                facture_dataset ds = new facture_dataset();
                string sql = "select ('DEVIS 22/'+convert(varchar(30),c.Cmd_id)) as Cmd_id,Cmd_Date,convert(varchar(50),ROUND((montant-(montant/100*Remise)),2))+' MAD'as montant,ICE,convert(varchar(50),ROUND((montant/1.2*0.2),2))+' MAD' as TVA,convert(varchar(50),ROUND((montant-(montant/1.2*0.2)),2))+' MAD' as HT,Cli_Nom,Cli_Adresse,Cli_Phone,p.Pro_Reference,p.Pro_Designation,Echeance,d.Cmd_Qte,ROUND((d.Cmd_PrixUnitaire-(d.Cmd_PrixUnitaire/1.2*0.2)),2)as Cmd_PrixUnitaire,ROUND((d.total-(d.total/1.2*0.2)),2)as total,convert(varchar(50),Remise)+' %' as Remise from Commande c,Utilisateur u,Client cl,Produit p,Details_Commande d where c.Cli_id=cl.Cli_id and u.Util_id=c.Util_id and p.Pro_id=d.Pro_id and c.Cmd_id=d.Cmd_id  and c.Cmd_id='" + cmdgrid.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, Connexion.cnx);
                sqlData.Fill(ds.Tables["Commande"]);
                Devis dv = new Devis();
                dv.SetDataSource(ds.Tables["Commande"]);
                v.crystalReportViewer1.ReportSource = dv;
                Connexion.cmd.Parameters.Clear();
                Connexion.cmd.CommandText = "insert into operation_table values(@util_id,@operation,@dateoper)";
                Connexion.cmd.Parameters.AddWithValue("util_id", cin);
                Connexion.cmd.Parameters.AddWithValue("operation", "imprimé le Devis " + cmdgrid.SelectedRows[0].Cells[0].Value.ToString());
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
    }
}
