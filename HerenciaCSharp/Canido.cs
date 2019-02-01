using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    public abstract class Canido : Mamifero
    {
        public void ladrar()
        {
            Console.WriteLine("Guau guau");
            Console.ReadKey();
        }
    }
}
