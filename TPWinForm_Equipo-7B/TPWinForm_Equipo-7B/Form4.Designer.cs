namespace TPWinForm_Equipo_7B
{
    partial class G_MARCA
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MODIFICARCATLOGO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(73, 83);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 82;
            this.dgvMarcas.RowTemplate.Height = 33;
            this.dgvMarcas.Size = new System.Drawing.Size(654, 284);
            this.dgvMarcas.TabIndex = 3;
            this.dgvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(786, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 280);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(786, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 69);
            this.button2.TabIndex = 7;
            this.button2.Text = "ELIMINAR MARCA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MODIFICARCATLOGO
            // 
            this.MODIFICARCATLOGO.Location = new System.Drawing.Point(73, 405);
            this.MODIFICARCATLOGO.Name = "MODIFICARCATLOGO";
            this.MODIFICARCATLOGO.Size = new System.Drawing.Size(305, 69);
            this.MODIFICARCATLOGO.TabIndex = 6;
            this.MODIFICARCATLOGO.Text = "NUEVA MARCA";
            this.MODIFICARCATLOGO.UseVisualStyleBackColor = true;
            // 
            // G_MARCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 486);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MODIFICARCATLOGO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "G_MARCA";
            this.Text = "GESTION DE MARCAS";
            this.Load += new System.EventHandler(this.MARCAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MODIFICARCATLOGO;
    }
}