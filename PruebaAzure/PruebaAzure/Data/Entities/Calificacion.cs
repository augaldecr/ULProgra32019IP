namespace PruebaAzure.Data.Entities
{
    public class Calificacion : IEntity
    {
        public int Id { get; set; }
        public Estudiante Estudiante { get; set; }
        public Asignatura Asignatura { get; set; }
        public Trimestre Trimestre { get; set; }
        public decimal Nota { get; set; }
        public EstadoAsignatura Estado { get; set; }

        public Calificacion() { }
    }
}
