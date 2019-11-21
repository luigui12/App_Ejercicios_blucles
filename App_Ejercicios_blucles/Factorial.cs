using System;
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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            int num= int.Parse(this.num.Text);
            long resultado = Funciones.Bucles.factorial(num);
            this.exit.Text = resultado.ToString();

        }
    }
}
