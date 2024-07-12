namespace Younes_Entreprise
{
    partial class StockGridviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockGridviewForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.cherchetxtb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chercherbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.prodgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ENT_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteParUnite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_dachat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGroupBox2.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(535, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(622, 51);
            this.label7.TabIndex = 71;
            this.label7.Text = "Liste des Nouvelles Quantités";
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.Gold;
            this.bunifuGroupBox2.BorderRadius = 5;
            this.bunifuGroupBox2.BorderThickness = 3;
            this.bunifuGroupBox2.Controls.Add(this.cherchetxtb);
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox2.ForeColor = System.Drawing.Color.White;
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 30;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(672, 77);
            this.bunifuGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.bunifuGroupBox2.Size = new System.Drawing.Size(907, 168);
            this.bunifuGroupBox2.TabIndex = 95;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "Recherche Génerale :";
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
            this.cherchetxtb.ForeColor = System.Drawing.Color.Black;
            this.cherchetxtb.HideSelection = true;
            this.cherchetxtb.IconLeft = null;
            this.cherchetxtb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.cherchetxtb.IconPadding = 10;
            this.cherchetxtb.IconRight = null;
            this.cherchetxtb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.cherchetxtb.Lines = new string[0];
            this.cherchetxtb.Location = new System.Drawing.Point(49, 66);
            this.cherchetxtb.Margin = new System.Windows.Forms.Padding(0);
            this.cherchetxtb.MaximumSize = new System.Drawing.Size(818, 45);
            this.cherchetxtb.MaxLength = 32767;
            this.cherchetxtb.MinimumSize = new System.Drawing.Size(818, 45);
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
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cherchetxtb.OnIdleState = stateProperties4;
            this.cherchetxtb.Padding = new System.Windows.Forms.Padding(2);
            this.cherchetxtb.PasswordChar = '\0';
            this.cherchetxtb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.cherchetxtb.PlaceholderText = "Par : Reference - Designation - Categorie - Description - Fournisseur";
            this.cherchetxtb.ReadOnly = false;
            this.cherchetxtb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cherchetxtb.SelectedText = "";
            this.cherchetxtb.SelectionLength = 0;
            this.cherchetxtb.SelectionStart = 0;
            this.cherchetxtb.ShortcutsEnabled = true;
            this.cherchetxtb.Size = new System.Drawing.Size(818, 45);
            this.cherchetxtb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.cherchetxtb.TabIndex = 146;
            this.cherchetxtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cherchetxtb.TextMarginBottom = 0;
            this.cherchetxtb.TextMarginLeft = 8;
            this.cherchetxtb.TextMarginTop = 0;
            this.cherchetxtb.TextPlaceholder = "Par : Reference - Designation - Categorie - Description - Fournisseur";
            this.cherchetxtb.UseSystemPasswordChar = false;
            this.cherchetxtb.WordWrap = true;
            this.cherchetxtb.TextChange += new System.EventHandler(this.cherchetxtb_TextChange);
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.Gold;
            this.bunifuGroupBox1.BorderRadius = 5;
            this.bunifuGroupBox1.BorderThickness = 3;
            this.bunifuGroupBox1.Controls.Add(this.dateTimePicker2);
            this.bunifuGroupBox1.Controls.Add(this.dateTimePicker1);
            this.bunifuGroupBox1.Controls.Add(this.chercherbtn);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.White;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 30;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(21, 77);
            this.bunifuGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.bunifuGroupBox1.Size = new System.Drawing.Size(618, 168);
            this.bunifuGroupBox1.TabIndex = 94;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Recherche Par Date :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(56, 110);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.MaximumSize = new System.Drawing.Size(346, 34);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(346, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(346, 34);
            this.dateTimePicker2.TabIndex = 99;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(346, 34);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(346, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(346, 34);
            this.dateTimePicker1.TabIndex = 98;
            // 
            // chercherbtn
            // 
            this.chercherbtn.AllowAnimations = true;
            this.chercherbtn.AllowMouseEffects = true;
            this.chercherbtn.AllowToggling = false;
            this.chercherbtn.AnimationSpeed = 200;
            this.chercherbtn.AutoGenerateColors = false;
            this.chercherbtn.AutoRoundBorders = false;
            this.chercherbtn.AutoSizeLeftIcon = true;
            this.chercherbtn.AutoSizeRightIcon = true;
            this.chercherbtn.BackColor = System.Drawing.Color.Transparent;
            this.chercherbtn.BackColor1 = System.Drawing.SystemColors.WindowFrame;
            this.chercherbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chercherbtn.BackgroundImage")));
            this.chercherbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chercherbtn.ButtonText = "Chercher";
            this.chercherbtn.ButtonTextMarginLeft = 0;
            this.chercherbtn.ColorContrastOnClick = 45;
            this.chercherbtn.ColorContrastOnHover = 45;
            this.chercherbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.chercherbtn.CustomizableEdges = borderEdges1;
            this.chercherbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.chercherbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.chercherbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.chercherbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.chercherbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.chercherbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.chercherbtn.ForeColor = System.Drawing.Color.White;
            this.chercherbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chercherbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.chercherbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.chercherbtn.IconMarginLeft = 11;
            this.chercherbtn.IconPadding = 10;
            this.chercherbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chercherbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.chercherbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.chercherbtn.IconSize = 25;
            this.chercherbtn.IdleBorderColor = System.Drawing.Color.Transparent;
            this.chercherbtn.IdleBorderRadius = 1;
            this.chercherbtn.IdleBorderThickness = 1;
            this.chercherbtn.IdleFillColor = System.Drawing.SystemColors.WindowFrame;
            this.chercherbtn.IdleIconLeftImage = null;
            this.chercherbtn.IdleIconRightImage = null;
            this.chercherbtn.IndicateFocus = false;
            this.chercherbtn.Location = new System.Drawing.Point(441, 59);
            this.chercherbtn.Margin = new System.Windows.Forms.Padding(2);
            this.chercherbtn.Name = "chercherbtn";
            this.chercherbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.chercherbtn.OnDisabledState.BorderRadius = 1;
            this.chercherbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chercherbtn.OnDisabledState.BorderThickness = 1;
            this.chercherbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.chercherbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.chercherbtn.OnDisabledState.IconLeftImage = null;
            this.chercherbtn.OnDisabledState.IconRightImage = null;
            this.chercherbtn.onHoverState.BorderColor = System.Drawing.Color.Yellow;
            this.chercherbtn.onHoverState.BorderRadius = 1;
            this.chercherbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chercherbtn.onHoverState.BorderThickness = 1;
            this.chercherbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.chercherbtn.onHoverState.ForeColor = System.Drawing.Color.Yellow;
            this.chercherbtn.onHoverState.IconLeftImage = null;
            this.chercherbtn.onHoverState.IconRightImage = null;
            this.chercherbtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.chercherbtn.OnIdleState.BorderRadius = 1;
            this.chercherbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chercherbtn.OnIdleState.BorderThickness = 1;
            this.chercherbtn.OnIdleState.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.chercherbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.chercherbtn.OnIdleState.IconLeftImage = null;
            this.chercherbtn.OnIdleState.IconRightImage = null;
            this.chercherbtn.OnPressedState.BorderColor = System.Drawing.Color.Yellow;
            this.chercherbtn.OnPressedState.BorderRadius = 1;
            this.chercherbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.chercherbtn.OnPressedState.BorderThickness = 1;
            this.chercherbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.chercherbtn.OnPressedState.ForeColor = System.Drawing.Color.Yellow;
            this.chercherbtn.OnPressedState.IconLeftImage = null;
            this.chercherbtn.OnPressedState.IconRightImage = null;
            this.chercherbtn.Size = new System.Drawing.Size(150, 67);
            this.chercherbtn.TabIndex = 97;
            this.chercherbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chercherbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.chercherbtn.TextMarginLeft = 0;
            this.chercherbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.chercherbtn.UseDefaultRadiusAndThickness = true;
            this.chercherbtn.Click += new System.EventHandler(this.chercherbtn_Click);
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
            this.ENT_id,
            this.Prod_id,
            this.Pro_Reference,
            this.Pro_Designation,
            this.DATE,
            this.Cat_id,
            this.QteParUnite,
            this.Prix_dachat,
            this.Prix_Vente,
            this.Taxe,
            this.Four_Nom,
            this.Pro_Description});
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
            this.prodgrid.Location = new System.Drawing.Point(21, 267);
            this.prodgrid.Margin = new System.Windows.Forms.Padding(0);
            this.prodgrid.Name = "prodgrid";
            this.prodgrid.RowHeadersVisible = false;
            this.prodgrid.RowHeadersWidth = 51;
            this.prodgrid.RowTemplate.Height = 40;
            this.prodgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodgrid.Size = new System.Drawing.Size(1558, 651);
            this.prodgrid.TabIndex = 148;
            this.prodgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // ENT_id
            // 
            this.ENT_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ENT_id.DataPropertyName = "Ent_id";
            this.ENT_id.HeaderText = "ID";
            this.ENT_id.MinimumWidth = 6;
            this.ENT_id.Name = "ENT_id";
            this.ENT_id.Width = 70;
            // 
            // Prod_id
            // 
            this.Prod_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Prod_id.DataPropertyName = "Pro_id";
            this.Prod_id.HeaderText = "Prod id";
            this.Prod_id.MinimumWidth = 3;
            this.Prod_id.Name = "Prod_id";
            this.Prod_id.Width = 90;
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
            // DATE
            // 
            this.DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DATE.DataPropertyName = "Ent_Date";
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 6;
            this.DATE.Name = "DATE";
            this.DATE.Width = 120;
            // 
            // Cat_id
            // 
            this.Cat_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cat_id.DataPropertyName = "Cat_Nom";
            this.Cat_id.HeaderText = "Categorie";
            this.Cat_id.MinimumWidth = 6;
            this.Cat_id.Name = "Cat_id";
            // 
            // QteParUnite
            // 
            this.QteParUnite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QteParUnite.DataPropertyName = "QTE";
            this.QteParUnite.HeaderText = "Quantité";
            this.QteParUnite.MinimumWidth = 6;
            this.QteParUnite.Name = "QteParUnite";
            // 
            // Prix_dachat
            // 
            this.Prix_dachat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Prix_dachat.DataPropertyName = "prix_dachat";
            this.Prix_dachat.HeaderText = "PA";
            this.Prix_dachat.MinimumWidth = 6;
            this.Prix_dachat.Name = "Prix_dachat";
            this.Prix_dachat.Width = 110;
            // 
            // Prix_Vente
            // 
            this.Prix_Vente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Prix_Vente.DataPropertyName = "Prix_Vente";
            this.Prix_Vente.HeaderText = "PV";
            this.Prix_Vente.MinimumWidth = 6;
            this.Prix_Vente.Name = "Prix_Vente";
            this.Prix_Vente.Width = 110;
            // 
            // Taxe
            // 
            this.Taxe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Taxe.DataPropertyName = "Taxe";
            this.Taxe.HeaderText = "TVA";
            this.Taxe.MinimumWidth = 6;
            this.Taxe.Name = "Taxe";
            this.Taxe.Width = 110;
            // 
            // Four_Nom
            // 
            this.Four_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Four_Nom.DataPropertyName = "Four_Nom";
            this.Four_Nom.HeaderText = "Fournisseur";
            this.Four_Nom.MinimumWidth = 6;
            this.Four_Nom.Name = "Four_Nom";
            this.Four_Nom.Width = 120;
            // 
            // Pro_Description
            // 
            this.Pro_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pro_Description.DataPropertyName = "Pro_Description";
            this.Pro_Description.HeaderText = "Description";
            this.Pro_Description.MinimumWidth = 6;
            this.Pro_Description.Name = "Pro_Description";
            this.Pro_Description.Width = 120;
            // 
            // StockGridviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1605, 945);
            this.Controls.Add(this.prodgrid);
            this.Controls.Add(this.bunifuGroupBox2);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1605, 945);
            this.Name = "StockGridviewForm";
            this.Text = "Liste Des Stock";
            this.Load += new System.EventHandler(this.StockGridviewForm_Load);
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton chercherbtn;
        private Bunifu.UI.WinForms.BunifuTextBox cherchetxtb;
        private Bunifu.UI.WinForms.BunifuDataGridView prodgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENT_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteParUnite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_dachat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_Vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Description;
    }
}