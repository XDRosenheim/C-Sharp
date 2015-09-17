using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void Compute(int a, int b);

        static void Add(int tal1, int tal2) 
        {
            Console.WriteLine("{0} + {1} = {2}", tal1, tal2, tal1+tal2 );
        }
        static void Sub(int tal1, int tal2)
        {
            Console.WriteLine("{0} - {1} = {2}", tal1, tal2, tal1 - tal2);
        }
        static void Mul(int tal1, int tal2)
        {
            Console.WriteLine("{0} * {1} = {2}", tal1, tal2, tal1 * tal2);
        }
        static void Div(int tal1, int tal2)
        {
            Console.WriteLine("{0} / {1} = {2}", tal1, tal2, tal1 / tal2);
        }

        static void Main(string[] args)
        {
            Compute c = Add;
            c += Sub;
            c += Mul;
            c += Div;

            c(20, 5);
            Console.ReadLine();
        }
    }
}
