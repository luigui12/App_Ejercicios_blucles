namespace App_Ejercicios_blucles
{
    partial class Lista
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
            this.llenar = new System.Windows.Forms.Button();
            this.odenar = new System.Windows.Forms.Button();
            this.listaNumero = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // llenar
            // 
            this.llenar.Location = new System.Drawing.Point(52, 79);
            this.llenar.Name = "llenar";
            this.llenar.Size = new System.Drawing.Size(75, 23);
            this.llenar.TabIndex = 0;
            this.llenar.Text = "Llenar lista ";
            this.llenar.UseVisualStyleBackColor = true;
            this.llenar.Click += new System.EventHandler(this.llenar_Click);
            // 
            // odenar
            // 
            this.odenar.Location = new System.Drawing.Point(207, 79);
            this.odenar.Name = "odenar";
            this.odenar.Size = new System.Drawing.Size(75, 23);
            this.odenar.TabIndex = 1;
            this.odenar.Text = "Ordenar lista";
            this.odenar.UseVisualStyleBackColor = true;
            this.odenar.Click += new System.EventHandler(this.odenar_Click);
            // 
            // listaNumero
            // 
            this.listaNumero.FormattingEnabled = true;
            this.listaNumero.Location = new System.Drawing.Point(52, 122);
            this.listaNumero.Name = "listaNumero";
            this.listaNumero.Size = new System.Drawing.Size(109, 160);
            this.listaNumero.TabIndex = 2;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 315);
            this.Controls.Add(this.listaNumero);
            this.Controls.Add(this.odenar);
            this.Controls.Add(this.llenar);
            this.Name = "Lista";
            this.Text = "Lista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button llenar;
        private System.Windows.Forms.Button odenar;
        private System.Windows.Forms.ListBox listaNumero;
    }
}