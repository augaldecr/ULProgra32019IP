
using System;
namespace APurosIF
{
    public enum Estados
    {
        Ïnactiva,
        Activa,
        Pausada,
        Cancelada
    }

    public class Conexion
    {
        public Estados Estado;

        public Conexion()
        {
            this.Estado = Estados.Ïnactiva;
        }

        public void Conectar()
        {
            this.Estado = Estados.Activa;
        }

        public void Desconectar()
        {
            this.Estado = Estados.Ïnactiva;
        }


        public void Pausar()
        {
            this.Estado = Estados.Pausada;
        }

        public void Cancelar()
        {
            this.Estado = Estados.Ïnactiva;
        }
    }
}
