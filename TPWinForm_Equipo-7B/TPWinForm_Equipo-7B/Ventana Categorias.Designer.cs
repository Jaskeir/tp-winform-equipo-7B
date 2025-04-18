
namespace TPWinForm_Equipo_7B
{
    partial class vCategorias
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
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregarCate = new System.Windows.Forms.Button();
            this.btnModificarCate = new System.Windows.Forms.Button();
            this.btnEliminarCate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewCategorias.MultiSelect = false;
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategorias.Size = new System.Drawing.Size(272, 196);
            this.dataGridViewCategorias.TabIndex = 0;
            // 
            // btnAgregarCate
            // 
            this.btnAgregarCate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCate.Location = new System.Drawing.Point(12, 254);
            this.btnAgregarCate.Name = "btnAgregarCate";
            this.btnAgregarCate.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCate.TabIndex = 1;
            this.btnAgregarCate.Text = "Agregar";
            this.btnAgregarCate.UseVisualStyleBackColor = false;
            this.btnAgregarCate.Click += new System.EventHandler(this.btnAgregarCate_Click);
            // 
            // btnModificarCate
            // 
            this.btnModificarCate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCate.Location = new System.Drawing.Point(111, 254);
            this.btnModificarCate.Name = "btnModificarCate";
            this.btnModificarCate.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCate.TabIndex = 2;
            this.btnModificarCate.Text = "Modificar";
            this.btnModificarCate.UseVisualStyleBackColor = false;
            this.btnModificarCate.Click += new System.EventHandler(this.btnModificarCate_Click);
            // 
            // btnEliminarCate
            // 
            this.btnEliminarCate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCate.Location = new System.Drawing.Point(209, 254);
            this.btnEliminarCate.Name = "btnEliminarCate";
            this.btnEliminarCate.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCate.TabIndex = 3;
            this.btnEliminarCate.Text = "Eliminar";
            this.btnEliminarCate.UseVisualStyleBackColor = false;
            this.btnEliminarCate.Click += new System.EventHandler(this.btnEliminarCate_Click);
            // 
            // vCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(337, 298);
            this.Controls.Add(this.btnEliminarCate);
            this.Controls.Add(this.btnModificarCate);
            this.Controls.Add(this.btnAgregarCate);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Name = "vCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.vCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.Button btnAgregarCate;
        private System.Windows.Forms.Button btnModificarCate;
        private System.Windows.Forms.Button btnEliminarCate;
    }
}