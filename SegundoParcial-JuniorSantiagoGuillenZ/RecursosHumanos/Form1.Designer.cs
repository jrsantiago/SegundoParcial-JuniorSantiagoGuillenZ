namespace RecursosHumanos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.IniciodataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosHumanosDataSet = new RecursosHumanos.RecursosHumanosDataSet();
            this.empleadosTableAdapter = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.EmpleadosTableAdapter();
            this.Reportebutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IniciodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(213, 41);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(101, 41);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(100, 20);
            this.BuscartextBox.TabIndex = 1;
            // 
            // IniciodataGridView
            // 
            this.IniciodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IniciodataGridView.Location = new System.Drawing.Point(12, 87);
            this.IniciodataGridView.Name = "IniciodataGridView";
            this.IniciodataGridView.Size = new System.Drawing.Size(552, 155);
            this.IniciodataGridView.TabIndex = 5;
            this.IniciodataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.recursosHumanosDataSet;
            // 
            // recursosHumanosDataSet
            // 
            this.recursosHumanosDataSet.DataSetName = "RecursosHumanosDataSet";
            this.recursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // Reportebutton
            // 
            this.Reportebutton.Image = global::RecursosHumanos.Properties.Resources.SEO_icon;
            this.Reportebutton.Location = new System.Drawing.Point(391, 267);
            this.Reportebutton.Name = "Reportebutton";
            this.Reportebutton.Size = new System.Drawing.Size(75, 95);
            this.Reportebutton.TabIndex = 7;
            this.Reportebutton.Text = "Reporte";
            this.Reportebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reportebutton.UseVisualStyleBackColor = true;
            this.Reportebutton.Click += new System.EventHandler(this.Reportebutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RecursosHumanos.Properties.Resources.Misc_Delete_Database_icon;
            this.Eliminarbutton.Location = new System.Drawing.Point(275, 267);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 95);
            this.Eliminarbutton.TabIndex = 4;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Image = global::RecursosHumanos.Properties.Resources.Text_Edit_icon;
            this.Actualizarbutton.Location = new System.Drawing.Point(172, 267);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(75, 95);
            this.Actualizarbutton.TabIndex = 3;
            this.Actualizarbutton.Text = "Update";
            this.Actualizarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::RecursosHumanos.Properties.Resources.system_database_add_icon__1_;
            this.Agregarbutton.Location = new System.Drawing.Point(56, 267);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 95);
            this.Agregarbutton.TabIndex = 2;
            this.Agregarbutton.Text = "ADD";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 387);
            this.Controls.Add(this.Reportebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IniciodataGridView);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IniciodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.DataGridView IniciodataGridView;
        private System.Windows.Forms.Label label1;
        private RecursosHumanosDataSet recursosHumanosDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private RecursosHumanosDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Button Reportebutton;
    }
}

