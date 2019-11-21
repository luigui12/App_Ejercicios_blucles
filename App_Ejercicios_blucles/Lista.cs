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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void llenar_Click(object sender, EventArgs e)
        {
            this.listaNumero.Sorted = false;
            Random r = new Random();//Generar numero aleatorios
            this.listaNumero.Items.Clear();//Vacial lista 
            for (int i=0;i<10;i++)
            {
                int num = r.Next(1, 9);
                this.listaNumero.Items.Add(num);
            }
        }

        private void odenar_Click(object sender, EventArgs e)
        {
            this.listaNumero.Sorted = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
           // this.listaNumero.Items.Clear();
        }
    }
}
