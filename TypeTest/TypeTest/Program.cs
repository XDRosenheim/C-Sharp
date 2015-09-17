using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Type P = typeof(Person);
            FieldInfo[] fields = P.GetFields();

            foreach (FieldInfo f in fields)
            {
                Console.WriteLine(f);
            }

            PropertyInfo[] props = P.GetProperties();
            foreach (PropertyInfo f in props)
            {
                Console.WriteLine(f);
            }
            
            /////////////////////

            var methods = P.GetMethods();
            Console.Write("\n");
            foreach (var m in methods)
            {
                Console.WriteLine(m);
            };

            var members = P.GetMembers();
            Console.Write("\n");
            foreach (var m in members)
            {
                Console.WriteLine(m);
            };

            ///////////////////// Dynamic

            Console.WriteLine();
            dynamic d = 5.6;
            Console.WriteLine(d);
            d = "Hej";
            Console.WriteLine(d);
            d = 9;
            Console.WriteLine(d);

            Console.ReadLine();
            Console.Clear();

            //////////////////////

            Elev el = new Elev();

            if (el is Elev) // Elev er Elev, ja.
                Console.WriteLine("Ja.");
            else
                Console.WriteLine("Nej.");

            if (el is Person) // Elev arver fra Person, så ja.
                Console.WriteLine("Ja.");
            else
                Console.WriteLine("Nej.");

            if (el is Object) // Elev arver fra PErson som arver fra Object, så ja.
                Console.WriteLine("Ja.");
            else
                Console.WriteLine("Nej.");

            if (el is String) // Elev er ikke en string.
                Console.WriteLine("Ja.");
            else
                Console.WriteLine("Nej.");

            Console.ReadLine();
        }
    }
}
