namespace Younes_Entreprise
{
    partial class ProfitGridviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitGridviewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.profitgrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.profitgrid)).BeginInit();
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
            this.close.Location = new System.Drawing.Point(1559, 10);
            this.close.Name = "close";
            this.close.Rotation = 0;
            this.close.ShowActiveImage = true;
            this.close.ShowCursorChanges = true;
            this.close.ShowImageBorders = true;
            this.close.ShowSizeMarkers = false;
            this.close.Size = new System.Drawing.Size(41, 41);
            this.close.TabIndex = 74;
            this.close.ToolTipText = "";
            this.close.WaitOnLoad = false;
            this.close.Zoom = 0;
            this.close.ZoomSpeed = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(667, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 51);
            this.label7.TabIndex = 75;
            this.label7.Text = "Profit Quotidien";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // profitgrid
            // 
            this.profitgrid.AllowCustomTheming = true;
            this.profitgrid.AllowUserToAddRows = false;
            this.profitgrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.profitgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.profitgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profitgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profitgrid.BackgroundColor = System.Drawing.Color.White;
            this.profitgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profitgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.profitgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profitgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.profitgrid.ColumnHeadersHeight = 40;
            this.profitgrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.profitgrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.profitgrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.profitgrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.profitgrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.profitgrid.CurrentTheme.BackColor = System.Drawing.Color.Black;
            this.profitgrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.profitgrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Gold;
            this.profitgrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.profitgrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.profitgrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.profitgrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.profitgrid.CurrentTheme.Name = null;
            this.profitgrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.profitgrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.profitgrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.profitgrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.profitgrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profitgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.profitgrid.EnableHeadersVisualStyles = false;
            this.profitgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.profitgrid.HeaderBackColor = System.Drawing.Color.Gold;
            this.profitgrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.profitgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.profitgrid.Location = new System.Drawing.Point(25, 111);
            this.profitgrid.Margin = new System.Windows.Forms.Padding(0);
            this.profitgrid.Name = "profitgrid";
            this.profitgrid.RowHeadersVisible = false;
            this.profitgrid.RowHeadersWidth = 51;
            this.profitgrid.RowTemplate.Height = 40;
            this.profitgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profitgrid.Size = new System.Drawing.Size(1560, 840);
            this.profitgrid.TabIndex = 76;
            this.profitgrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // ProfitGridviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1610, 980);
            this.Controls.Add(this.profitgrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1610, 980);
            this.MinimumSize = new System.Drawing.Size(1610, 980);
            this.Name = "ProfitGridviewForm";
            this.Text = "ProfitGridviewForm";
            this.Load += new System.EventHandler(this.ProfitGridviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profitgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton close;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuDataGridView profitgrid;
    }
}