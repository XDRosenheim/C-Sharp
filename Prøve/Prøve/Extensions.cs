using System.Collections.Generic;
using System.Linq;

namespace Prøve
{
    public static class Extensions
    {
        public static int VowelCount(this string s)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' }; // Engelske vokaler   -y
            return s.Count(t => vowels.Contains(t));
        }
        public static int ConsonantCount(this string s)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            return s.Count(t => !vowels.Contains(t));
        }
        public static string ToStoreBogstaver(this string s)
        {
            return s.ToUpper();
        }
    }
}
