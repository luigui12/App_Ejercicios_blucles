using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Ejercicios_blucles.Funciones
{
   public static class Bucles
    {
        public static String saludos(int limite)
        {
            int i = 0;
            StringBuilder cad = new StringBuilder("Saludos:\t"+Environment.NewLine);
            while (i<limite)
            {
                i++;
                cad.Append(i.ToString() + ": Hola"+Environment.NewLine);

            }
            return cad.ToString();
        }
        public static long factorial(int num)
        {
            int i = 0;
            long fac = 1;
            if (num == 1 || num == 0)
                return 1;
            do
            {
                i++;
                fac = fac * i;
            }
            while (i < num);
            
                return num;
            
        }
    }
}
