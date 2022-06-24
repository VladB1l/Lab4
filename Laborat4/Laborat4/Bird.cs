using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat4
{
    class Bird:Pet
    {
        public Bird(string name, string color) : base(name, color)
        {
            Name = name;
            Color = color;
        }
        public override void GetRoar()
        {
            Console.WriteLine($"Папуга  каже 'Цвiрiньк'. ");
        }
        public override void GetColor()
        {
            Console.WriteLine($"Колiр папуги {Color}.");
        }
        public override void GetName()
        {
            Console.WriteLine($"Iм'я папуги {Name}. ");
        }
       /* public override void GetCount()
        {
            Console.WriteLine($"Ви придбали всього  папуг: {Number}.");
        }*/
    }

    class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
            Name = name;
            Color = color;
            
        }

    }
}
