﻿namespace TPWinForm_Equipo_7B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(G_MARCA));
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(72, 83);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersVisible = false;
            this.dgvMarcas.RowHeadersWidth = 82;
            this.dgvMarcas.RowTemplate.Height = 33;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(654, 285);
            this.dgvMarcas.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(434, 406);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 69);
            this.button2.TabIndex = 7;
            this.button2.Text = "ELIMINAR MARCA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNuevaMarca.Location = new System.Drawing.Point(72, 406);
            this.btnNuevaMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(276, 69);
            this.btnNuevaMarca.TabIndex = 6;
            this.btnNuevaMarca.Text = "NUEVA MARCA";
            this.btnNuevaMarca.UseVisualStyleBackColor = false;
            this.btnNuevaMarca.Click += new System.EventHandler(this.NUEVAMARCA_Click);
            // 
            // G_MARCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNuevaMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "G_MARCA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION DE MARCAS";
            this.Load += new System.EventHandler(this.MARCAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNuevaMarca;
    }
}