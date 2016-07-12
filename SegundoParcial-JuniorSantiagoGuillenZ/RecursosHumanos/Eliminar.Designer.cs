namespace RecursosHumanos
{
    partial class Eliminar
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
            this.EliminartextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdEmpleado";
            // 
            // EliminartextBox
            // 
            this.EliminartextBox.Location = new System.Drawing.Point(82, 75);
            this.EliminartextBox.Name = "EliminartextBox";
            this.EliminartextBox.Size = new System.Drawing.Size(100, 20);
            this.EliminartextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::RecursosHumanos.Properties.Resources.Misc_Delete_Database_icon;
            this.button1.Location = new System.Drawing.Point(197, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.EliminartextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EliminartextBox;
    }
}