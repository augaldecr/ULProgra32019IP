using System;

namespace APurosIF
{
    class Program
    {
        static void Main(string[] args)
        {
            var conekcion = new Conexion();

            if (conekcion.Estado != Estados.Activa)
            {
                conekcion.Conectar();
            }

            if (conekcion.Estado != Estados.Cancelada)
            {
                conekcion.Cancelar();
            }

            if (conekcion.Estado != Estados.Ïnactiva)
            {
                conekcion.Cancelar();
            }

            if (conekcion.Estado != Estados.Pausada)
            {
                conekcion.Desconectar();
            }

            Console.WriteLine(conekcion.Estado);
            Console.ReadKey();
        }
    }
}
