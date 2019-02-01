using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sanson = new Pug
                {
                    Color = "Negro",
                    Pelaje = "Largo",
                };

            var garfield = new Gato
            {
                Color = "Gris",
                Pelaje = "Sin pelo",
            };

            sanson.ladrar();
            garfield.ronronear();

        }
    }
}
