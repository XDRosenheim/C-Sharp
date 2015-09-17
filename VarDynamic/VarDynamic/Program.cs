using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var tal = 7;

            String[] navne = { "Navn1", "Navn2", "Navn3", "Navn4", "Navn5", "Navn6", "Navn7" };

            var navnene = from n in navne
                          where n.Contains("in")
                          select n;


        }
    }
}
