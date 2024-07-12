namespace Younes_Entreprise
{
    partial class UsersHistoryForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersHistoryForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label7 = new System.Windows.Forms.Label();
            this.HistoryGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chercherbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.supprimerbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(560, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(581, 51);
            this.label7.TabIndex = 73;
            this.label7.Text = "Historiques Des Utilisateurs";
            // 
            // HistoryGrid
            // 
            this.HistoryGrid.AllowCustomTheming = true;
            this.HistoryGrid.AllowUserToAddRows = false;
            this.HistoryGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.HistoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryGrid.BackgroundColor = System.Drawing.Color.White;
            this.HistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HistoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HistoryGrid.ColumnHeadersHeight = 40;
            this.HistoryGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.HistoryGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.HistoryGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.HistoryGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.HistoryGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.HistoryGrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.HistoryGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.HistoryGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.HistoryGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.HistoryGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.HistoryGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.HistoryGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.HistoryGrid.CurrentTheme.Name = null;
            this.HistoryGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.HistoryGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.HistoryGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.HistoryGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.HistoryGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HistoryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.HistoryGrid.EnableHeadersVisualStyles = false;
            this.HistoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.HistoryGrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.HistoryGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.HistoryGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.HistoryGrid.Location = new System.Drawing.Point(24, 162);
            this.HistoryGrid.Margin = new System.Windows.Forms.Padding(0);
            this.HistoryGrid.Name = "HistoryGrid";
            this.HistoryGrid.RowHeadersVisible = false;
            this.HistoryGrid.RowHeadersWidth = 51;
            this.HistoryGrid.RowTemplate.Height = 40;
            this.HistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistoryGrid.Size = new System.Drawing.Size(1558, 796);
            this.HistoryGrid.TabIndex = 95;
            this.HistoryGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 97;
            this.label1.Text = "Recherche par Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(703, 98);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.MaximumSize = new System.Drawing.Size(346, 34);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(346, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(346, 34);
            this.dateTimePicker2.TabIndex = 101;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 98);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(346, 34);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(346, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(346, 34);
            this.dateTimePicker1.TabIndex = 100;
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
            this.chercherbtn.Location = new System.Drawing.Point(1224, 80);
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
            this.chercherbtn.Size = new System.Drawing.Size(167, 60);
            this.chercherbtn.TabIndex = 102;
            this.chercherbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chercherbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.chercherbtn.TextMarginLeft = 0;
            this.chercherbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.chercherbtn.UseDefaultRadiusAndThickness = true;
            this.chercherbtn.Click += new System.EventHandler(this.chercherbtn_Click);
            // 
            // close
            // 
            this.close.ActiveImage = global::Younes_Entreprise.Properties.Resources.xx_50px;
            this.close.AllowAnimations = true;
            this.close.AllowBuffering = false;
            this.close.AllowToggling = false;
            this.close.AllowZooming = true;
            this.close.AllowZoomingOnFocus = false;
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("close.ErrorImage")));
            this.close.FadeWhenInactive = false;
            this.close.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.close.Image = global::Younes_Entreprise.Properties.Resources.x_50px;
            this.close.ImageActive = global::Younes_Entreprise.Properties.Resources.xx_50px;
            this.close.ImageLocation = null;
            this.close.ImageMargin = 0;
            this.close.ImageSize = new System.Drawing.Size(40, 40);
            this.close.ImageZoomSize = new System.Drawing.Size(41, 41);
            this.close.InitialImage = ((System.Drawing.Image)(resources.GetObject("close.InitialImage")));
            this.close.Location = new System.Drawing.Point(1550, 11);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Rotation = 0;
            this.close.ShowActiveImage = true;
            this.close.ShowCursorChanges = true;
            this.close.ShowImageBorders = true;
            this.close.ShowSizeMarkers = false;
            this.close.Size = new System.Drawing.Size(41, 41);
            this.close.TabIndex = 103;
            this.close.ToolTipText = "";
            this.close.WaitOnLoad = false;
            this.close.Zoom = 0;
            this.close.ZoomSpeed = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.supprimerbtn.CustomizableEdges = borderEdges2;
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
            this.supprimerbtn.Location = new System.Drawing.Point(1417, 80);
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
            this.supprimerbtn.TabIndex = 105;
            this.supprimerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimerbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.supprimerbtn.TextMarginLeft = 0;
            this.supprimerbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.supprimerbtn.UseDefaultRadiusAndThickness = true;
            this.supprimerbtn.Click += new System.EventHandler(this.supprimerbtn_Click);
            // 
            // UsersHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1610, 950);
            this.Controls.Add(this.supprimerbtn);
            this.Controls.Add(this.close);
            this.Controls.Add(this.chercherbtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoryGrid);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1610, 950);
            this.MinimumSize = new System.Drawing.Size(1610, 950);
            this.Name = "UsersHistoryForm";
            this.Text = "UsersHistoryForm";
            this.Load += new System.EventHandler(this.UsersHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuDataGridView HistoryGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton chercherbtn;
        private Bunifu.UI.WinForms.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton supprimerbtn;
    }
}