namespace RecursosHumanos.Consultas
{
    partial class ReViewer
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
            this.reporteViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteViewer
            // 
            this.reporteViewer.Location = new System.Drawing.Point(-1, -1);
            this.reporteViewer.Name = "reporteViewer";
            this.reporteViewer.Size = new System.Drawing.Size(770, 357);
            this.reporteViewer.TabIndex = 0;
            // 
            // ReViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 355);
            this.Controls.Add(this.reporteViewer);
            this.Name = "ReViewer";
            this.Text = "ReViewer";
            this.Load += new System.EventHandler(this.ReViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reporteViewer;
    }
}