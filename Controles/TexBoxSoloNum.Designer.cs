namespace Controles
{
    partial class TexBoxSoloNum
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Location = new System.Drawing.Point(0, 2);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(141, 20);
            this.TxtIngreso.TabIndex = 2;
            this.TxtIngreso.Text = "0";
            // 
            // TexBoxSoloNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtIngreso);
            this.Name = "TexBoxSoloNum";
            this.Size = new System.Drawing.Size(141, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIngreso;
    }
}
