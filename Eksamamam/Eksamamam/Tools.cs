using System;
using System.Collections.Generic;

namespace Eksamamam
{
    public static class Tools
    {
        #region opg5
        public static void PrintStrPart(this string s, int start, int slut)
        {
            for (var i = start; i <= slut; i++)
            {
                Console.Write(s[i]);
            }
        }
        #endregion
        #region opg6
        public static string GetFirstHalf(string s){return s.Substring(0, (s.Length/2));}
        public static string GetLastHalf(string s){return s.Substring((s.Length/2), s.Length);}
        #endregion
        #region opg8
        
        ////////
        /// Kunne ikke finde ud af det der skulle gøres, så prøvede på en anden måde..
        ////////
        
        public static List<int> GetSome(List<int> theList)
        {
            var newList = new List<int>();
            for (var i = 0; i < theList.Count; i++)
            {
                if (theList[i] %2 != 0)
                {
                    newList.Add(theList[i]);
                }
            }
            return newList;
        }
        #endregion
    }
}
