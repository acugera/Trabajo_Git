namespace Proyecto_Git
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrueva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrueva
            // 
            this.lblPrueva.AutoSize = true;
            this.lblPrueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueva.Location = new System.Drawing.Point(71, 10);
            this.lblPrueva.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrueva.Name = "lblPrueva";
            this.lblPrueva.Size = new System.Drawing.Size(257, 73);
            this.lblPrueva.TabIndex = 0;
            this.lblPrueva.Text = "Buenas";
            this.lblPrueva.Click += new System.EventHandler(this.lblPrueva_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 92);
            this.Controls.Add(this.lblPrueva);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrueva;
    }
}

