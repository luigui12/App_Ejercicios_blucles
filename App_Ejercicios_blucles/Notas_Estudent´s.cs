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
    public partial class Notas_Estudent_s : Form
    {
        public Notas_Estudent_s()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Notas.Sorted = false;
            Random r = new Random();//Generar numero aleatorios
            this.Notas.Items.Clear();//Vacial lista 
            for (int i = 0; i < 10; i++)
            {
                int num = r.Next(1, 9);
                this.Notas.Items.Add(num);
            }
        }
    }
}
