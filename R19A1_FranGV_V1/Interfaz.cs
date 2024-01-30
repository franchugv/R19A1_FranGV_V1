using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19A1_FranGV_V1
{
    public static class Interfaz
    {

        public static byte SolicitarEnum(string text)
        {
            // RECURSOS

            byte dato;
            string aux;
            bool esValido;

            // INICIALIZACIÓN

            dato = 0;
            aux = "";

            // ENTRADA

            do
            {
                // RESET
                esValido = true;

                // ENTRADA

                Console.Write($"Escriba {text} : ");
                aux = Console.ReadLine();

                try
                {
                    Comprobaciones.ErrorByte(aux);
                }
                catch(Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {aux}");
                }


            }while(!esValido);

            // PROCESO

            // SALIDA

            return dato;
        }

        public static string SolicitarCadena(string text)
        {
            // RECURSOS

            bool esValido;
            string dato;

            // INICIALIZACION

            dato = "";

            // ENTRADA

            do
            {
                // RESET

                esValido = true;

                // DO - WHILE

                Console.Write($"Escriba {text}: ");
                dato = Console.ReadLine();


                try
                {
                    Comprobaciones.ErrorCadena(dato);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error}");
                }

            } while (!esValido);

            // PROCESO

            // SALIDA

            return dato;
        }



        public static float SolicitarNumero(string text)
        {
            // RECURSOS

            bool esValido;  // Comprobador para el bucle
            float dato; // Dato a devolver
            string aux;

            // INICIALIZACION

            dato = 0;

            aux = "";

            // ENTRADA

            do
            {
                // RESET

                esValido = true;

                // DO - WHILE

                Console.Write($"Escriba {text}: ");
                aux = Console.ReadLine();

                try
                {
                    dato = Comprobaciones.ErrorNumeros(aux);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error}");
                }

            } while (!esValido);

            // PROCESO

            // SALIDA

            return dato;
        }


    }
}
