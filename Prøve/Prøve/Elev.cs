﻿using System;
using System.Threading;

namespace Prøve
{
    class Elev
    {
        public string Navn, Subject;
        public bool IsDumpet;
        public float Height;
        public int Grade;

        public Elev(string navn, bool isDumpet, float height, int grade, string subject)
        {
            //this.Navn = navn;
            Navn = navn;
            IsDumpet = isDumpet;
            Height = height;
            Grade = grade;
            Subject = subject;
        }

        public void SetTime(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Done");
        }

        public override string ToString()
        {
            var dumpet = IsDumpet ? "Ja." : "Nej";
            return "Navn: " + Navn + " Dumpet: " + dumpet + " Højde: " + Height + " Karakter: " + Grade + " Emne: " + Subject;
        }
    }
}
