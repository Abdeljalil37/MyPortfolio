namespace Younes_Entreprise
{
    partial class EmployeesGridviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesGridviewForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.empgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Departement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.supprimerbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cherchetxtb = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // empgrid
            // 
            this.empgrid.AllowCustomTheming = true;
            this.empgrid.AllowUserToAddRows = false;
            this.empgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.empgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empgrid.BackgroundColor = System.Drawing.Color.White;
            this.empgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empgrid.ColumnHeadersHeight = 40;
            this.empgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_id,
            this.Emp_Nom,
            this.Emp_Phone,
            this.Emp_Adresse,
            this.Emp_Email,
            this.Emp_Salaire,
            this.Emp_Departement,
            this.Emp_Details});
            this.empgrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.empgrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.empgrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.empgrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.empgrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.empgrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.empgrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.empgrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.empgrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.empgrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.empgrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.empgrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.empgrid.CurrentTheme.Name = null;
            this.empgrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.empgrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.empgrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.empgrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.empgrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.empgrid.EnableHeadersVisualStyles = false;
            this.empgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.empgrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.empgrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.empgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.empgrid.Location = new System.Drawing.Point(27, 168);
            this.empgrid.Margin = new System.Windows.Forms.Padding(0);
            this.empgrid.Name = "empgrid";
            this.empgrid.RowHeadersVisible = false;
            this.empgrid.RowHeadersWidth = 51;
            this.empgrid.RowTemplate.Height = 40;
            this.empgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empgrid.Size = new System.Drawing.Size(1549, 718);
            this.empgrid.TabIndex = 66;
            this.empgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Emp_id
            // 
            this.Emp_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Emp_id.DataPropertyName = "Emp_id";
            this.Emp_id.HeaderText = "ID";
            this.Emp_id.MinimumWidth = 3;
            this.Emp_id.Name = "Emp_id";
            this.Emp_id.Width = 70;
            // 
            // Emp_Nom
            // 
            this.Emp_Nom.DataPropertyName = "Emp_Nom";
            this.Emp_Nom.HeaderText = "Nom";
            this.Emp_Nom.MinimumWidth = 6;
            this.Emp_Nom.Name = "Emp_Nom";
            // 
            // Emp_Phone
            // 
            this.Emp_Phone.DataPropertyName = "Emp_Phone";
            this.Emp_Phone.HeaderText = "Telephone";
            this.Emp_Phone.MinimumWidth = 6;
            this.Emp_Phone.Name = "Emp_Phone";
            // 
            // Emp_Adresse
            // 
            this.Emp_Adresse.DataPropertyName = "Emp_Adresse";
            this.Emp_Adresse.HeaderText = "Adresse";
            this.Emp_Adresse.MinimumWidth = 6;
            this.Emp_Adresse.Name = "Emp_Adresse";
            // 
            // Emp_Email
            // 
            this.Emp_Email.DataPropertyName = "Emp_Email";
            this.Emp_Email.HeaderText = "Email";
            this.Emp_Email.MinimumWidth = 6;
            this.Emp_Email.Name = "Emp_Email";
            // 
            // Emp_Salaire
            // 
            this.Emp_Salaire.DataPropertyName = "Emp_Salaire";
            this.Emp_Salaire.HeaderText = "Salaire";
            this.Emp_Salaire.MinimumWidth = 6;
            this.Emp_Salaire.Name = "Emp_Salaire";
            // 
            // Emp_Departement
            // 
            this.Emp_Departement.DataPropertyName = "Emp_Departement";
            this.Emp_Departement.HeaderText = "Departement";
            this.Emp_Departement.MinimumWidth = 6;
            this.Emp_Departement.Name = "Emp_Departement";
            // 
            // Emp_Details
            // 
            this.Emp_Details.DataPropertyName = "Emp_Details";
            this.Emp_Details.HeaderText = "Details";
            this.Emp_Details.MinimumWidth = 6;
            this.Emp_Details.Name = "Emp_Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(575, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(509, 51);
            this.label7.TabIndex = 65;
            this.label7.Text = "La Liste Des Employées";
            // 
            // supprimerbtn
            // 
            this.supprimerbtn.AllowAnimations = true;
            this.supprimerbtn.AllowMouseEffects = true;
            this.supprimerbtn.AllowToggling = false;
            this.supprimerbtn.AnimationSpeed = 200;
            this.supprimerbtn.AutoGenerateColors = false;
            this.supprimerbtn.AutoRoundBorders = false;
            this.supprimerbtn.AutoSizeLeftIcon = true;
            this.supprimerbtn.AutoSizeRightIcon = true;
            this.supprimerbtn.BackColor = System.Drawing.Color.Transparent;
            this.supprimerbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.supprimerbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supprimerbtn.BackgroundImage")));
            this.supprimerbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.supprimerbtn.ButtonText = "Supprimer";
            this.supprimerbtn.ButtonTextMarginLeft = 0;
            this.supprimerbtn.ColorContrastOnClick = 45;
            this.supprimerbtn.ColorContrastOnHover = 45;
            this.supprimerbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.supprimerbtn.CustomizableEdges = borderEdges1;
            this.supprimerbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.supprimerbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.supprimerbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.supprimerbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.supprimerbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.supprimerbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.supprimerbtn.ForeColor = System.Drawing.Color.White;
            this.supprimerbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supprimerbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.supprimerbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.supprimerbtn.IconMarginLeft = 11;
            this.supprimerbtn.IconPadding = 10;
            this.supprimerbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.supprimerbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.supprimerbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.supprimerbtn.IconSize = 25;
            this.supprimerbtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.supprimerbtn.IdleBorderRadius = 1;
            this.supprimerbtn.IdleBorderThickness = 1;
            this.supprimerbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.supprimerbtn.IdleIconLeftImage = null;
            this.supprimerbtn.IdleIconRightImage = null;
            this.supprimerbtn.IndicateFocus = false;
            this.supprimerbtn.Location = new System.Drawing.Point(1411, 93);
            this.supprimerbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supprimerbtn.Name = "supprimerbtn";
            this.supprimerbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.supprimerbtn.OnDisabledState.BorderRadius = 1;
            this.supprimerbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.supprimerbtn.OnDisabledState.BorderThickness = 1;
            this.supprimerbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.supprimerbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.supprimerbtn.OnDisabledState.IconLeftImage = null;
            this.supprimerbtn.OnDisabledState.IconRightImage = null;
            this.supprimerbtn.onHoverState.BorderColor = System.Drawing.Color.Yellow;
            this.supprimerbtn.onHoverState.BorderRadius = 1;
            this.supprimerbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.supprimerbtn.onHoverState.BorderThickness = 1;
            this.supprimerbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.supprimerbtn.onHoverState.ForeColor = System.Drawing.Color.Yellow;
            this.supprimerbtn.onHoverState.IconLeftImage = null;
            this.supprimerbtn.onHoverState.IconRightImage = null;
            this.supprimerbtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.supprimerbtn.OnIdleState.BorderRadius = 1;
            this.supprimerbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.supprimerbtn.OnIdleState.BorderThickness = 1;
            this.supprimerbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.supprimerbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.supprimerbtn.OnIdleState.IconLeftImage = null;
            this.supprimerbtn.OnIdleState.IconRightImage = null;
            this.supprimerbtn.OnPressedState.BorderColor = System.Drawing.Color.Yellow;
            this.supprimerbtn.OnPressedState.BorderRadius = 1;
            this.supprimerbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.supprimerbtn.OnPressedState.BorderThickness = 1;
            this.supprimerbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.supprimerbtn.OnPressedState.ForeColor = System.Drawing.Color.Yellow;
            this.supprimerbtn.OnPressedState.IconLeftImage = null;
            this.supprimerbtn.OnPressedState.IconRightImage = null;
            this.supprimerbtn.Size = new System.Drawing.Size(165, 60);
            this.supprimerbtn.TabIndex = 72;
            this.supprimerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimerbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.supprimerbtn.TextMarginLeft = 0;
            this.supprimerbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.supprimerbtn.UseDefaultRadiusAndThickness = true;
            this.supprimerbtn.Click += new System.EventHandler(this.supprimerbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 71;
            this.label1.Text = "Recherche  :";
            // 
            // cherchetxtb
            // 
            this.cherchetxtb.AcceptsReturn = false;
            this.cherchetxtb.AcceptsTab = false;
            this.cherchetxtb.AnimationSpeed = 200;
            this.cherchetxtb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cherchetxtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cherchetxtb.BackColor = System.Drawing.Color.Transparent;
            this.cherchetxtb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cherchetxtb.BackgroundImage")));
            this.cherchetxtb.BorderColorActive = System.Drawing.Color.Black;
            this.cherchetxtb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cherchetxtb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.cherchetxtb.BorderColorIdle = System.Drawing.Color.Silver;
            this.cherchetxtb.BorderRadius = 1;
            this.cherchetxtb.BorderThickness = 2;
            this.cherchetxtb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cherchetxtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cherchetxtb.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cherchetxtb.DefaultText = "";
            this.cherchetxtb.FillColor = System.Drawing.Color.White;
            this.cherchetxtb.HideSelection = true;
            this.cherchetxtb.IconLeft = null;
            this.cherchetxtb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.cherchetxtb.IconPadding = 10;
            this.cherchetxtb.IconRight = null;
            this.cherchetxtb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.cherchetxtb.Lines = new string[0];
            this.cherchetxtb.Location = new System.Drawing.Point(210, 107);
            this.cherchetxtb.Margin = new System.Windows.Forms.Padding(0);
            this.cherchetxtb.MaxLength = 32767;
            this.cherchetxtb.MinimumSize = new System.Drawing.Size(392, 46);
            this.cherchetxtb.Modified = false;
            this.cherchetxtb.Multiline = false;
            this.cherchetxtb.Name = "cherchetxtb";
            stateProperties1.BorderColor = System.Drawing.Color.Black;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cherchetxtb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.cherchetxtb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cherchetxtb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cherchetxtb.OnIdleState = stateProperties4;
            this.cherchetxtb.Padding = new System.Windows.Forms.Padding(3);
            this.cherchetxtb.PasswordChar = '\0';
            this.cherchetxtb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.cherchetxtb.PlaceholderText = "Par : ID - Nom";
            this.cherchetxtb.ReadOnly = false;
            this.cherchetxtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cherchetxtb.SelectedText = "";
            this.cherchetxtb.SelectionLength = 0;
            this.cherchetxtb.SelectionStart = 0;
            this.cherchetxtb.ShortcutsEnabled = true;
            this.cherchetxtb.Size = new System.Drawing.Size(399, 46);
            this.cherchetxtb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.cherchetxtb.TabIndex = 70;
            this.cherchetxtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cherchetxtb.TextMarginBottom = 0;
            this.cherchetxtb.TextMarginLeft = 8;
            this.cherchetxtb.TextMarginTop = 0;
            this.cherchetxtb.TextPlaceholder = "Par : ID - Nom";
            this.cherchetxtb.UseSystemPasswordChar = false;
            this.cherchetxtb.WordWrap = true;
            this.cherchetxtb.TextChange += new System.EventHandler(this.cherchetxtb_TextChange);
            // 
            // EmployeesGridviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1605, 945);
            this.Controls.Add(this.supprimerbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cherchetxtb);
            this.Controls.Add(this.empgrid);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1605, 945);
            this.Name = "EmployeesGridviewForm";
            this.Text = "Liste Des Employées";
            this.Load += new System.EventHandler(this.EmployeesGridviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView empgrid;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton supprimerbtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox cherchetxtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Salaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Departement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Details;
    }
}