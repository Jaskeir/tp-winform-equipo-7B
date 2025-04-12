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
            this.lista_articulos = new System.Windows.Forms.ListBox();
            this.MODIFICARCATLOGO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_articulos
            // 
            this.lista_articulos.FormattingEnabled = true;
            this.lista_articulos.ItemHeight = 25;
            this.lista_articulos.Location = new System.Drawing.Point(119, 73);
            this.lista_articulos.Name = "lista_articulos";
            this.lista_articulos.Size = new System.Drawing.Size(836, 729);
            this.lista_articulos.TabIndex = 0;
            // 
            // MODIFICARCATLOGO
            // 
            this.MODIFICARCATLOGO.Location = new System.Drawing.Point(374, 900);
            this.MODIFICARCATLOGO.Name = "MODIFICARCATLOGO";
            this.MODIFICARCATLOGO.Size = new System.Drawing.Size(305, 69);
            this.MODIFICARCATLOGO.TabIndex = 1;
            this.MODIFICARCATLOGO.Text = "MODIFICAR CATALOGO";
            this.MODIFICARCATLOGO.UseVisualStyleBackColor = true;
            // 
            // CATALOGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 1049);
            this.Controls.Add(this.MODIFICARCATLOGO);
            this.Controls.Add(this.lista_articulos);
            this.Name = "CATALOGO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATALOGO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista_articulos;
        private System.Windows.Forms.Button MODIFICARCATLOGO;
    }
}