namespace PruebaAzure.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public abstract class Persona : IEntity
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Cédula")]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Primer apellido")]
        public string Apellido1 { get; set; }

        [Display(Name = "Segundo apellido")]
        public string Apellido2 { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        public Persona() { }
    }
}
