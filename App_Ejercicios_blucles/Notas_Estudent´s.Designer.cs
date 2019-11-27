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
            this.label1 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nº ";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(12, 109);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(39, 20);
            this.numero.TabIndex = 8;
            // 
            // Notas_Estudent_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 283);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero;
    }
}