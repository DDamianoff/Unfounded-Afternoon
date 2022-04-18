namespace Ingeniería.Forms
{
    partial class ProductoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelRegistrarProducto = new System.Windows.Forms.Panel();
            this.panelAdministrarProducto = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTO";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelRegistrarProducto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelAdministrarProducto, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 571);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelRegistrarProducto
            // 
            this.panelRegistrarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistrarProducto.Location = new System.Drawing.Point(3, 3);
            this.panelRegistrarProducto.Name = "panelRegistrarProducto";
            this.panelRegistrarProducto.Size = new System.Drawing.Size(454, 565);
            this.panelRegistrarProducto.TabIndex = 0;
            // 
            // panelAdministrarProducto
            // 
            this.panelAdministrarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdministrarProducto.Location = new System.Drawing.Point(463, 3);
            this.panelAdministrarProducto.Name = "panelAdministrarProducto";
            this.panelAdministrarProducto.Size = new System.Drawing.Size(454, 565);
            this.panelAdministrarProducto.TabIndex = 1;
            // 
            // ProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(920, 616);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ProductoForm";
            this.Text = "ProductoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductoForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductoForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelRegistrarProducto;
        private Panel panelAdministrarProducto;
    }
}