namespace App_Ejercicios_blucles
{
    partial class Notas_Estudent_s
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
            this.orden = new System.Windows.Forms.Button();
            this.llenar = new System.Windows.Forms.Button();
            this.Notas = new System.Windows.Forms.ListBox();
            this.xxxx = new System.Windows.Forms.Label();
            this.xx = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.promedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // orden
            // 
            this.orden.Location = new System.Drawing.Point(181, 34);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(118, 23);
            this.orden.TabIndex = 0;
            this.orden.Text = "Ordenar Notas";
            this.orden.UseVisualStyleBackColor = true;
            this.orden.Click += new System.EventHandler(this.button1_Click);
            // 
            // llenar
            // 
            this.llenar.Location = new System.Drawing.Point(43, 34);
            this.llenar.Name = "llenar";
            this.llenar.Size = new System.Drawing.Size(118, 23);
            this.llenar.TabIndex = 1;
            this.llenar.Text = "Llenar Notas";
            this.llenar.UseVisualStyleBackColor = true;
            this.llenar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Notas
            // 
            this.Notas.FormattingEnabled = true;
            this.Notas.Location = new System.Drawing.Point(86, 73);
            this.Notas.Name = "Notas";
            this.Notas.Size = new System.Drawing.Size(166, 186);
            this.Notas.TabIndex = 2;
            // 
            // xxxx
            // 
            this.xxxx.AutoSize = true;
            this.xxxx.Location = new System.Drawing.Point(285, 93);
            this.xxxx.Name = "xxxx";
            this.xxxx.Size = new System.Drawing.Size(37, 13);
            this.xxxx.TabIndex = 3;
            this.xxxx.Text = "Total: ";
            // 
            // xx
            // 
            this.xx.AutoSize = true;
            this.xx.Location = new System.Drawing.Point(285, 132);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(57, 13);
            this.xx.TabIndex = 4;
            this.xx.Text = "Promedio: ";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(352, 93);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 5;
            // 
            // promedio
            // 
            this.promedio.Location = new System.Drawing.Point(352, 129);
            this.promedio.Name = "promedio";
            this.promedio.Size = new System.Drawing.Size(100, 20);
            this.promedio.TabIndex = 6;
            // 
            // Notas_Estudent_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 327);
            this.Controls.Add(this.promedio);
            this.Controls.Add(this.total);
            this.Controls.Add(this.xx);
            this.Controls.Add(this.xxxx);
            this.Controls.Add(this.Notas);
            this.Controls.Add(this.llenar);
            this.Controls.Add(this.orden);
            this.Name = "Notas_Estudent_s";
            this.Text = "Notas_Estudent_s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orden;
        private System.Windows.Forms.Button llenar;
        private System.Windows.Forms.ListBox Notas;
        private System.Windows.Forms.Label xxxx;
        private System.Windows.Forms.Label xx;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox promedio;
    }
}