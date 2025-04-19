namespace TPWinForm_Equipo_7B
{
    partial class addArticle
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
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.txtBoxNombreArticulo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAdminMarcas = new System.Windows.Forms.Button();
            this.btnAdminCategorias = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUrlImage = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.addImg = new System.Windows.Forms.Button();
            this.txtBoxDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(10, 8);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(104, 13);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "Nombre del Artículo:";
            // 
            // txtBoxNombreArticulo
            // 
            this.txtBoxNombreArticulo.Location = new System.Drawing.Point(134, 5);
            this.txtBoxNombreArticulo.Name = "txtBoxNombreArticulo";
            this.txtBoxNombreArticulo.Size = new System.Drawing.Size(298, 20);
            this.txtBoxNombreArticulo.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(295, 387);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 30);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Añadir";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(10, 33);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(97, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca del Artículo:";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(134, 30);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(218, 21);
            this.comboBoxMarca.TabIndex = 5;
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(10, 58);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(114, 13);
            this.lblCategoriaArticulo.TabIndex = 6;
            this.lblCategoriaArticulo.Text = "Categoría del Artículo:";
            this.lblCategoriaArticulo.Click += new System.EventHandler(this.lblCategoriaArticulo_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(134, 55);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(218, 21);
            this.comboBoxCategoria.TabIndex = 7;
            // 
            // btnAdminMarcas
            // 
            this.btnAdminMarcas.Location = new System.Drawing.Point(359, 30);
            this.btnAdminMarcas.Name = "btnAdminMarcas";
            this.btnAdminMarcas.Size = new System.Drawing.Size(75, 21);
            this.btnAdminMarcas.TabIndex = 8;
            this.btnAdminMarcas.Text = "Admin";
            this.btnAdminMarcas.UseVisualStyleBackColor = true;
            this.btnAdminMarcas.Click += new System.EventHandler(this.btnAdminMarcas_Click);
            // 
            // btnAdminCategorias
            // 
            this.btnAdminCategorias.Location = new System.Drawing.Point(359, 55);
            this.btnAdminCategorias.Name = "btnAdminCategorias";
            this.btnAdminCategorias.Size = new System.Drawing.Size(75, 21);
            this.btnAdminCategorias.TabIndex = 9;
            this.btnAdminCategorias.Text = "Admin";
            this.btnAdminCategorias.UseVisualStyleBackColor = true;
            this.btnAdminCategorias.Click += new System.EventHandler(this.btnAdminCategorias_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(10, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(10, 83);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(134, 80);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(298, 20);
            this.txtBoxPrice.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(237, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 200);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblUrlImage
            // 
            this.lblUrlImage.AutoSize = true;
            this.lblUrlImage.Location = new System.Drawing.Point(10, 108);
            this.lblUrlImage.Name = "lblUrlImage";
            this.lblUrlImage.Size = new System.Drawing.Size(70, 13);
            this.lblUrlImage.TabIndex = 14;
            this.lblUrlImage.Text = "Imagen URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(134, 105);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(218, 20);
            this.textBoxURL.TabIndex = 15;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(357, 105);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 21);
            this.btnLoadImage.TabIndex = 16;
            this.btnLoadImage.Text = "Cargar";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 155);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(210, 200);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.Location = new System.Drawing.Point(10, 361);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(95, 21);
            this.btnEliminarImg.TabIndex = 18;
            this.btnEliminarImg.Text = "Eliminar Imagen";
            this.btnEliminarImg.UseVisualStyleBackColor = true;
            // 
            // addImg
            // 
            this.addImg.Location = new System.Drawing.Point(125, 361);
            this.addImg.Name = "addImg";
            this.addImg.Size = new System.Drawing.Size(95, 21);
            this.addImg.TabIndex = 19;
            this.addImg.Text = "Añadir Imagen";
            this.addImg.UseVisualStyleBackColor = true;
            // 
            // txtBoxDescripcionArticulo
            // 
            this.txtBoxDescripcionArticulo.Location = new System.Drawing.Point(134, 130);
            this.txtBoxDescripcionArticulo.Name = "txtBoxDescripcionArticulo";
            this.txtBoxDescripcionArticulo.Size = new System.Drawing.Size(298, 20);
            this.txtBoxDescripcionArticulo.TabIndex = 20;
            this.txtBoxDescripcionArticulo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 133);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // addArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 426);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtBoxDescripcionArticulo);
            this.Controls.Add(this.addImg);
            this.Controls.Add(this.btnEliminarImg);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.lblUrlImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdminCategorias);
            this.Controls.Add(this.btnAdminMarcas);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.lblCategoriaArticulo);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtBoxNombreArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.Name = "addArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Artículo";
            this.Load += new System.EventHandler(this.addArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.TextBox txtBoxNombreArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button btnAdminMarcas;
        private System.Windows.Forms.Button btnAdminCategorias;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUrlImage;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnEliminarImg;
        private System.Windows.Forms.Button addImg;
        private System.Windows.Forms.TextBox txtBoxDescripcionArticulo;
        private System.Windows.Forms.Label lblDescripcion;
    }
}