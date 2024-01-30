using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace R19A1_FranGV_V1
{

    /// <summary>
    /// Definición de la Enumeración para el tipo de Vehículo.
    /// </summary>

    public enum TipoVehiculo : byte { Turismo, Furgoneta, Camion };
    /// <summary>
    /// Deficición de la Enumeración para el Combustible.
    /// </summary>
    public enum TipoCombustible : byte {  Diesel, Gasolina, Hibrido, Electrico };

    /// <summary>
    /// Definición de la Enumeración para el Estado del Vehículo
    /// </summary>

    public enum TipoEstados : byte { Nuevo, Ocasion, SegundaMano };


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

        private TipoVehiculo _tipo;

        private TipoCombustible _combustible;

        private TipoEstados _estado;

        private float _precioContado;


        float _fechaMatriculacion; 

        // CONSTRUCTORES

        public Vehiculo()
        {
            _marca = "Desconocido";
            _modelo = "Desconocido";
            _tipo = TipoVehiculo.Turismo;
            _combustible = TipoCombustible.Diesel; ;
            _estado = TipoEstados.Nuevo;
            _precioContado = 0;
        }

     

        public Vehiculo(string mark, string model)
        {
            Marca = mark;
            Modelo = model;
            _tipo = TipoVehiculo.Turismo;
            _combustible = TipoCombustible.Diesel; ;
            _estado = TipoEstados.Nuevo;
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

                    ValidadarCaracteres(value);
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
               

               
                _modelo = value;


                ValidarCadena(value, MODELO_MIN, MODELO_MAX);

                ValidadarCaracterEspacio(value);


            }
        }

      


        public TipoVehiculo TipoV
        {
            get
            {
                return _tipo;
            }

            set
            {
                
                ValidarTipo(value);

                _tipo = value;
            }
        }

        public TipoCombustible Combustible
        {
            get
            {
                return _combustible;
            }

            set
            {
                ValidarCombustible(value);

                _combustible = value;
            }
        }

      

        public TipoEstados Estado
        {
            get
            {
                return _estado;
            }

            set 
            {
                ValidarEstado(value);

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
                ValidarNumero(value, PRECIOCONT_MIN, PRECIOCONT_MAX);

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


                ValidarFechaMatriculacion(value);


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

            // o por 0'90f

            // SALIDA - MÉTODO

            return PrecioFinanciado;
        }

        #region Metodos para excepciones

        private void ValidarCadena(string cadena, int tamMin, int tamMax)
        {
            if (String.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
            if (cadena.Length < tamMin) throw new Exception($"Longitud inferior a {tamMin} caracteres");
            if (cadena.Length > tamMax) throw new Exception($"Longitud superior a {tamMax} caracteres");


        
            if (!cadena.All(char.IsLetter)) throw new Exception("solo pueden usarse letras");

        }

        private void ValidarNumero(float num, int tamMin, int tamMax)
        {
            if (num > tamMax) throw new Exception("supera el rango maximo establecido");
            if (num < tamMin) throw new Exception("es menor al rango mínimo establecido");
        }

        private void ValidadarCaracterEspacio(string valor)
        {
            if ((!valor.All(char.IsLetterOrDigit))) throw new Exception("solo pueden usarse letras o dígitos");
        }

        private void ValidadarCaracteres(string valor)
        {
            if (!valor.All(char.IsLetter)) throw new Exception("solo pueden usarse letras");
        }











        private void ValidarTipo(TipoVehiculo dato)
        {
            // RECURSOS

            bool esValido = false;

            // VALIDACIÓN

            switch (dato)
            {
                case TipoVehiculo.Camion:
                    esValido = true;
                    break;
                case TipoVehiculo.Furgoneta:
                    esValido = true;
                    break;
                case TipoVehiculo.Turismo:
                    esValido = true;
                    break;
            }

            if (!esValido) 
            {
                throw new Exception("Tipo de vehículo erroneo");
            }
          
        }


        private void ValidarCombustible(TipoCombustible dato)
        {

          
        }

        private void ValidarEstado(TipoEstados dato)
        {
          
        }

        private void ValidarFechaMatriculacion(float valor)
        {
            //  No podrá establecerse una fecha posterior a la actual ni con una diferencia de 10 años


            if (valor > FechaActual) throw new Exception("fecha superior a la actual");

            if (valor < FechaActual - FEHCA_MAX) throw new Exception("fecha incorrecta");
        }

        #endregion
    }
}
