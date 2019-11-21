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
    }
}
