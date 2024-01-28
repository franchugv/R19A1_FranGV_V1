using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19A1_FranGV_V1
{
    public static class Comprobaciones
    {

        public static void ErrorCadena(string cadena)
        {
            // Comprocaciones
            // Cadena Vacía

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
        }

        public static float ErrorNumeros(string cadena)
        {
            // RECURSOS

            float Num = 0;

            // Comprobaciones
            // Cadena Vacía

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");

            // Conversión

            Num = Convert.ToSingle(cadena);

            // Salida Método

            return Num;
        }

    }
}
