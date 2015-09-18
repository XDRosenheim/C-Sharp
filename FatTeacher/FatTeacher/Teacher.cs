using System;
using System.Timers;

namespace FatTeacher
{
    class Teacher
    {
        public string Name;
        public int Weight;
        public bool IsAwake;

        public Teacher(string name, int startWeight)
        {
            Name = name;
            Weight = startWeight;
            IsAwake = true;
        }

        public void FeedTeacher(int x)
        {
            Weight += x;
            Console.WriteLine("New weight: " + Weight);
            if (Weight >= 100)
            {
                IsAwake = false;
                Timer aTimer = new Timer(2000);
                aTimer.Elapsed += OnTimedEvent;
                aTimer.Enabled = true;
            }
        }

        public override string ToString()
        {
            string awake = IsAwake ? "Yes." : "No.";
            return "Name: " + Name + ".\nKG: " + Weight + ".\nIs it awake: " + awake;
        }
        
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("{0} is still sleeping @ {1}", Name, e.SignalTime);
        }
    }
}
