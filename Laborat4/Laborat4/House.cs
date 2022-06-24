using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat4
{
    class House
    {
        public House()
        {
            
        }
        public List<Pet> animals = new List<Pet>();

        public void AddAnimal(Pet pet)
        {
            animals.Add(pet);
        }
 
        public void CountAnimalTypes()
        {
            int catAmount = 0, dogAmount = 0, parrotAmount = 0;
            foreach (var item in animals)
            {
                if (item is Dog)
                {
                    dogAmount++;
                }
                if (item is Cat)
                {
                    catAmount++;
                }
                if (item is Parrot)
                {
                    parrotAmount++;
                }
            }
            Console.WriteLine("Кiлькiсть котiв у домi: "+catAmount);
            Console.WriteLine("Кiлькiсть собак у домi: "+dogAmount);
            Console.WriteLine("Кiлькiсть папуг у домi: "+parrotAmount);
        }   
    }
}
