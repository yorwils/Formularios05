
namespace Formularios05
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxEjercicios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxEjercicios
            // 
            this.cbxEjercicios.FormattingEnabled = true;
            this.cbxEjercicios.Location = new System.Drawing.Point(74, 26);
            this.cbxEjercicios.Name = "cbxEjercicios";
            this.cbxEjercicios.Size = new System.Drawing.Size(234, 21);
            this.cbxEjercicios.TabIndex = 0;
            this.cbxEjercicios.SelectedIndexChanged += new System.EventHandler(this.cbxEjercicios_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 223);
            this.Controls.Add(this.cbxEjercicios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEjercicios;
    }
}

