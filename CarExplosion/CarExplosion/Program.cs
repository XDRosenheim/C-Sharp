using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var rover = new Car("Rover", 50, 90);

            rover.onCarExplode += onCarExplode;

            rover.Accelerate(20);
            rover.Accelerate(20);
            rover.Accelerate(20);
            rover.Accelerate(20);

            Console.ReadKey();
        }

        private static void onCarExplode(string message)
        {
            Console.WriteLine(message);
        }
    }
}
