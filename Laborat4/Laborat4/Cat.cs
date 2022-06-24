using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat4
{
    class Cat : Pet
    {
        public Cat(string name, string color) : base(name, color)
        {
            Name = name;
            Color = color;
       
        }
        public override void GetRoar()
        {
            Console.WriteLine($"Кiт  каже 'Мяу'.");
        }
        public override void GetColor()
        {
            Console.WriteLine($"Колiр котика {Color}.");
        }
        public override void GetName()
        {
            Console.WriteLine($"Iм'я котика {Name}. ");
        }
       /* public override void GetCount()
        {
            Console.WriteLine($"Ви придбали всього  котiв: {Number}.");
        }*/
    }
}
