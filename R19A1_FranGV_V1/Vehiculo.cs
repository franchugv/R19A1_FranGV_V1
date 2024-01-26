using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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





        // MIEMBROS

        private string _marca;

        private string _modelo;

        private string _tipo;

        private string _combustible;

        private string _estado;

        private float _precioContado;


        float fechaMatriculacion; 

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

        public Vehiculo(string mark)
        {
            Marca = mark;
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

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                if (value.Length > MARCA_MAX) throw new Exception("supera el rango máximo de caracteres.");
                if (value.Length > MARCA_MIN) throw new Exception("es inferior a11l rango máximo de caracteres.");

                string.Format
                _marca = value;
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

        private char CaracterMax()
        {
            char caracter;
        }

    }
}
