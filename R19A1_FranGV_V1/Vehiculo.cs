using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace R19A1_FranGV_V1
{
    public class Vehiculo
    {
        // CONSTANTES

        // MARCA
        private const int MARCA_MAX = 20;
        private const int MARCA_MIN = 3;

        // MODELO
        private const int MODELO_MAX = 25;
        private const int MODELO_MIN = 4;

        // PRECIO CONTADO
        private const int PRECIOCONT_MAX = 100000;
        private const int PRECIOCONT_MIN = 1000;

        // FECHA MATRICULACIÓN
        private const int FEHCA_MAX = 10;


        private const float descuento = 90;  // El descuento es la diferencia: 90 --> 10% de descuento


        // MIEMBROS

        private string _marca;

        private string _modelo;

        private string _tipo;

        private string _combustible;

        private string _estado;

        private float _precioContado;


        float _fechaMatriculacion; 

        // CONSTRUCTORES

        public Vehiculo()
        {
            _marca = "Desconocido";
            _modelo = "Desconocido";
            _tipo = "Turismo";
            _combustible = "Diesel";
            _estado = "Nuevo";
            _precioContado = 0;
        }

     

        public Vehiculo(string mark, string model)
        {
            Marca = mark;
            Modelo = model;
            _tipo = "Turismo";
            _combustible = "Diesel";
            _estado = "Nuevo";
            _precioContado = 0;
        }








        // PROPIEDADES




        // Propiedad para el metodo que devuelve la fecheca altual
        public int FechaActual
        {
            get
            {
                return fechaActual();
            }
        }




        /// <summary>
        /// Devuelve el método PreciosFinanciados()
        /// </summary>
        public float PrecioFinanciado
        {
            get
            {
                return PreciosFinanciado();
            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {

                try
                {
                    ValidarCadena(value, MARCA_MIN, MARCA_MAX);
                }
                catch (Exception Error)
                {
                    throw new Exception("Marca: " + Error.Message);
                }

                _marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                if (value.Length > MARCA_MAX) throw new Exception("supera el rango máximo de caracteres");
                if (value.Length < MARCA_MIN) throw new Exception("es inferior a11l rango máximo de caracteres.");

                if ((!value.All(char.IsLetterOrDigit) && !value.All(char.IsWhiteSpace))) 
                    throw new Exception("solo pueden usarse letras o dígitos");
                _modelo = value;

            }
        }

        public string Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                value = value.ToLower();

                if (value != "turismo" && value != "furgoneta" && value != "camión" && value != "camion") throw new Exception("solo puede ser elegido el vehiculo correcto");

                _tipo = value;
            }
        }

        public string Combustible
        {
            get
            {
                return _combustible;
            }

            set
            {

                value = value.ToLower();

                if (value != "diesel" && value != "gasolina" && value != "hibrido" && value != "electrico") throw new Exception("opción incorrecta");
                _combustible = value;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }

            set 
            {
                value = value.ToLower();

                if (value != "nuevo" && value != "ocacion" && value != "segunda mano") throw new Exception("opción incorrecta");
                _estado = value; 
            }    
        }

        public float PrecioContado
        {
            get
            {
                return _precioContado;
            }

            set 
            { 
                if (value > PRECIOCONT_MAX) throw new Exception ("el precio supera el rango maximo establecido");
                if (value < PRECIOCONT_MIN) throw new Exception("el precio es menor al rango mínimo establecido");

                _precioContado = value; 
            }
        }

        public float FechaMatriculacion
        {
            get
            {
                return _fechaMatriculacion;
            }

            set
            {


                //  No podrá establecerse una fecha posterior a la actual ni con una diferencia de 10 años


                if (value > FechaActual) throw new Exception("fecha superior a la actual");

                if (value < FechaActual - FEHCA_MAX) throw new Exception("fecha incorrecta");

                // TODO: pene

                _fechaMatriculacion = value;
            }
        }

        // METODOS
        
        /// <summary>
        /// Genera el año actual
        /// </summary>
        /// <returns>Devuelve el año actual</returns>
        private int fechaActual()
        {
            int fechaActual = DateTime.Now.Year;

            return fechaActual;
        }


        // El precio del vehículo financiado tendrá un descuento del 10% del precio del vehículo al contado.

        /// <summary>
        ///  descuento del 10% del precio del vehículo al contado
        /// </summary>
        /// <returns>descuento del 10%</returns>
        private float PreciosFinanciado()
        {
            // RECURSOS

            float PrecioFinanciado = 0;

            // PROCESO

            PrecioFinanciado = PrecioContado * descuento / 100;

            // SALIDA - MÉTODO

            return PrecioFinanciado;
        }

        private void ValidarCadena(string cadena, int tamMin, int tamMax)
        {
            if (String.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
            if (cadena.Length < tamMin) throw new Exception($"Longitud inferior a {tamMin} caracteres");
            if (cadena.Length > tamMax) throw new Exception($"Longitud superior a {tamMax} caracteres");


        
            if (!cadena.All(char.IsLetter)) throw new Exception("solo pueden usarse letras");

        }


    }
}
