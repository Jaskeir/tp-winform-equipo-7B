
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(24, 24);
            this.dataGridViewCategorias.MultiSelect = false;
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategorias.Size = new System.Drawing.Size(301, 196);
            this.dataGridViewCategorias.TabIndex = 0;
            // 
            // btnAgregarCate
            // 
            this.btnAgregarCate.Location = new System.Drawing.Point(37, 254);
            this.btnAgregarCate.Name = "btnAgregarCate";
            this.btnAgregarCate.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCate.TabIndex = 1;
            this.btnAgregarCate.Text = "Agregar";
            this.btnAgregarCate.UseVisualStyleBackColor = true;
            this.btnAgregarCate.Click += new System.EventHandler(this.btnAgregarCate_Click);
            // 
            // vCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 325);
            this.Controls.Add(this.btnAgregarCate);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Name = "vCategorias";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.vCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.Button btnAgregarCate;
    }
}