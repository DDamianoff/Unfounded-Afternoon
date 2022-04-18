namespace Ingeniería.Forms
{
    partial class AdministrarProducto
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
            this.pnlListContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlListContainer
            // 
            this.pnlListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlListContainer.Name = "pnlListContainer";
            this.pnlListContainer.Size = new System.Drawing.Size(594, 373);
            this.pnlListContainer.TabIndex = 0;
            // 
            // AdministrarProducto
            // 
            this.Controls.Add(this.pnlListContainer);
            this.Name = "AdministrarProducto";
            this.Size = new System.Drawing.Size(594, 373);
            this.Load += new System.EventHandler(this.AdministrarProducto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Panel panel2;
        private Panel pnlProductList;
        private Panel pnlListContainer;
    }
}
