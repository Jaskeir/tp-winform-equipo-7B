namespace TPWinForm_Equipo_7B
{
    partial class CATALOGO
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnVerDetallesArticulo = new System.Windows.Forms.Button();
            this.btnAddArticulo = new System.Windows.Forms.Button();
            this.artCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.artPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artCode,
            this.artName,
            this.artDescription,
            this.artBrand,
            this.artCategory,
            this.artImg,
            this.artPrice});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(790, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(642, 474);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(160, 35);
            this.btnEliminarArticulo.TabIndex = 1;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(12, 10);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(120, 30);
            this.btnModificarArticulo.TabIndex = 2;
            this.btnModificarArticulo.Text = "Modificar Artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnVerDetallesArticulo
            // 
            this.btnVerDetallesArticulo.Location = new System.Drawing.Point(139, 10);
            this.btnVerDetallesArticulo.Name = "btnVerDetallesArticulo";
            this.btnVerDetallesArticulo.Size = new System.Drawing.Size(120, 30);
            this.btnVerDetallesArticulo.TabIndex = 3;
            this.btnVerDetallesArticulo.Text = "Ver Detalles";
            this.btnVerDetallesArticulo.UseVisualStyleBackColor = true;
            this.btnVerDetallesArticulo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAddArticulo
            // 
            this.btnAddArticulo.Location = new System.Drawing.Point(266, 10);
            this.btnAddArticulo.Name = "btnAddArticulo";
            this.btnAddArticulo.Size = new System.Drawing.Size(120, 30);
            this.btnAddArticulo.TabIndex = 4;
            this.btnAddArticulo.Text = "Añadir Articulo";
            this.btnAddArticulo.UseVisualStyleBackColor = true;
            // 
            // artCode
            // 
            this.artCode.Frozen = true;
            this.artCode.HeaderText = "Cod Artículo";
            this.artCode.Name = "artCode";
            this.artCode.ReadOnly = true;
            this.artCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.artCode.Width = 91;
            // 
            // artName
            // 
            this.artName.Frozen = true;
            this.artName.HeaderText = "Nombre";
            this.artName.Name = "artName";
            this.artName.ReadOnly = true;
            this.artName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.artName.Width = 69;
            // 
            // artDescription
            // 
            this.artDescription.Frozen = true;
            this.artDescription.HeaderText = "Descripción";
            this.artDescription.Name = "artDescription";
            this.artDescription.ReadOnly = true;
            this.artDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.artDescription.Width = 88;
            // 
            // artBrand
            // 
            this.artBrand.Frozen = true;
            this.artBrand.HeaderText = "Marca";
            this.artBrand.Name = "artBrand";
            this.artBrand.ReadOnly = true;
            this.artBrand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.artBrand.Width = 62;
            // 
            // artCategory
            // 
            this.artCategory.Frozen = true;
            this.artCategory.HeaderText = "Categoría";
            this.artCategory.Name = "artCategory";
            this.artCategory.ReadOnly = true;
            this.artCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.artCategory.Width = 79;
            // 
            // artImg
            // 
            this.artImg.Frozen = true;
            this.artImg.HeaderText = "Imagen";
            this.artImg.Name = "artImg";
            this.artImg.ReadOnly = true;
            this.artImg.Width = 48;
            // 
            // artPrice
            // 
            this.artPrice.Frozen = true;
            this.artPrice.HeaderText = "Precio";
            this.artPrice.Name = "artPrice";
            this.artPrice.ReadOnly = true;
            this.artPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.artPrice.Width = 62;
            // 
            // CATALOGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 521);
            this.Controls.Add(this.btnAddArticulo);
            this.Controls.Add(this.btnVerDetallesArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CATALOGO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATALOGO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnVerDetallesArticulo;
        private System.Windows.Forms.Button btnAddArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn artCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn artName;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn artBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn artCategory;
        private System.Windows.Forms.DataGridViewImageColumn artImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn artPrice;
    }
}