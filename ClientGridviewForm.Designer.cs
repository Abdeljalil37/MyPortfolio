namespace Younes_Entreprise
{
    partial class ClientGridviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientGridviewForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.clientgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailcli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Vidange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_FISCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.supprimerbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cintxtbox = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientgrid
            // 
            this.clientgrid.AllowCustomTheming = true;
            this.clientgrid.AllowUserToAddRows = false;
            this.clientgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.clientgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientgrid.BackgroundColor = System.Drawing.Color.White;
            this.clientgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.clientgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientgrid.ColumnHeadersHeight = 40;
            this.clientgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cli_id,
            this.Cli_Nom,
            this.Cli_Type,
            this.Cli_Phone,
            this.detailcli,
            this.Cli_Adresse,
            this.Cli_Email,
            this.Date_Vidange,
            this.RC,
            this.ICE,
            this.PATENTE,
            this.ID_FISCAL,
            this.CNSS,
            this.Util_Nom});
            this.clientgrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.clientgrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.clientgrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.clientgrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.clientgrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.clientgrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.clientgrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.clientgrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.clientgrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.clientgrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.clientgrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.clientgrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.clientgrid.CurrentTheme.Name = null;
            this.clientgrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.clientgrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.clientgrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.clientgrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.clientgrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.clientgrid.EnableHeadersVisualStyles = false;
            this.clientgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.clientgrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.clientgrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.clientgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.clientgrid.Location = new System.Drawing.Point(22, 164);
            this.clientgrid.Margin = new System.Windows.Forms.Padding(0);
            this.clientgrid.Name = "clientgrid";
            this.clientgrid.RowHeadersVisible = false;
            this.clientgrid.RowHeadersWidth = 51;
            this.clientgrid.RowTemplate.Height = 60;
            this.clientgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientgrid.Size = new System.Drawing.Size(1559, 755);
            this.clientgrid.TabIndex = 61;
            this.clientgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.clientgrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientgrid_CellMouseLeave);
            this.clientgrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientgrid_CellMouseMove);
            // 
            // Cli_id
            // 
            this.Cli_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cli_id.DataPropertyName = "Cli_id";
            this.Cli_id.FillWeight = 481.2834F;
            this.Cli_id.HeaderText = "ID ";
            this.Cli_id.MinimumWidth = 3;
            this.Cli_id.Name = "Cli_id";
            this.Cli_id.Width = 70;
            // 
            // Cli_Nom
            // 
            this.Cli_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cli_Nom.DataPropertyName = "Cli_Nom";
            this.Cli_Nom.FillWeight = 52.33957F;
            this.Cli_Nom.HeaderText = "Nom";
            this.Cli_Nom.MinimumWidth = 6;
            this.Cli_Nom.Name = "Cli_Nom";
            this.Cli_Nom.Width = 150;
            // 
            // Cli_Type
            // 
            this.Cli_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cli_Type.DataPropertyName = "Cli_Type";
            this.Cli_Type.FillWeight = 52.33957F;
            this.Cli_Type.HeaderText = "Type";
            this.Cli_Type.MinimumWidth = 6;
            this.Cli_Type.Name = "Cli_Type";
            this.Cli_Type.Width = 120;
            // 
            // Cli_Phone
            // 
            this.Cli_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cli_Phone.DataPropertyName = "Cli_Phone";
            this.Cli_Phone.FillWeight = 52.33957F;
            this.Cli_Phone.HeaderText = "Phone";
            this.Cli_Phone.MinimumWidth = 6;
            this.Cli_Phone.Name = "Cli_Phone";
            this.Cli_Phone.Width = 130;
            // 
            // detailcli
            // 
            this.detailcli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.detailcli.DataPropertyName = "detailcli";
            this.detailcli.FillWeight = 52.33957F;
            this.detailcli.HeaderText = "Details";
            this.detailcli.MinimumWidth = 6;
            this.detailcli.Name = "detailcli";
            this.detailcli.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailcli.Width = 289;
            // 
            // Cli_Adresse
            // 
            this.Cli_Adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cli_Adresse.DataPropertyName = "Cli_Adresse";
            this.Cli_Adresse.FillWeight = 52.33957F;
            this.Cli_Adresse.HeaderText = "Adresse";
            this.Cli_Adresse.MinimumWidth = 6;
            this.Cli_Adresse.Name = "Cli_Adresse";
            this.Cli_Adresse.Width = 125;
            // 
            // Cli_Email
            // 
            this.Cli_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cli_Email.DataPropertyName = "Cli_Email";
            this.Cli_Email.FillWeight = 52.33957F;
            this.Cli_Email.HeaderText = "Email";
            this.Cli_Email.MinimumWidth = 6;
            this.Cli_Email.Name = "Cli_Email";
            this.Cli_Email.Width = 125;
            // 
            // Date_Vidange
            // 
            this.Date_Vidange.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date_Vidange.DataPropertyName = "Date_Vidange";
            this.Date_Vidange.FillWeight = 52.33957F;
            this.Date_Vidange.HeaderText = "Vidange";
            this.Date_Vidange.MinimumWidth = 6;
            this.Date_Vidange.Name = "Date_Vidange";
            this.Date_Vidange.Width = 120;
            // 
            // RC
            // 
            this.RC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RC.DataPropertyName = "RC";
            this.RC.HeaderText = "RC";
            this.RC.MinimumWidth = 6;
            this.RC.Name = "RC";
            this.RC.Width = 70;
            // 
            // ICE
            // 
            this.ICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ICE.DataPropertyName = "ICE";
            this.ICE.HeaderText = "ICE";
            this.ICE.MinimumWidth = 6;
            this.ICE.Name = "ICE";
            this.ICE.Width = 70;
            // 
            // PATENTE
            // 
            this.PATENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PATENTE.DataPropertyName = "PATENTE";
            this.PATENTE.HeaderText = "Patente";
            this.PATENTE.MinimumWidth = 6;
            this.PATENTE.Name = "PATENTE";
            this.PATENTE.Width = 70;
            // 
            // ID_FISCAL
            // 
            this.ID_FISCAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_FISCAL.DataPropertyName = "ID_FISCAL";
            this.ID_FISCAL.HeaderText = "IF";
            this.ID_FISCAL.MinimumWidth = 6;
            this.ID_FISCAL.Name = "ID_FISCAL";
            this.ID_FISCAL.Width = 70;
            // 
            // CNSS
            // 
            this.CNSS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNSS.DataPropertyName = "CNSS";
            this.CNSS.HeaderText = "CNSS";
            this.CNSS.MinimumWidth = 6;
            this.CNSS.Name = "CNSS";
            this.CNSS.Width = 70;
            // 
            // Util_Nom
            // 
            this.Util_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Util_Nom.DataPropertyName = "Util_Nom";
            this.Util_Nom.FillWeight = 52.33957F;
            this.Util_Nom.HeaderText = "Utilisateur";
            this.Util_Nom.MinimumWidth = 6;
            this.Util_Nom.Name = "Util_Nom";
            this.Util_Nom.Width = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(647, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 51);
            this.label7.TabIndex = 60;
            this.label7.Text = "La Liste Des Clients";
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
            this.supprimerbtn.Location = new System.Drawing.Point(1416, 89);
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
            this.supprimerbtn.Size = new System.Drawing.Size(165, 59);
            this.supprimerbtn.TabIndex = 67;
            this.supprimerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimerbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.supprimerbtn.TextMarginLeft = 0;
            this.supprimerbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.supprimerbtn.UseDefaultRadiusAndThickness = true;
            this.supprimerbtn.Visible = false;
            this.supprimerbtn.Click += new System.EventHandler(this.supprimerbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = "Recherche   :";
            // 
            // cintxtbox
            // 
            this.cintxtbox.AcceptsReturn = false;
            this.cintxtbox.AcceptsTab = false;
            this.cintxtbox.AnimationSpeed = 200;
            this.cintxtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cintxtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cintxtbox.BackColor = System.Drawing.Color.Transparent;
            this.cintxtbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cintxtbox.BackgroundImage")));
            this.cintxtbox.BorderColorActive = System.Drawing.Color.Black;
            this.cintxtbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cintxtbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.cintxtbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.cintxtbox.BorderRadius = 1;
            this.cintxtbox.BorderThickness = 2;
            this.cintxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cintxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cintxtbox.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cintxtbox.DefaultText = "";
            this.cintxtbox.FillColor = System.Drawing.Color.White;
            this.cintxtbox.HideSelection = true;
            this.cintxtbox.IconLeft = null;
            this.cintxtbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.cintxtbox.IconPadding = 10;
            this.cintxtbox.IconRight = null;
            this.cintxtbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.cintxtbox.Lines = new string[0];
            this.cintxtbox.Location = new System.Drawing.Point(213, 102);
            this.cintxtbox.Margin = new System.Windows.Forms.Padding(0);
            this.cintxtbox.MaximumSize = new System.Drawing.Size(543, 46);
            this.cintxtbox.MaxLength = 32767;
            this.cintxtbox.MinimumSize = new System.Drawing.Size(543, 46);
            this.cintxtbox.Modified = false;
            this.cintxtbox.Multiline = false;
            this.cintxtbox.Name = "cintxtbox";
            stateProperties1.BorderColor = System.Drawing.Color.Black;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cintxtbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.cintxtbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cintxtbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cintxtbox.OnIdleState = stateProperties4;
            this.cintxtbox.Padding = new System.Windows.Forms.Padding(3);
            this.cintxtbox.PasswordChar = '\0';
            this.cintxtbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.cintxtbox.PlaceholderText = "Par: Id - Nom - Type - Utilisateur";
            this.cintxtbox.ReadOnly = false;
            this.cintxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cintxtbox.SelectedText = "";
            this.cintxtbox.SelectionLength = 0;
            this.cintxtbox.SelectionStart = 0;
            this.cintxtbox.ShortcutsEnabled = true;
            this.cintxtbox.Size = new System.Drawing.Size(543, 46);
            this.cintxtbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.cintxtbox.TabIndex = 65;
            this.cintxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cintxtbox.TextMarginBottom = 0;
            this.cintxtbox.TextMarginLeft = 7;
            this.cintxtbox.TextMarginTop = 0;
            this.cintxtbox.TextPlaceholder = "Par: Id - Nom - Type - Utilisateur";
            this.cintxtbox.UseSystemPasswordChar = false;
            this.cintxtbox.WordWrap = true;
            this.cintxtbox.TextChange += new System.EventHandler(this.cintxtbox_TextChange);
            // 
            // ClientGridviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1605, 945);
            this.Controls.Add(this.supprimerbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cintxtbox);
            this.Controls.Add(this.clientgrid);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1605, 945);
            this.Name = "ClientGridviewForm";
            this.Text = "Liste Des Clients";
            this.Load += new System.EventHandler(this.ClientGridviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView clientgrid;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton supprimerbtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox cintxtbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailcli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Vidange;
        private System.Windows.Forms.DataGridViewTextBoxColumn RC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FISCAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_Nom;
    }
}