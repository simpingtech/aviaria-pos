﻿namespace AviariaPOS
{
    partial class frmINVENTORY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmINVENTORY));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cmbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.bworkPrint = new System.ComponentModel.BackgroundWorker();
            this.pbarPrint = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prodDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 45F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(284, 81);
            this.gunaLabel1.TabIndex = 18;
            this.gunaLabel1.Text = "Inventory";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSearch.FocusedState.Parent = this.cmbSearch;
            this.cmbSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.HoverState.Parent = this.cmbSearch;
            this.cmbSearch.ItemHeight = 30;
            this.cmbSearch.ItemsAppearance.Parent = this.cmbSearch;
            this.cmbSearch.Location = new System.Drawing.Point(1148, 123);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.ShadowDecoration.Parent = this.cmbSearch;
            this.cmbSearch.Size = new System.Drawing.Size(140, 36);
            this.cmbSearch.TabIndex = 14;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Animated = true;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(833, 123);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(309, 36);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 30;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodID,
            this.prodName,
            this.prodPrice,
            this.prodManufacturerName,
            this.stocks,
            this.prodEdit,
            this.prodDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 20F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(12, 191);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.RowTemplate.ReadOnly = true;
            this.dgvProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1276, 570);
            this.dgvProducts.TabIndex = 12;
            this.dgvProducts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvProducts.ThemeStyle.ReadOnly = true;
            this.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducts.ThemeStyle.RowsStyle.Height = 40;
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProducts_CellPainting);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // bworkPrint
            // 
            this.bworkPrint.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bworkPrint_DoWork);
            this.bworkPrint.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bworkPrint_RunWorkerCompleted);
            // 
            // pbarPrint
            // 
            this.pbarPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbarPrint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbarPrint.Location = new System.Drawing.Point(12, 165);
            this.pbarPrint.Name = "pbarPrint";
            this.pbarPrint.ShadowDecoration.Parent = this.pbarPrint;
            this.pbarPrint.Size = new System.Drawing.Size(1276, 20);
            this.pbarPrint.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbarPrint.TabIndex = 19;
            this.pbarPrint.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.pbarPrint.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Image = global::AviariaPOS.Properties.Resources.print_64px;
            this.btnPrint.Location = new System.Drawing.Point(208, 114);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(180, 45);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print Preview";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::AviariaPOS.Properties.Resources.add_64px;
            this.btnAdd.Location = new System.Drawing.Point(12, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // prodID
            // 
            this.prodID.HeaderText = "ID";
            this.prodID.Name = "prodID";
            this.prodID.ReadOnly = true;
            // 
            // prodName
            // 
            this.prodName.FillWeight = 80.4513F;
            this.prodName.HeaderText = "Product Name";
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            // 
            // prodPrice
            // 
            this.prodPrice.FillWeight = 80.4513F;
            this.prodPrice.HeaderText = "Price";
            this.prodPrice.Name = "prodPrice";
            this.prodPrice.ReadOnly = true;
            // 
            // prodManufacturerName
            // 
            this.prodManufacturerName.FillWeight = 80.4513F;
            this.prodManufacturerName.HeaderText = "Manufacturer Name";
            this.prodManufacturerName.Name = "prodManufacturerName";
            this.prodManufacturerName.ReadOnly = true;
            // 
            // stocks
            // 
            this.stocks.FillWeight = 80.4513F;
            this.stocks.HeaderText = "Stocks";
            this.stocks.Name = "stocks";
            this.stocks.ReadOnly = true;
            // 
            // prodEdit
            // 
            this.prodEdit.FillWeight = 70F;
            this.prodEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodEdit.HeaderText = "Edit";
            this.prodEdit.Name = "prodEdit";
            this.prodEdit.ReadOnly = true;
            // 
            // prodDelete
            // 
            this.prodDelete.FillWeight = 70F;
            this.prodDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodDelete.HeaderText = "Delete";
            this.prodDelete.Name = "prodDelete";
            this.prodDelete.ReadOnly = true;
            // 
            // frmINVENTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1300, 773);
            this.Controls.Add(this.pbarPrint);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmINVENTORY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmINVENTORY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmINVENTORY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.ComponentModel.BackgroundWorker bworkPrint;
        private Guna.UI2.WinForms.Guna2ProgressBar pbarPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocks;
        private System.Windows.Forms.DataGridViewButtonColumn prodEdit;
        private System.Windows.Forms.DataGridViewButtonColumn prodDelete;

    }
}