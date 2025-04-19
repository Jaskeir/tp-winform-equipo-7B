namespace TPWinForm_Equipo_7B
{
    partial class BUSQUEDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BUSQUEDA));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.dvgArticulos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(216, 46);
            this.txtbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(380, 31);
            this.txtbCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MARCA:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CATEGORIA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.Location = new System.Drawing.Point(216, 148);
            this.cbxMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(380, 33);
            this.cbxMarcas.TabIndex = 9;
            this.cbxMarcas.SelectedIndexChanged += new System.EventHandler(this.BUSQUEDA_Load);
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(216, 198);
            this.cbxCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(380, 33);
            this.cbxCategorias.TabIndex = 10;
            this.cbxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "NOMBRE:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(216, 98);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(380, 31);
            this.txtbNombre.TabIndex = 14;
            // 
            // dvgArticulos
            // 
            this.dvgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgArticulos.Location = new System.Drawing.Point(62, 419);
            this.dvgArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dvgArticulos.Name = "dvgArticulos";
            this.dvgArticulos.RowHeadersWidth = 82;
            this.dvgArticulos.RowTemplate.Height = 33;
            this.dvgArticulos.Size = new System.Drawing.Size(576, 244);
            this.dvgArticulos.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(680, 419);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 242);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // BUSQUEDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvgArticulos);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.cbxMarcas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BUSQUEDA";
            this.Text = "BUSQUEDA DE ARTICULOS";
            this.Load += new System.EventHandler(this.BUSQUEDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.DataGridView dvgArticulos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}