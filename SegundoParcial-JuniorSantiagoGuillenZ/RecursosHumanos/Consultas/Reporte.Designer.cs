namespace RecursosHumanos
{
    partial class Reporte
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
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.BuscarReportebutton = new System.Windows.Forms.Button();
            this.BuscarReportetextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Location = new System.Drawing.Point(12, 64);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.Size = new System.Drawing.Size(619, 164);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(12, 250);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbutton.TabIndex = 1;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // BuscarReportebutton
            // 
            this.BuscarReportebutton.Location = new System.Drawing.Point(225, 26);
            this.BuscarReportebutton.Name = "BuscarReportebutton";
            this.BuscarReportebutton.Size = new System.Drawing.Size(75, 23);
            this.BuscarReportebutton.TabIndex = 2;
            this.BuscarReportebutton.Text = "Buscar";
            this.BuscarReportebutton.UseVisualStyleBackColor = true;
            this.BuscarReportebutton.Click += new System.EventHandler(this.BuscarReportebutton_Click);
            // 
            // BuscarReportetextBox
            // 
            this.BuscarReportetextBox.Location = new System.Drawing.Point(109, 26);
            this.BuscarReportetextBox.Name = "BuscarReportetextBox";
            this.BuscarReportetextBox.Size = new System.Drawing.Size(100, 20);
            this.BuscarReportetextBox.TabIndex = 3;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 317);
            this.Controls.Add(this.BuscarReportetextBox);
            this.Controls.Add(this.BuscarReportebutton);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.DatosDataGridView);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button BuscarReportebutton;
        private System.Windows.Forms.TextBox BuscarReportetextBox;
    }
}