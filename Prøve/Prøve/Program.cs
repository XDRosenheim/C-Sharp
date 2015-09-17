using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Prøve
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region opg1

            /*
             * SUMMARY:
             *      Anony metode - retunere true hvis string
             *      er større en 5
             */
            Func<string, bool> isThisStringLongerThanFiveCharactersFunc = (thisIsALongNameThatIcantPossibleUseAgain) =>
            {
                return thisIsALongNameThatIcantPossibleUseAgain.Length >= 5;
            };
            Console.WriteLine(isThisStringLongerThanFiveCharactersFunc("No")); // Lenght = 2
            Console.WriteLine(isThisStringLongerThanFiveCharactersFunc("This is")); // Lenght == 7

            #endregion
            #region opg2

            /*
             * SUMMARY:
             *      Bubblesort, anonym metode, compare string on lenght.
             *      
             * COMMENT:
             *      
             */
            Func<string, string, bool> areTheseTwoStringsTheSameLenghtFunc = (s1, s2) => s1.Length > s2.Length;

            #endregion
            Elev elev = new Elev("Peter", false, 1.80F, 12, "Android");
            Console.WriteLine(elev.ToString());


            Console.ReadKey();
        }
    }
}