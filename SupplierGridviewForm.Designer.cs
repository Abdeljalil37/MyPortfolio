namespace Younes_Entreprise
{
    partial class SupplierGridviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierGridviewForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.fourgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Four_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Phone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.supprimerbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cintxtbox = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fourgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // fourgrid
            // 
            this.fourgrid.AllowCustomTheming = true;
            this.fourgrid.AllowUserToAddRows = false;
            this.fourgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.fourgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fourgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fourgrid.BackgroundColor = System.Drawing.Color.White;
            this.fourgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fourgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.fourgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fourgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fourgrid.ColumnHeadersHeight = 40;
            this.fourgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Four_id,
            this.Four_Nom,
            this.Four_Details,
            this.Four_Phone,
            this.Four_Phone2,
            this.Four_Phone3,
            this.Four_Adresse,
            this.Four_Ville,
            this.Four_Email});
            this.fourgrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.fourgrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.fourgrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.fourgrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.fourgrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.fourgrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.fourgrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.fourgrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.fourgrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.fourgrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.fourgrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.fourgrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.fourgrid.CurrentTheme.Name = null;
            this.fourgrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.fourgrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.fourgrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.fourgrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.fourgrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fourgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.fourgrid.EnableHeadersVisualStyles = false;
            this.fourgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.fourgrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.fourgrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.fourgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.fourgrid.Location = new System.Drawing.Point(25, 152);
            this.fourgrid.Margin = new System.Windows.Forms.Padding(0);
            this.fourgrid.Name = "fourgrid";
            this.fourgrid.RowHeadersVisible = false;
            this.fourgrid.RowHeadersWidth = 51;
            this.fourgrid.RowTemplate.Height = 60;
            this.fourgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fourgrid.Size = new System.Drawing.Size(1554, 769);
            this.fourgrid.TabIndex = 61;
            this.fourgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.fourgrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.fourgrid_CellMouseEnter);
            this.fourgrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.fourgrid_CellMouseLeave);
            // 
            // Four_id
            // 
            this.Four_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_id.DataPropertyName = "Four_id";
            this.Four_id.HeaderText = "ID";
            this.Four_id.MinimumWidth = 3;
            this.Four_id.Name = "Four_id";
            this.Four_id.Width = 80;
            // 
            // Four_Nom
            // 
            this.Four_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Nom.DataPropertyName = "Four_Nom";
            this.Four_Nom.HeaderText = "Nom";
            this.Four_Nom.MinimumWidth = 6;
            this.Four_Nom.Name = "Four_Nom";
            this.Four_Nom.Width = 250;
            // 
            // Four_Details
            // 
            this.Four_Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Details.DataPropertyName = "Four_Details";
            this.Four_Details.HeaderText = "Details";
            this.Four_Details.MinimumWidth = 6;
            this.Four_Details.Name = "Four_Details";
            this.Four_Details.Width = 444;
            // 
            // Four_Phone
            // 
            this.Four_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Phone.DataPropertyName = "Four_Phone";
            this.Four_Phone.HeaderText = "Phone 1";
            this.Four_Phone.MinimumWidth = 6;
            this.Four_Phone.Name = "Four_Phone";
            this.Four_Phone.Width = 120;
            // 
            // Four_Phone2
            // 
            this.Four_Phone2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Phone2.DataPropertyName = "Four_Phone2";
            this.Four_Phone2.HeaderText = "Phone 2";
            this.Four_Phone2.MinimumWidth = 6;
            this.Four_Phone2.Name = "Four_Phone2";
            this.Four_Phone2.Width = 120;
            // 
            // Four_Phone3
            // 
            this.Four_Phone3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Phone3.DataPropertyName = "Four_Phone3";
            this.Four_Phone3.HeaderText = "Phone 3";
            this.Four_Phone3.MinimumWidth = 6;
            this.Four_Phone3.Name = "Four_Phone3";
            this.Four_Phone3.Width = 120;
            // 
            // Four_Adresse
            // 
            this.Four_Adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Adresse.DataPropertyName = "Four_Adresse";
            this.Four_Adresse.HeaderText = "Adresse";
            this.Four_Adresse.MinimumWidth = 6;
            this.Four_Adresse.Name = "Four_Adresse";
            this.Four_Adresse.Width = 150;
            // 
            // Four_Ville
            // 
            this.Four_Ville.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Ville.DataPropertyName = "Four_Ville";
            this.Four_Ville.HeaderText = "Adresse 2";
            this.Four_Ville.MinimumWidth = 6;
            this.Four_Ville.Name = "Four_Ville";
            this.Four_Ville.Width = 150;
            // 
            // Four_Email
            // 
            this.Four_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Email.DataPropertyName = "Four_Email";
            this.Four_Email.HeaderText = "Email";
            this.Four_Email.MinimumWidth = 6;
            this.Four_Email.Name = "Four_Email";
            this.Four_Email.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(575, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(547, 51);
            this.label7.TabIndex = 60;
            this.label7.Text = "La Liste Des Fournisseurs";
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
            this.supprimerbtn.Location = new System.Drawing.Point(1414, 78);
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
            this.label1.Location = new System.Drawing.Point(19, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = "Recherche :";
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
            this.cintxtbox.Location = new System.Drawing.Point(200, 93);
            this.cintxtbox.Margin = new System.Windows.Forms.Padding(0);
            this.cintxtbox.MaximumSize = new System.Drawing.Size(380, 45);
            this.cintxtbox.MaxLength = 32767;
            this.cintxtbox.MinimumSize = new System.Drawing.Size(380, 45);
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
            this.cintxtbox.PlaceholderText = "Par : ID - Nom";
            this.cintxtbox.ReadOnly = false;
            this.cintxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cintxtbox.SelectedText = "";
            this.cintxtbox.SelectionLength = 0;
            this.cintxtbox.SelectionStart = 0;
            this.cintxtbox.ShortcutsEnabled = true;
            this.cintxtbox.Size = new System.Drawing.Size(380, 45);
            this.cintxtbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.cintxtbox.TabIndex = 65;
            this.cintxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cintxtbox.TextMarginBottom = 0;
            this.cintxtbox.TextMarginLeft = 7;
            this.cintxtbox.TextMarginTop = 0;
            this.cintxtbox.TextPlaceholder = "Par : ID - Nom";
            this.cintxtbox.UseSystemPasswordChar = false;
            this.cintxtbox.WordWrap = true;
            this.cintxtbox.TextChange += new System.EventHandler(this.cintxtbox_TextChanged);
            // 
            // SupplierGridviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1605, 945);
            this.Controls.Add(this.supprimerbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cintxtbox);
            this.Controls.Add(this.fourgrid);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1605, 945);
            this.Name = "SupplierGridviewForm";
            this.Text = "Liste Des Fournisseurs";
            this.Load += new System.EventHandler(this.SupplierGridviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fourgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView fourgrid;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton supprimerbtn;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox cintxtbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Phone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Email;
    }
}