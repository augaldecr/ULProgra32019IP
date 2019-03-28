namespace PruebaAzure.Data.Entities
{
    using System;

    public class Trimestre : IEntity
    {
        public int Id { get; set;  }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }

        public Trimestre() { }
    }
}