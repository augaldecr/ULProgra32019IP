namespace PruebaAzure.Data.Entities
{
    public class Asignatura : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Asignatura() { }
    }
}
