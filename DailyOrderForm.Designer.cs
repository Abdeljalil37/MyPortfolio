namespace Younes_Entreprise
{
    partial class DailyOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyOrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Cmd_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Util_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmd_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmdgrid)).BeginInit();
            this.SuspendLayout();
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
            this.close.Location = new System.Drawing.Point(1557, 12);
            this.close.Name = "close";
            this.close.Rotation = 0;
            this.close.ShowActiveImage = true;
            this.close.ShowCursorChanges = true;
            this.close.ShowImageBorders = true;
            this.close.ShowSizeMarkers = false;
            this.close.Size = new System.Drawing.Size(41, 41);
            this.close.TabIndex = 75;
            this.close.ToolTipText = "";
            this.close.WaitOnLoad = false;
            this.close.Zoom = 0;
            this.close.ZoomSpeed = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(628, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 51);
            this.label7.TabIndex = 74;
            this.label7.Text = "Nouvelles Ventes";
            // 
            // cmdgrid
            // 
            this.cmdgrid.AllowCustomTheming = true;
            this.cmdgrid.AllowUserToAddRows = false;
            this.cmdgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.cmdgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cmdgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cmdgrid.BackgroundColor = System.Drawing.Color.White;
            this.cmdgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cmdgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmdgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cmdgrid.ColumnHeadersHeight = 40;
            this.cmdgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cmd_id,
            this.Cli_id,
            this.Util_id,
            this.Cmd_Date,
            this.montant});
            this.cmdgrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.cmdgrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdgrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.cmdgrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.cmdgrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdgrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.cmdgrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.cmdgrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.cmdgrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.cmdgrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.cmdgrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.cmdgrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.cmdgrid.CurrentTheme.Name = null;
            this.cmdgrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cmdgrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdgrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.cmdgrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.cmdgrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cmdgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.cmdgrid.EnableHeadersVisualStyles = false;
            this.cmdgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.cmdgrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.cmdgrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.cmdgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.cmdgrid.Location = new System.Drawing.Point(23, 116);
            this.cmdgrid.Margin = new System.Windows.Forms.Padding(0);
            this.cmdgrid.Name = "cmdgrid";
            this.cmdgrid.RowHeadersVisible = false;
            this.cmdgrid.RowHeadersWidth = 51;
            this.cmdgrid.RowTemplate.Height = 40;
            this.cmdgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cmdgrid.Size = new System.Drawing.Size(1560, 837);
            this.cmdgrid.TabIndex = 76;
            this.cmdgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Cmd_id
            // 
            this.Cmd_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cmd_id.DataPropertyName = "Cmd_id";
            this.Cmd_id.HeaderText = "ID";
            this.Cmd_id.MinimumWidth = 3;
            this.Cmd_id.Name = "Cmd_id";
            this.Cmd_id.Width = 120;
            // 
            // Cli_id
            // 
            this.Cli_id.DataPropertyName = "Cli_Nom";
            this.Cli_id.HeaderText = "Client";
            this.Cli_id.MinimumWidth = 6;
            this.Cli_id.Name = "Cli_id";
            // 
            // Util_id
            // 
            this.Util_id.DataPropertyName = "Util_Nom";
            this.Util_id.HeaderText = "Utilisateur";
            this.Util_id.MinimumWidth = 6;
            this.Util_id.Name = "Util_id";
            // 
            // Cmd_Date
            // 
            this.Cmd_Date.DataPropertyName = "Cmd_Date";
            this.Cmd_Date.HeaderText = "Vente Date";
            this.Cmd_Date.MinimumWidth = 6;
            this.Cmd_Date.Name = "Cmd_Date";
            // 
            // montant
            // 
            this.montant.DataPropertyName = "montant";
            this.montant.HeaderText = "Montant";
            this.montant.MinimumWidth = 6;
            this.montant.Name = "montant";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // DailyOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1610, 980);
            this.Controls.Add(this.cmdgrid);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1610, 980);
            this.MinimumSize = new System.Drawing.Size(1610, 980);
            this.Name = "DailyOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Dashboard";
            this.Load += new System.EventHandler(this.DailyOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton close;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuDataGridView cmdgrid;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmd_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmd_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
    }
}