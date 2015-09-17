using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymeTyper
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyPerson = new { name = "Navn1", shoeSize = 46 };
            Console.WriteLine(MyPerson.ToString());
            System.Console.WriteLine(MyPerson.name + " " + MyPerson.shoeSize);
            Console.WriteLine(MyPerson.GetType());
            Console.WriteLine();
            var MyPerson2 = new { name = "Navn1", shoeSize = 47 };
            Console.WriteLine(MyPerson2.ToString());
            System.Console.WriteLine(MyPerson2.name + " " + MyPerson2.shoeSize);
            Console.WriteLine(MyPerson2.GetType());
            Console.WriteLine();
            var MyPerson3 = new { name = "Navn1", shoeSize = 47, smokedSalmon = true };
            Console.WriteLine(MyPerson3.ToString());
            System.Console.WriteLine(MyPerson3.name + " " + MyPerson3.shoeSize);
            Console.WriteLine(MyPerson3.GetType());

            Console.WriteLine();

            List<CuteAnimal> animals = new List<CuteAnimal>()
            {
                new CuteAnimal(){type = "Elephant", name = "Dododoni", age = 57, isRealCute = false, color = ConsoleColor.Gray},
                new CuteAnimal(){type = "Elephant", name = "Dodokino", age = 45, isRealCute = true, color = ConsoleColor.Gray},
                new CuteAnimal(){type = "Zebra", name = "Dodo", age = 14, isRealCute = false, color = ConsoleColor.DarkGray},
                new CuteAnimal(){type = "Dodo", name = "Dodolino", age = 16, isRealCute = false, color = ConsoleColor.Magenta},
                new CuteAnimal(){type = "Giraphaf", name = "Dodolina", age = 74, isRealCute = true, color = ConsoleColor.Red},
                new CuteAnimal(){type = "Lion", name = "Dodomino", age = 25, isRealCute = true, color = ConsoleColor.Blue},
                new CuteAnimal(){type = "Goat", name = "Dodomomi", age = 53, isRealCute = false, color = ConsoleColor.Green}
            };

            var dyrene = from i in animals
                      where i.color == ConsoleColor.Gray
                      select new { name = i.name, Cute = i.isRealCute };

            foreach (var dyret in dyrene)
                Console.WriteLine(dyret.name + " is " + (dyret.Cute ? "":"not ") + "cute");


            Console.ReadLine();
        }
    }
}
