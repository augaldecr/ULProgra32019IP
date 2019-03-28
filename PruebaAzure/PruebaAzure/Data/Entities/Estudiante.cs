namespace PruebaAzure.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Estudiante : Persona
    {
        [Required]
        public string Carnet { get; set; }

        public Estudiante() { }
    }
}
