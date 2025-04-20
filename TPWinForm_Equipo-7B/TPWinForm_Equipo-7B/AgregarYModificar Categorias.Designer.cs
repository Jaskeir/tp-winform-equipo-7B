
namespace TPWinForm_Equipo_7B
{
    partial class FormNuevaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaCategoria));
            this.btnAceptarCate = new System.Windows.Forms.Button();
            this.btnCancelarCate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAgregarCate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptarCate
            // 
            this.btnAceptarCate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCate.Location = new System.Drawing.Point(44, 161);
            this.btnAceptarCate.Name = "btnAceptarCate";
            this.btnAceptarCate.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarCate.TabIndex = 1;
            this.btnAceptarCate.Text = "Aceptar";
            this.btnAceptarCate.UseVisualStyleBackColor = false;
            this.btnAceptarCate.Click += new System.EventHandler(this.btnAceptarCate_Click);
            // 
            // btnCancelarCate
            // 
            this.btnCancelarCate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCate.Location = new System.Drawing.Point(150, 161);
            this.btnCancelarCate.Name = "btnCancelarCate";
            this.btnCancelarCate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCate.TabIndex = 2;
            this.btnCancelarCate.Text = "Cancelar";
            this.btnCancelarCate.UseVisualStyleBackColor = false;
            this.btnCancelarCate.Click += new System.EventHandler(this.btnCancelarCate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtBoxAgregarCate
            // 
            this.txtBoxAgregarCate.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxAgregarCate.Location = new System.Drawing.Point(125, 93);
            this.txtBoxAgregarCate.Name = "txtBoxAgregarCate";
            this.txtBoxAgregarCate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAgregarCate.TabIndex = 0;
            // 
            // FormNuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.txtBoxAgregarCate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarCate);
            this.Controls.Add(this.btnAceptarCate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 260);
            this.Name = "FormNuevaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.FormNuevaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarCate;
        private System.Windows.Forms.Button btnCancelarCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAgregarCate;
    }
}