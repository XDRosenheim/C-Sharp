using System;
using System.Collections.Generic;

namespace DelegateFunkString
{
    class Program
    {
        delegate bool FilterFunk(string str);
        
        private static bool StartsWithP(string str)
        {
            return str.StartsWith("P");
        }

        private static bool EndWithN(string str)
        {
            return str.EndsWith("n");
        }

        private static bool CompareStringLenght(string a, string b){return a.Length > b.Length;}

        private static List<string> filterStrings(List<string> list, FilterFunk funk)
        {
            List<string> manyStringsList = new List<string>();
            foreach (string s in list)
            {
                if (funk(s))
                {
                    manyStringsList.Add(s);
                }
            }
            return manyStringsList;
        }

        static void Main(string[] args)
        {
            #region names
            List<string> navne = new List<string>()
            {
                "Christian",
                "Keld",
                "Oliver",
                "Patrick Rosen",
                "Patrick Øl",
                "Jan",
                "Flemming",
                "Steffan",
                "Mark",
                "Julia",
                "Tor"
            };
            #endregion
            #region foreach navn...
            Console.WriteLine("######\n# Start with P\n######");
            List<string> startWithList = filterStrings(navne, StartsWithP);
            foreach (string s in startWithList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("######\n# Ends with N\n######");
            List<string> endsWithList = filterStrings(navne, EndWithN);
            foreach (string s in endsWithList)
            {
                Console.WriteLine(s);
            }

            #endregion

            Console.WriteLine();
            FilterFunk f = delegate(string s) { return s.Contains("e"); };
            Console.WriteLine("######\n# Contains em\n######");
            List<string> myList = filterStrings(navne, f);
            foreach (string s in myList){Console.WriteLine(s);}

            Console.WriteLine();
            Console.WriteLine("######\n# Contains e\n######");
            List<string> newList = filterStrings(navne, delegate(string s) { return s.Contains("e"); });
            foreach (string s in newList){Console.WriteLine(s);}

            Console.WriteLine();
            Console.WriteLine("######\n# String Length more than (OR EQUALS) 6\n######");
            List<string> theList = filterStrings(navne, delegate(string s) { return s.Length >= 6; });
            foreach (string s in theList) { Console.WriteLine(s); }

            /*
             * Lambda
             */ 

            Console.WriteLine();
            Console.WriteLine("######\n# String Length more than 5\n######");
            List<string> myTheList = filterStrings(navne, s => s.Length > 5);
            foreach (string s in myTheList) { Console.WriteLine(s); }

            Console.WriteLine();
            Console.WriteLine("######\n# Contains e\n######");
            List<string> aList = filterStrings(navne, s => s.Contains("a"));
            foreach (string s in aList) { Console.WriteLine(s); }

            FilterFunk ff = str => str.Contains("n");
            Func<String, bool> fff = str => str.Contains("P");


            Console.ReadKey();
        }
    }
}
