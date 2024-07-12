using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;

namespace Younes_Entreprise
{
    public partial class MainForm : Form
    {
        public string cin;
        public string role;
        //Fields
        public IconButton currentBtn;
        //  public Panel leftBorderBtn;
        public Form currentChildForm;

        //Constructor
        [Obsolete]
        public MainForm()
        {
            InitializeComponent();


            //hide form bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            Connexion.connecter();
            try
            {
                Connexion.cmd.CommandText = "select COUNT(*) from Client where DATEDIFF(DAY,Date_Vidange,GETDATE())=0";
                int vidange = (int)Connexion.cmd.ExecuteScalar();
                if (vidange > 0)
                {
                    alertlbl.Visible = true;
                    MessageBox.Show("Quelques Alertes de Vidange de Voiture");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (DateTime.Now.ToLongDateString().Substring(0, 6) == "samedi")
                {
                    MessageBox.Show("C'est le moment d'une sauvegarde");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try { 
            if (role.Trim(new char[] { ' ' }) != "Admin")
            {
                
                Dashboardbtn.Visible = false;
                employeespnl.Visible = false;
                Employeesbtn.Visible = false;
                createuserbtn.Visible = false;
                listeutilbtn.Visible = false;
                bunifuImageButton2.Visible = false;
                utilisateurpnl.Height = 80;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connexion.deconnecter();
        }

        public void hideSubMenu()
        {
            try { 
            utilisateurpnl.Visible = false;
            supplierpnl.Visible = false;
            produitpnl.Visible = false;
            employeespnl.Visible = false;
            orderpnl.Visible = false;
            clientpnl.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void showSubMenu(Panel subMenu)
        {
            try { 
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Structs
        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(210, 163, 23);
            public static Color color2 = Color.FromArgb(231, 205, 30);
            public static Color color3 = Color.FromArgb(253, 207, 0);
            public static Color color4 = Color.FromArgb(255, 215, 0);
            public static Color color5 = Color.FromArgb(243, 223, 15);
            public static Color color6 = Color.FromArgb(249, 237, 5);
        }
        //Methods
        public void ActivateButton(object senderBtn, Color color)
        {
            try { 
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(47, 50, 59);
                currentBtn.ForeColor = color;
                //   currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisableButton()
        {
            try { 
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 37, 45);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gold;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void OpenChildForm(Form childForm)
        {
            try { 
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(childForm);
            Desktoppnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Reset()
        {
            try { 
            DisableButton();
            //    leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gold;
            lblTitleChildForm.Text = "Home";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Events
        //Reset
        public void logo_Click(object sender, EventArgs e)
        {
            try { 

            Desktoppnl.Controls.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Menu Button_Clicks
        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            try { 
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new DashboardForm());
            utilisateurpnl.Visible = false;
            clientpnl.Visible = false;
            supplierpnl.Visible = false;
            produitpnl.Visible = false;
            employeespnl.Visible = false;
            
            orderpnl.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clientbtn_Click(object sender, EventArgs e)
        {
            try { 
            ActivateButton(sender, RGBColors.color3);
            //OpenChildForm(new ClientDashForm());
            utilisateurpnl.Visible = false;
            supplierpnl.Visible = false;
            produitpnl.Visible = false;
            employeespnl.Visible = false;
            
            orderpnl.Visible = false;
            showSubMenu(clientpnl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Fournisseurbtn_Click(object sender, EventArgs e)
        {
            try { 
            ActivateButton(sender, RGBColors.color3);
            utilisateurpnl.Visible = false;
            clientpnl.Visible = false;
            produitpnl.Visible = false;
            employeespnl.Visible = false;
            
            orderpnl.Visible = false;
            showSubMenu(supplierpnl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Employeebtn_Click(object sender, EventArgs e)
        {
            try { 
            ActivateButton(sender, RGBColors.color3);
            utilisateurpnl.Visible = false;
            clientpnl.Visible = false;
            supplierpnl.Visible = false;
            produitpnl.Visible = false;
            
            orderpnl.Visible = false;
            showSubMenu(employeespnl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Produitbtn_Click(object sender, EventArgs e)
        {
            try {
            ActivateButton(sender, RGBColors.color3);
            utilisateurpnl.Visible = false;
            clientpnl.Visible = false;
            supplierpnl.Visible = false;
            employeespnl.Visible = false;
            
            orderpnl.Visible = false;
            showSubMenu(produitpnl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Commandebtn_Click(object sender, EventArgs e)
        {
            try { 
            ActivateButton(sender, RGBColors.color3);
            utilisateurpnl.Visible = false;
            clientpnl.Visible = false;
            supplierpnl.Visible = false;
            produitpnl.Visible = false;
            employeespnl.Visible = false;
            
            showSubMenu(orderpnl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Utilisateurbtn_Click(object sender, EventArgs e)
        {
            try { 
            ActivateButton(sender, RGBColors.color3);
            clientpnl.Visible = false;
            supplierpnl.Visible = false;
            produitpnl.Visible = false;
            employeespnl.Visible = false;
            
            orderpnl.Visible = false;
            showSubMenu(utilisateurpnl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void headerpnl_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void toppnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.deconnecter();
                Application.Exit();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void Maximizebtn_Click(object sender, EventArgs e)
        {
            try { 
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            try { 
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            try { 
            Login log = new Login();
            log.Show();
                Connexion.deconnecter();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void profilbtn_Click(object sender, EventArgs e)
        {
            try { 
            AdminForm admin = new AdminForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listeutilbtn_Click(object sender, EventArgs e)
        {
            try { 
            UtilisateurGridviewForm admin = new UtilisateurGridviewForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createuserbtn_Click(object sender, EventArgs e)
        {
            try { 
            CreateUserForm admin = new CreateUserForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changepswbtn_Click(object sender, EventArgs e)
        {
            try { 
            ChangePasswordForm admin = new ChangePasswordForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void addclitbtn_Click(object sender, EventArgs e)
        {
            try { 
            CreateCustomerForm admin = new CreateCustomerForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listclitbtn_Click(object sender, EventArgs e)
        {
            try { 
            ClientGridviewForm admin = new ClientGridviewForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void profilpictbox_Click(object sender, EventArgs e)
        {
            try { 
            AdminForm admin = new AdminForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addprodbtn_Click(object sender, EventArgs e)
        {
            try { 
            CreateProductForm admin = new CreateProductForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listprodbtn_Click(object sender, EventArgs e)
        {
            try { 
            ProductGridviewForm admin = new ProductGridviewForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categoriebtn_Click(object sender, EventArgs e)
        {
            try { 
            CategorieForm admin = new CategorieForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addsuppbtn_Click(object sender, EventArgs e)
        {
            try { 
            CreateSupplierForm admin = new CreateSupplierForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listsuppbtn_Click(object sender, EventArgs e)
        {
            try { 
            SupplierGridviewForm admin = new SupplierGridviewForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addemployebtn_Click(object sender, EventArgs e)
        {
            try { 
            CreateEmplyeeForm admin = new CreateEmplyeeForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listempbtn_Click(object sender, EventArgs e)
        {
            try { 
            EmployeesGridviewForm admin = new EmployeesGridviewForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addstockbtn_Click(object sender, EventArgs e)
        {
            try { 
            NewStockForm admin = new NewStockForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addcmdbtn_Click(object sender, EventArgs e)
        {
                try { 
            CreateOrderForm admin = new CreateOrderForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void liststockbtn_Click(object sender, EventArgs e)
        {
            try { 
            StockGridviewForm admin = new StockGridviewForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listcmdbtn_Click(object sender, EventArgs e)
        {
            try { 
            OrdersGridviewForm admin = new OrdersGridviewForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void managempbtn_Click(object sender, EventArgs e)
        {
            try { 
            ManageEmployeesForm admin = new ManageEmployeesForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void paymentbtn_Click(object sender, EventArgs e)
        {
            try { 
            PaymentEmpForm admin = new PaymentEmpForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connexion.connecter();
                DialogResult dialogResult = MessageBox.Show("Vous voulez faire le Backup?", "BackUP", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connexion.cmd.CommandText = "exec sqldbbackup";
                    Connexion.cmd.ExecuteNonQuery();
                    MessageBox.Show("Backup Successfully");
                }
                Connexion.deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void managempgridbtn_Click(object sender, EventArgs e)
        {
            try { 
            ManageEmpGridviewForm admin = new ManageEmpGridviewForm();
            admin.cin = cin;
            admin.TopLevel = false;
            admin.FormBorderStyle = FormBorderStyle.None;
            admin.Dock = DockStyle.Fill;
            Desktoppnl.Controls.Add(admin);
            Desktoppnl.Tag = admin;
            admin.BringToFront();
            admin.Show();
            lblTitleChildForm.Text = admin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try { 
            UsersHistoryForm uhf = new UsersHistoryForm();
            uhf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
