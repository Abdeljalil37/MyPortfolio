namespace Younes_Entreprise
{
    partial class ProductGridviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGridviewForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label7 = new System.Windows.Forms.Label();
            this.supprimerbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.prodgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cherchetxtb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteParUnite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_dachat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prodgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(735, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 51);
            this.label7.TabIndex = 60;
            this.label7.Text = "Inventaire";
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
            this.supprimerbtn.Location = new System.Drawing.Point(1416, 82);
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
            this.supprimerbtn.TabIndex = 64;
            this.supprimerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimerbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.supprimerbtn.TextMarginLeft = 0;
            this.supprimerbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.supprimerbtn.UseDefaultRadiusAndThickness = true;
            this.supprimerbtn.Click += new System.EventHandler(this.supprimerbtn_Click);
            // 
            // prodgrid
            // 
            this.prodgrid.AllowCustomTheming = true;
            this.prodgrid.AllowUserToAddRows = false;
            this.prodgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.prodgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prodgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodgrid.BackgroundColor = System.Drawing.Color.White;
            this.prodgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodgrid.ColumnHeadersHeight = 40;
            this.prodgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prod_id,
            this.Pro_Reference,
            this.Pro_Designation,
            this.Cat_id,
            this.Pro_Description,
            this.QteParUnite,
            this.Prix_dachat,
            this.Prix_Vente,
            this.Taxe,
            this.Four_Nom});
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.prodgrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.prodgrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.prodgrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.prodgrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.prodgrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.prodgrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.prodgrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.prodgrid.CurrentTheme.Name = null;
            this.prodgrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.prodgrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.prodgrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.prodgrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.prodgrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodgrid.EnableHeadersVisualStyles = false;
            this.prodgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.prodgrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.prodgrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.prodgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.prodgrid.Location = new System.Drawing.Point(26, 153);
            this.prodgrid.Margin = new System.Windows.Forms.Padding(0);
            this.prodgrid.Name = "prodgrid";
            this.prodgrid.RowHeadersVisible = false;
            this.prodgrid.RowHeadersWidth = 51;
            this.prodgrid.RowTemplate.Height = 40;
            this.prodgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodgrid.Size = new System.Drawing.Size(1555, 768);
            this.prodgrid.TabIndex = 67;
            this.prodgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "Recherche :";
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
            this.cherchetxtb.Location = new System.Drawing.Point(179, 97);
            this.cherchetxtb.Margin = new System.Windows.Forms.Padding(0);
            this.cherchetxtb.MaximumSize = new System.Drawing.Size(707, 45);
            this.cherchetxtb.MaxLength = 32767;
            this.cherchetxtb.MinimumSize = new System.Drawing.Size(707, 45);
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
            this.cherchetxtb.PlaceholderText = "Par : Reference - Designation - Categorie - Description - Fournisseur";
            this.cherchetxtb.ReadOnly = false;
            this.cherchetxtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cherchetxtb.SelectedText = "";
            this.cherchetxtb.SelectionLength = 0;
            this.cherchetxtb.SelectionStart = 0;
            this.cherchetxtb.ShortcutsEnabled = true;
            this.cherchetxtb.Size = new System.Drawing.Size(707, 45);
            this.cherchetxtb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.cherchetxtb.TabIndex = 68;
            this.cherchetxtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cherchetxtb.TextMarginBottom = 0;
            this.cherchetxtb.TextMarginLeft = 8;
            this.cherchetxtb.TextMarginTop = 0;
            this.cherchetxtb.TextPlaceholder = "Par : Reference - Designation - Categorie - Description - Fournisseur";
            this.cherchetxtb.UseSystemPasswordChar = false;
            this.cherchetxtb.WordWrap = true;
            this.cherchetxtb.TextChange += new System.EventHandler(this.cherchetxtb_TextChange);
            // 
            // Prod_id
            // 
            this.Prod_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Prod_id.DataPropertyName = "Pro_id";
            this.Prod_id.HeaderText = "ID";
            this.Prod_id.MinimumWidth = 3;
            this.Prod_id.Name = "Prod_id";
            this.Prod_id.Width = 70;
            // 
            // Pro_Reference
            // 
            this.Pro_Reference.DataPropertyName = "Pro_Reference";
            this.Pro_Reference.HeaderText = "Reference";
            this.Pro_Reference.MinimumWidth = 6;
            this.Pro_Reference.Name = "Pro_Reference";
            // 
            // Pro_Designation
            // 
            this.Pro_Designation.DataPropertyName = "Pro_Designation";
            this.Pro_Designation.HeaderText = "Désignation";
            this.Pro_Designation.MinimumWidth = 6;
            this.Pro_Designation.Name = "Pro_Designation";
            // 
            // Cat_id
            // 
            this.Cat_id.DataPropertyName = "Cat_Nom";
            this.Cat_id.HeaderText = "Categorie";
            this.Cat_id.MinimumWidth = 6;
            this.Cat_id.Name = "Cat_id";
            // 
            // Pro_Description
            // 
            this.Pro_Description.DataPropertyName = "Pro_Description";
            this.Pro_Description.HeaderText = "Description";
            this.Pro_Description.MinimumWidth = 6;
            this.Pro_Description.Name = "Pro_Description";
            // 
            // QteParUnite
            // 
            this.QteParUnite.DataPropertyName = "UnitesEnStock";
            this.QteParUnite.HeaderText = "Quantité";
            this.QteParUnite.MinimumWidth = 6;
            this.QteParUnite.Name = "QteParUnite";
            // 
            // Prix_dachat
            // 
            this.Prix_dachat.DataPropertyName = "Prix_dachat";
            this.Prix_dachat.HeaderText = "PA";
            this.Prix_dachat.MinimumWidth = 6;
            this.Prix_dachat.Name = "Prix_dachat";
            // 
            // Prix_Vente
            // 
            this.Prix_Vente.DataPropertyName = "Prix_Vente";
            this.Prix_Vente.HeaderText = "PV";
            this.Prix_Vente.MinimumWidth = 6;
            this.Prix_Vente.Name = "Prix_Vente";
            // 
            // Taxe
            // 
            this.Taxe.DataPropertyName = "Taxe";
            this.Taxe.HeaderText = "TVA";
            this.Taxe.MinimumWidth = 6;
            this.Taxe.Name = "Taxe";
            // 
            // Four_Nom
            // 
            this.Four_Nom.DataPropertyName = "Four_Nom";
            this.Four_Nom.HeaderText = "Fournisseur";
            this.Four_Nom.MinimumWidth = 6;
            this.Four_Nom.Name = "Four_Nom";
            // 
            // ProductGridviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1605, 945);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cherchetxtb);
            this.Controls.Add(this.prodgrid);
            this.Controls.Add(this.supprimerbtn);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1605, 945);
            this.Name = "ProductGridviewForm";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.ProductGridviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton supprimerbtn;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuDataGridView prodgrid;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox cherchetxtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteParUnite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_dachat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_Vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Nom;
    }
}