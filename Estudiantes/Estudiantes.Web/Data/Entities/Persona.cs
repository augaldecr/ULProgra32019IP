namespace Estudiantes.Web.Data.Entities
{
    public abstract class Persona : IEntity
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}
