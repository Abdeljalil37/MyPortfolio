namespace Younes_Entreprise
{
    partial class AlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            this.prodgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitesEnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_dachat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prodgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // prodgrid
            // 
            this.prodgrid.AllowCustomTheming = true;
            this.prodgrid.AllowUserToAddRows = false;
            this.prodgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.prodgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prodgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.UnitesEnStock,
            this.Prix_dachat,
            this.Pro_Description});
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.prodgrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.prodgrid.CurrentTheme.BackColor = System.Drawing.Color.Black;
            this.prodgrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.prodgrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.prodgrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.prodgrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.prodgrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.prodgrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.prodgrid.CurrentTheme.Name = null;
            this.prodgrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.prodgrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.prodgrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.prodgrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.prodgrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodgrid.EnableHeadersVisualStyles = false;
            this.prodgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.prodgrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.prodgrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.prodgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.prodgrid.Location = new System.Drawing.Point(23, 112);
            this.prodgrid.Margin = new System.Windows.Forms.Padding(0);
            this.prodgrid.Name = "prodgrid";
            this.prodgrid.RowHeadersVisible = false;
            this.prodgrid.RowHeadersWidth = 51;
            this.prodgrid.RowTemplate.Height = 40;
            this.prodgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodgrid.Size = new System.Drawing.Size(1560, 840);
            this.prodgrid.TabIndex = 72;
            this.prodgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Prod_id
            // 
            this.Prod_id.DataPropertyName = "Pro_id";
            this.Prod_id.HeaderText = "Prod_id";
            this.Prod_id.MinimumWidth = 3;
            this.Prod_id.Name = "Prod_id";
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
            // UnitesEnStock
            // 
            this.UnitesEnStock.DataPropertyName = "UnitesEnStock";
            this.UnitesEnStock.HeaderText = "Quantité";
            this.UnitesEnStock.MinimumWidth = 6;
            this.UnitesEnStock.Name = "UnitesEnStock";
            // 
            // Prix_dachat
            // 
            this.Prix_dachat.DataPropertyName = "Prix_dachat";
            this.Prix_dachat.HeaderText = "PA";
            this.Prix_dachat.MinimumWidth = 6;
            this.Prix_dachat.Name = "Prix_dachat";
            // 
            // Pro_Description
            // 
            this.Pro_Description.DataPropertyName = "Pro_Description";
            this.Pro_Description.HeaderText = "Description";
            this.Pro_Description.MinimumWidth = 6;
            this.Pro_Description.Name = "Pro_Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(697, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 51);
            this.label7.TabIndex = 68;
            this.label7.Text = "Alert Produits";
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
            this.close.Location = new System.Drawing.Point(1559, 10);
            this.close.Name = "close";
            this.close.Rotation = 0;
            this.close.ShowActiveImage = true;
            this.close.ShowCursorChanges = true;
            this.close.ShowImageBorders = true;
            this.close.ShowSizeMarkers = false;
            this.close.Size = new System.Drawing.Size(41, 41);
            this.close.TabIndex = 73;
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
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1610, 980);
            this.Controls.Add(this.close);
            this.Controls.Add(this.prodgrid);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1610, 980);
            this.MinimumSize = new System.Drawing.Size(1610, 980);
            this.Name = "AlertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertForm";
            this.Load += new System.EventHandler(this.AlertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView prodgrid;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitesEnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_dachat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Description;
    }
}