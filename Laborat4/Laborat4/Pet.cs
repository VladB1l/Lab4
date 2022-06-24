using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat4
{
    abstract class Pet
    {
        public Pet(string name, string color)
        {
            Name = name;
            Color = color;
         
        }
        public string Name { get; set; }
        public string Color { get; set; }
    
        public abstract void GetRoar();
        public abstract void GetColor();
        public abstract void GetName();
       /* public abstract void GetCount();*/
        

    }
}
