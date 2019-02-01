using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    public class Gato : Mamifero, IMascota
    {
        public void ronronear()
        {
            Console.WriteLine("Grrrrr");
            Console.ReadKey();
        }

        public void pedirComida()
        {
            Console.WriteLine("El gato pide comida");
            Console.ReadKey();
        }
    }
}
