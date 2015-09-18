using System;
using System.Collections.Generic;

namespace Eksamamam
{
    class Program
    {

        #region opg4
        public delegate int Opg4Dele<T>(T input, T output);
        static T GetOne<T>(T x, T y, T z, int o)
        {
            T[] strings = {x, y, z};
            return strings[o - 1];
        }

        #endregion

        #region opg6
        public delegate string StringWorker(string s);
        #endregion
        
        static void Main(string[] args)
        {
            #region Opg1 - Done
            Console.WriteLine("------------ Opgave 1 ------------");
            var opg1Person = new { id = 42, Fornavn = "Peter", Efternavn = "Leasy", Adresse = "Danmark..."};
            Console.WriteLine("ID: {0}\n" + "Fornavn: {1}\n" +"Efternavn: {2}\n" +"Adresse: {3}", 
                opg1Person.id, opg1Person.Fornavn, opg1Person.Efternavn, opg1Person.Adresse);
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Opg2 - Done
            Console.WriteLine("------------ Opgave 2 ------------");
            var opg2Person = new Person(41, "Benny", "Bennysen", "Østerstatsfængsel");
            Console.WriteLine(opg2Person.ToString());
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opg3 - Done
            Console.WriteLine("------------ Opgave 3 ------------");
            var opg3Anon = new {Fornavn = opg2Person.Fornavn, Efternavn = opg2Person.Efternavn};
            Console.WriteLine(opg3Anon);
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opg4 - Done
            Console.WriteLine("------------ Opgave 4 ------------");
            var opg4tal = GetOne<int>(55, 66, 77, 1);
            Console.WriteLine(opg4tal);
            var opg4str = GetOne<string>("Navn 1", "Navn 2", "Navn 3", 2);
            Console.WriteLine(opg4str);
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opg5 - Done
            Console.WriteLine("------------ Opgave 5 ------------");
            var opg5Str = "Hej med jer. Nu er det snart weekend og det der!";
            opg5Str.PrintStrPart(13, 35);
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opg6 - WIP
            Console.WriteLine("------------ Opgave 6 ------------");
            string opg6String = "Nu er det snart weekend! Det er rigtig dejligt !";
            //Console.WriteLine();
            Console.WriteLine("Skip.");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opg7 - SKIP
            Console.WriteLine("------------ Opgave 7 ------------");
            Console.WriteLine("SKip.");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opg8 - SKIP
            Console.WriteLine("------------ Opgave 8 ------------");
            var opg8ListOfInts = new List<int>{12, 23, 34, 1, 45, 56, 67, 78, 6, 89, 90, 72, 9, 5, 7};
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
