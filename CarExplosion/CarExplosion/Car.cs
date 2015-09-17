using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExplosion
{
    class Car
    {
        public String Name { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }
        public bool carAlive = true;
        public Car(String name, int speed, int maxSpeed)
        {
            Name = name;
            Speed = speed;
            MaxSpeed = maxSpeed;
        }
        public delegate void onCarEvent(String message);
        public event onCarEvent onCarExplode;
        public void Accelerate(int delta)
        {
            if (carAlive)
            {
                Speed += delta;
                Console.WriteLine("GOTTA GO FAST!: " + Speed);
                if (Speed > MaxSpeed)
                {
                    onCarExplode("Car is explode.");
                    carAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Sorry, Car is ded.");
            }
        }
    }

}
