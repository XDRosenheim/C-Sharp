using System;
using System.Timers;

namespace Prøve
{
    class Program
    {
        private static Timer _aTimer;
        private static void Main()
        {
            #region Stuff
            #region opg1
            /*
             * SUMMARY:
             *      Anony metode - retunere true hvis string
             *      er større en 5
             *      
             * COMMENT:
             *      Undskyld det lange Func navn.
             */
            Console.WriteLine("1");
            Func<string, bool> isThisStringLongerThanFiveCharactersFunc = thisIsALongNameThatIcantPossibleUseAgain => thisIsALongNameThatIcantPossibleUseAgain.Length >= 5;
            Console.WriteLine(isThisStringLongerThanFiveCharactersFunc("No")); // Lenght = 2
            Console.WriteLine(isThisStringLongerThanFiveCharactersFunc("This is")); // Lenght == 7
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region opg2
            /*
             * SUMMARY:
             *      Bubblesort, anonym metode, compare string on lenght.
             *      
             * COMMENT:
             *      K.
             */
            // ReSharper disable once UnusedVariable
            Func<string, string, bool> areTheseTwoStringsTheSameLenghtFunc = (s1, s2) => s1.Length > s2.Length;
                //Send some kode to areTheseTwoStringsTheSameLenghtFunc
            #endregion
            #region opg6
            /*
             * SUMMARY: 
             *      New class Elev, initialize with parameters.
             *      Make your own ToString()
             */
            Elev elev = new Elev("Peter", false, 1.80F, 12, "Android");
            Console.WriteLine(elev.ToString());
            #endregion
            #region opg7
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
                              "A string: {3}", textString.GetType(), intint.GetType(), typeof(int), typeof(string));
            #endregion
            #region opg10-11-12
            /*
             * SUMMARY:
             *      Lav to (Har lavet tre..) extensions til strings.
             *      1   ) returnere antalet af vokaler i en string.
             *      1.5 ) retunere antalet af konsonanter i en string.
             *      2   ) modtag en string, returner samme string, men med store bogstaver.
             */
            string aText = "This is a long text on which we will count the amount of vowels and consonants. And to uppercase";
            Console.WriteLine(aText + "..   Vowel count: " + aText.VowelCount());
            Console.WriteLine(aText + "..   Consonant count: " + aText.ConsonantCount());
            #endregion
            #endregion

            Console.WriteLine(aText.ToStoreBogstaver());
            _aTimer = new Timer(1000);
            _aTimer.Elapsed += elev.SetTime;
            _aTimer.Enabled = true;
            Console.WriteLine("Press any key, to stop the loop...");
            Console.ReadKey();
            _aTimer.Enabled = false;
            Console.ReadKey();
        }
    }
}