using System;
using System.Collections.Generic;

namespace Prøve
{
    class Program
    {
        public List<T> RandomMethodGoesHere()
        {
            Random rnd = new Random();
            if (rnd.Next(1,3) == 1)
            {
                return true;
            }
            return false;
        }

        

        List<T> filterList<T>(List<T> list, randomMethodGoesHere )
        {
            
        }
        
            
            
        private static void Main(string[] args)
        {
            #region opg1
            /*
             * SUMMARY:
             *      Anony metode - retunere true hvis string
             *      er større en 5
             */
            Func<string, bool> isThisStringLongerThanFiveCharactersFunc = (thisIsALongNameThatIcantPossibleUseAgain) => thisIsALongNameThatIcantPossibleUseAgain.Length >= 5;
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
            #region opg3
            /*
             * SUMMARY: 
             *      New class Elev, initialize with parameters.
             *      Make your own ToString()
             */
            Elev elev = new Elev("Peter", false, 1.80F, 12, "Android");
            Console.WriteLine(elev.ToString());
            #endregion
            #region opg4
            /*
             * SUMMARY:
             *      Test types and write them to console.
             *      Use GetType() and typeOf()
             */
            string textString = "Bam.";
            int intint = 12;
            Console.WriteLine("textString: {0}\n" +
                              "intint: {1}\n" +
                              "An int: {2}\n" +
                              "A string: {3}", textString.GetType(), intint.GetType(), typeof (int), typeof(string));
            #endregion
            #region opg5
            /*
             * SUMMARY:
             *      A method filterlist List<T> FilterList<T>(List<T> list, [A method that random returns true])
             */
            #endregion
            Console.ReadKey();
        }
    }
}