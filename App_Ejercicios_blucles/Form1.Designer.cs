namespace App_Ejercicios_blucles
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.hola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.limi = new System.Windows.Forms.TextBox();
            this.impresion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hola
            // 
            this.hola.Location = new System.Drawing.Point(143, 131);
            this.hola.Name = "hola";
            this.hola.Size = new System.Drawing.Size(75, 23);
            this.hola.TabIndex = 0;
            this.hola.Text = "&Ejecutar";
            this.hola.UseVisualStyleBackColor = true;
            this.hola.Click += new System.EventHandler(this.hola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el limite: ";
            // 
            // limi
            // 
            this.limi.Location = new System.Drawing.Point(187, 91);
            this.limi.Name = "limi";
            this.limi.Size = new System.Drawing.Size(87, 20);
            this.limi.TabIndex = 2;
            // 
            // impresion
            // 
            this.impresion.Location = new System.Drawing.Point(84, 192);
            this.impresion.Multiline = true;
            this.impresion.Name = "impresion";
            this.impresion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.impresion.Size = new System.Drawing.Size(277, 192);
            this.impresion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkEx BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "BUCLE WHILE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.impresion);
            this.Controls.Add(this.limi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hola);
            this.Name = "Form1";
            this.Text = "Bucle while";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox limi;
        private System.Windows.Forms.TextBox impresion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

