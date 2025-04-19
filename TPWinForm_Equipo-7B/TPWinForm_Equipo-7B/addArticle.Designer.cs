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
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(12, 9);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(104, 13);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "Nombre del Artículo:";
            this.lblNombreArticulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxNombreArticulo
            // 
            this.txtBoxNombreArticulo.Location = new System.Drawing.Point(134, 6);
            this.txtBoxNombreArticulo.Name = "txtBoxNombreArticulo";
            this.txtBoxNombreArticulo.Size = new System.Drawing.Size(298, 20);
            this.txtBoxNombreArticulo.TabIndex = 2;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(355, 376);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarImagen.TabIndex = 3;
            this.btnCargarImagen.Text = "button1";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 38);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(97, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca del Artículo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(12, 67);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(111, 13);
            this.lblCategoriaArticulo.TabIndex = 6;
            this.lblCategoriaArticulo.Text = "Categoría del Artículo";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(298, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // addArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 411);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblCategoriaArticulo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.txtBoxNombreArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.Name = "addArticle";
            this.Text = "Añadir Artículo";
            this.Load += new System.EventHandler(this.addArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.TextBox txtBoxNombreArticulo;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}