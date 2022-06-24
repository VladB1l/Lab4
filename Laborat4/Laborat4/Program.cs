using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat4
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Console.WriteLine("Скiльки тварин ви хочете придбати:");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Кiт;");
            Console.WriteLine("2. Собака;");
            Console.WriteLine("3. Папуга;\n");
            int counter = 0;
            while (counter!=amount)
            {
                Console.WriteLine("\nОберiть яку тваринку хочете придбати:");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                switch (count)
                {
                    case 1:
                        Console.WriteLine("Введiть iм'я котика:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введiть колiр котика:");
                        string color = Console.ReadLine();
                        
                        house.AddAnimal(new Cat(name,color));
                        break;
                    case 2:
                        Console.WriteLine("Введiть iм'я собаки:");
                        name = Console.ReadLine();
                        Console.WriteLine("Введiть колiр собаки:");
                        color = Console.ReadLine();
                      
                        house.AddAnimal(new Dog(name, color));
                        break;
                    case 3:
                        Console.WriteLine("Введiть iм'я папуги:");
                        name = Console.ReadLine();
                        Console.WriteLine("Введiть колiр папуги:");
                        color = Console.ReadLine();
                      
                        house.AddAnimal(new Parrot(name,color));
                        break;
                    default:
                        Console.WriteLine("Немає такого звiра");
                        continue;
                 
                }
                counter++;
            }

            Console.WriteLine("\nСписок тварин, яких ви придбали:");
            foreach (Pet pet in house.animals)
            {
                Console.WriteLine(" ");
                pet.GetName();
                pet.GetColor();
                pet.GetRoar();
            }
            Console.WriteLine(" ");
            
            house.CountAnimalTypes();
            Console.ReadLine();
        }
    }
}
