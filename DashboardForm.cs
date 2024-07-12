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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try { 
            alert();
            toparticle();
            topcategorie();
            montant();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void alert()
        {
            Connexion.connecter();
            Connexion.cmd.CommandText = "exec dashbord";
            SqlDataReader dr = Connexion.cmd.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr[0].ToString();
                label5.Text = dr[1].ToString() + " DH";
                label7.Text = dr[2].ToString();
                label9.Text = dr[3].ToString();
            }
            dr.Close();
            Connexion.deconnecter();

            // montant HT in chiffre d'affaire
            /*try
            {
                Connexion.connecter();
                Connexion.cmd.CommandText = "exec dashbord";
                SqlDataReader dr = Connexion.cmd.ExecuteReader();
                if (dr.Read())
                {
                    label2.Text = dr[0].ToString();
                    if (dr[1].ToString().Length == 0)
                    {
                        label5.Text = "0 DH";
                    }
                    else
                    {
                        double chiffre =  double.Parse(dr[1].ToString());
                        label5.Text = Math.Round((chiffre - chiffre / 1.2 * 0.2),2).ToString() + " DH";
                    }
                    label7.Text = dr[2].ToString();
                    label9.Text = dr[3].ToString();
                }
                dr.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
      
        private void toparticle()
        {
            try {
                Connexion.connecter();
            DataTable dtart = new DataTable();
            Connexion.cmd.CommandText = "select top 8 sum(Cmd_PrixUnitaire) as qte,p.Pro_Reference from Details_Commande d,Produit p where d.Pro_id=p.Pro_id  group by Pro_Reference  order by qte DESC";
            SqlDataReader drart = Connexion.cmd.ExecuteReader();
            dtart.Load(drart);
            ArticlesChart.DataSource = dtart;
            ArticlesChart.ChartAreas["ChartArea1"].AxisX.Title = "Les Articles";
            ArticlesChart.ChartAreas["ChartArea1"].AxisY.Title = "Tarif en DH";
            ArticlesChart.Series["."].XValueMember = "Pro_Reference";
            ArticlesChart.Series["."].YValueMembers = "qte";
            drart.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void topcategorie()
        {
            try {
                Connexion.connecter();
            DataTable dtart = new DataTable();
            Connexion.cmd.CommandText = "select top 7 SUM(Cmd_PrixUnitaire)as montant,c.Cat_Nom from Categorie c,Produit p,Details_Commande d where c.Cat_id=p.Cat_id and p.Pro_id=d.Pro_id group by Cat_Nom order by montant DESC";
            SqlDataReader drart = Connexion.cmd.ExecuteReader();
            dtart.Load(drart);
            chart1.DataSource = dtart;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "les categorie";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tarif en DH";
            drart.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void montant()
        {
            try {
                Connexion.connecter();
            DataTable dtart = new DataTable();
            Connexion.cmd.CommandText = "select sum(montant)as montant,Cmd_Date from Commande group by Cmd_Date";
            SqlDataReader drart = Connexion.cmd.ExecuteReader();
            dtart.Load(drart);
            chart2.DataSource = dtart;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "La Periode";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Tarif en DH";
            chart2.Series["."].XValueMember = "Cmd_Date";
            chart2.Series["."].YValueMembers = "montant";
            drart.Close();
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnl4_Click(object sender, EventArgs e)
        {
            try { 
            AlertForm af = new AlertForm();
            af.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnl1_Click(object sender, EventArgs e)
        {
            try { 
            StockGridviewForm2 stf = new StockGridviewForm2();
            stf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnl3_Click(object sender, EventArgs e)
        {
            try { 
            DailyOrderForm dof = new DailyOrderForm();
            dof.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnl2_Click(object sender, EventArgs e)
        {
            try { 
            ProfitGridviewForm pgf = new ProfitGridviewForm();
            pgf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
