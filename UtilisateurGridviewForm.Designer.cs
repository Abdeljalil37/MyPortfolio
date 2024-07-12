namespace Younes_Entreprise
{
    partial class UtilisateurGridviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilisateurGridviewForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.cintxtbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Utlisiateurgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Util_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util_Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.supprimerbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.Utlisiateurgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 57;
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
            this.cintxtbox.Location = new System.Drawing.Point(189, 107);
            this.cintxtbox.Margin = new System.Windows.Forms.Padding(0);
            this.cintxtbox.MaximumSize = new System.Drawing.Size(449, 45);
            this.cintxtbox.MaxLength = 32767;
            this.cintxtbox.MinimumSize = new System.Drawing.Size(449, 45);
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
            this.cintxtbox.Padding = new System.Windows.Forms.Padding(5);
            this.cintxtbox.PasswordChar = '\0';
            this.cintxtbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.cintxtbox.PlaceholderText = "Par : ID - Nom - Prenom";
            this.cintxtbox.ReadOnly = false;
            this.cintxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cintxtbox.SelectedText = "";
            this.cintxtbox.SelectionLength = 0;
            this.cintxtbox.SelectionStart = 0;
            this.cintxtbox.ShortcutsEnabled = true;
            this.cintxtbox.Size = new System.Drawing.Size(449, 45);
            this.cintxtbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.cintxtbox.TabIndex = 56;
            this.cintxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cintxtbox.TextMarginBottom = 0;
            this.cintxtbox.TextMarginLeft = 7;
            this.cintxtbox.TextMarginTop = 0;
            this.cintxtbox.TextPlaceholder = "Par : ID - Nom - Prenom";
            this.cintxtbox.UseSystemPasswordChar = false;
            this.cintxtbox.WordWrap = true;
            this.cintxtbox.TextChange += new System.EventHandler(this.cintxtbox_TextChange);
            // 
            // Utlisiateurgrid
            // 
            this.Utlisiateurgrid.AllowCustomTheming = true;
            this.Utlisiateurgrid.AllowUserToAddRows = false;
            this.Utlisiateurgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Utlisiateurgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Utlisiateurgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Utlisiateurgrid.BackgroundColor = System.Drawing.Color.White;
            this.Utlisiateurgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Utlisiateurgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Utlisiateurgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Utlisiateurgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Utlisiateurgrid.ColumnHeadersHeight = 40;
            this.Utlisiateurgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Util_id,
            this.Util_Nom,
            this.Util_Prenom,
            this.Util_Phone,
            this.Util_Adresse,
            this.Util_Email,
            this.Util_Details});
            this.Utlisiateurgrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Utlisiateurgrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Utlisiateurgrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.Utlisiateurgrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Utlisiateurgrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.Utlisiateurgrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Utlisiateurgrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Utlisiateurgrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.Utlisiateurgrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Utlisiateurgrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.Utlisiateurgrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.Utlisiateurgrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Utlisiateurgrid.CurrentTheme.Name = null;
            this.Utlisiateurgrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Utlisiateurgrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Utlisiateurgrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.Utlisiateurgrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Utlisiateurgrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Utlisiateurgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Utlisiateurgrid.EnableHeadersVisualStyles = false;
            this.Utlisiateurgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Utlisiateurgrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.Utlisiateurgrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.Utlisiateurgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.Utlisiateurgrid.Location = new System.Drawing.Point(19, 169);
            this.Utlisiateurgrid.Margin = new System.Windows.Forms.Padding(0);
            this.Utlisiateurgrid.Name = "Utlisiateurgrid";
            this.Utlisiateurgrid.RowHeadersVisible = false;
            this.Utlisiateurgrid.RowHeadersWidth = 51;
            this.Utlisiateurgrid.RowTemplate.Height = 40;
            this.Utlisiateurgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Utlisiateurgrid.Size = new System.Drawing.Size(1560, 752);
            this.Utlisiateurgrid.TabIndex = 55;
            this.Utlisiateurgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Util_id
            // 
            this.Util_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Util_id.DataPropertyName = "Util_id";
            this.Util_id.HeaderText = "ID";
            this.Util_id.MinimumWidth = 3;
            this.Util_id.Name = "Util_id";
            this.Util_id.Width = 125;
            // 
            // Util_Nom
            // 
            this.Util_Nom.DataPropertyName = "Util_Nom";
            this.Util_Nom.HeaderText = "Nom";
            this.Util_Nom.MinimumWidth = 6;
            this.Util_Nom.Name = "Util_Nom";
            // 
            // Util_Prenom
            // 
            this.Util_Prenom.DataPropertyName = "Util_Prenom";
            this.Util_Prenom.HeaderText = "Prenom";
            this.Util_Prenom.MinimumWidth = 6;
            this.Util_Prenom.Name = "Util_Prenom";
            // 
            // Util_Phone
            // 
            this.Util_Phone.DataPropertyName = "Util_Phone";
            this.Util_Phone.HeaderText = "Telephone";
            this.Util_Phone.MinimumWidth = 6;
            this.Util_Phone.Name = "Util_Phone";
            // 
            // Util_Adresse
            // 
            this.Util_Adresse.DataPropertyName = "Util_Adresse";
            this.Util_Adresse.HeaderText = "Adresse";
            this.Util_Adresse.MinimumWidth = 6;
            this.Util_Adresse.Name = "Util_Adresse";
            // 
            // Util_Email
            // 
            this.Util_Email.DataPropertyName = "Util_Email";
            this.Util_Email.HeaderText = "Email";
            this.Util_Email.MinimumWidth = 6;
            this.Util_Email.Name = "Util_Email";
            // 
            // Util_Details
            // 
            this.Util_Details.DataPropertyName = "Util_Details";
            this.Util_Details.HeaderText = "Details";
            this.Util_Details.MinimumWidth = 6;
            this.Util_Details.Name = "Util_Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(612, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(512, 51);
            this.label7.TabIndex = 50;
            this.label7.Text = "La Liste Des Utilisateurs";
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
            this.supprimerbtn.Location = new System.Drawing.Point(1414, 92);
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
            this.supprimerbtn.TabIndex = 58;
            this.supprimerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimerbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.supprimerbtn.TextMarginLeft = 0;
            this.supprimerbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.supprimerbtn.UseDefaultRadiusAndThickness = true;
            this.supprimerbtn.Click += new System.EventHandler(this.supprimerbtn_Click);
            // 
            // UtilisateurGridviewForm
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
            this.Controls.Add(this.Utlisiateurgrid);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UtilisateurGridviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Des Utilisateurs";
            this.Load += new System.EventHandler(this.UtilisateurGridviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Utlisiateurgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox cintxtbox;
        private Bunifu.UI.WinForms.BunifuDataGridView Utlisiateurgrid;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton supprimerbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_Details;
    }
}