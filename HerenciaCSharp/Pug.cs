
using System;
namespace HerenciaCSharp
{
    public class Pug : Perro, IMascota
    {
        public void pedirComida()
        {
            Console.WriteLine("El perro pide comida");
            Console.ReadKey();
        }
    }
}
