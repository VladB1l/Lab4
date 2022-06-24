using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat4
{
    class Dog : Pet
    {
        public Dog(string name, string color ) : base(name, color)
        {
            Name = name;
            Color = color;
         
        }
        public override void GetRoar()
        {
            Console.WriteLine($"Собака  каже 'Гав'.");
        }
        public override void GetColor()
        {
            Console.WriteLine($"Колiр собаки {Color}.");
        }
        public override void GetName()
        {
            Console.WriteLine($"Iм'я собаки {Name}. ");
        }
        /*public override void GetCount()
        {
            Console.WriteLine($"Ви придбали всього собак: {Number}.");
        }*/
    }
}
