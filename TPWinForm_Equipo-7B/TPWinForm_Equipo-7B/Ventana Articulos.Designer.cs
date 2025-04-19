namespace TPWinForm_Equipo_7B
{
    partial class ventanaArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaArticulos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnVerDetallesArticulo = new System.Windows.Forms.Button();
            this.btnAddArticulo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(24, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1580, 808);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(1284, 912);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(320, 67);
            this.btnEliminarArticulo.TabIndex = 1;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(24, 19);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(240, 58);
            this.btnModificarArticulo.TabIndex = 2;
            this.btnModificarArticulo.Text = "Modificar Artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnVerDetallesArticulo
            // 
            this.btnVerDetallesArticulo.Location = new System.Drawing.Point(278, 19);
            this.btnVerDetallesArticulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVerDetallesArticulo.Name = "btnVerDetallesArticulo";
            this.btnVerDetallesArticulo.Size = new System.Drawing.Size(240, 58);
            this.btnVerDetallesArticulo.TabIndex = 3;
            this.btnVerDetallesArticulo.Text = "Ver Detalles";
            this.btnVerDetallesArticulo.UseVisualStyleBackColor = true;
            this.btnVerDetallesArticulo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAddArticulo
            // 
            this.btnAddArticulo.Location = new System.Drawing.Point(532, 19);
            this.btnAddArticulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddArticulo.Name = "btnAddArticulo";
            this.btnAddArticulo.Size = new System.Drawing.Size(240, 58);
            this.btnAddArticulo.TabIndex = 4;
            this.btnAddArticulo.Text = "Añadir Articulo";
            this.btnAddArticulo.UseVisualStyleBackColor = true;
            this.btnAddArticulo.Click += new System.EventHandler(this.btnAddArticulo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 912);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(240, 58);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar Articulo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ventanaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 1002);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAddArticulo);
            this.Controls.Add(this.btnVerDetallesArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ventanaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ventanaArticulos";
            this.Load += new System.EventHandler(this.CATALOGO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnVerDetallesArticulo;
        private System.Windows.Forms.Button btnAddArticulo;
        private System.Windows.Forms.Button btnBuscar;
    }
}