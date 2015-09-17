using System;
using System.Timers;

namespace Prøve
{
    class Program
    {
        //private static int counter = 0;
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine(e.SignalTime);
            //Console.WriteLine(counter);
            //counter++;
        }

        private static Timer _aTimer;
        private static void Main(string[] args)
        {
            _aTimer = new Timer(100);
            _aTimer.Elapsed += OnTimedEvent;
            _aTimer.Enabled = true;

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
             */

            #endregion


            Console.ReadKey();
        }
    }
}