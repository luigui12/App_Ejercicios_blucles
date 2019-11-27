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
            this.Notas.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CALCULAR
            int n;
            n = int.Parse(this.numero.Text);
            String msg;
            long notas = estudiantes(n,out msg);
            this.total.Text = notas.ToString();
            if (msg.Length == 0)
            {
                this.total.Text = notas.ToString();
               
            }
            else
                this.total.Text = msg;
            //Messaje


        }
        private long estudiantes(int n,out string msg) 
        {
            this.Notas.Sorted = false;
            Random r = new Random();//Generar numero aleatorios
            this.Notas.Items.Clear();//Vacial lista 
            msg = "";
            int suma = 0, pro;
            for (int i = 0; i < n; i++)
            {
                int num = r.Next(20, 50);
                this.Notas.Items.Add(i+1+". "+num);
                suma = suma + num;
            }
            msg = "la suma es: "+suma;

            pro = suma / n;
            this.promedio.Text = pro.ToString();
            return pro;
        }
    }
}
