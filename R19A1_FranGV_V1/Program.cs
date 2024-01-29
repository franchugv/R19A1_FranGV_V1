namespace R19A1_FranGV_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // RECURSOS

            Vehiculo Transporte;



            // INICIALIZACION

            Transporte = new Vehiculo();

            // ENTRADA

            Transporte.Marca = Interfaz.SolicitarCadena("su marca");

            Transporte.Modelo = Interfaz.SolicitarCadena("su modelo");

            Transporte.Tipo = Interfaz.SolicitarCadena("tipo de vehículo");

            Transporte.Estado = Interfaz.SolicitarCadena("su estado");

            Transporte.FechaMatriculacion = Interfaz.SolicitarNumero("la fecha de matriculación");

            Transporte.Combustible = Interfaz.SolicitarCadena("su tipo de combustible");

            Transporte.PrecioContado = Interfaz.SolicitarNumero("el precio al Contado");

            // PROCESO

            // SALIDA

        }
    }
}