﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ejercicios_blucles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hola_Click(object sender, EventArgs e)
        {
            int limite = int.Parse(this.limi.Text);
            String cad = Funciones.Bucles.saludos(limite);
            this.impresion.Text = cad;
        }
    }
}
