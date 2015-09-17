using System;
using System.Collections.Generic;
using OrderLib;

namespace DelegateComparer
{
    class Program
    {
        private delegate bool CompareMethod<T>(T a, T b);
        private static bool CompareIntAsc(int a, int b) { return a > b; }
        private static bool CompareIntDesc(int a, int b) { return a < b; }        
        private static bool CompareStringAsc(string a, string b){return a.CompareTo(b) > 0;}
        private static bool CompareStringDesc(string a, string b){return b.CompareTo(a) > 0;}
        private static bool CompareOrderAmount(Order a, Order b) { return a.OrderAmount > b.OrderAmount; }
        private static bool CompareStringLenght(Order a, Order b){ return a.CustomerName.Length > b.CustomerName.Length; }

        static void BubbleSort<T>(List<T> theList, CompareMethod<T> compMethod)
        {
            bool sorted = false;
            int top = 1;

            while (!sorted)
            {
                for (int i = 0; i < theList.Count - top; i++)
                {
                    sorted = true;
                    if (compMethod(theList[i], theList[i+1]))
                    {
                        sorted = false;
                        T temp = theList[i + 1];
                        theList[i + 1] = theList[i];
                        theList[i] = temp;
                    }
                }
                top++;
            }

        }

        static void Main(string[] args)
        {
            #region Ascending
            var list = new List<int> { 123, 51, 53, 1, 634, 12, 76, 254, 673, 234, 626, 5 };
            BubbleSort(list, CompareIntAsc);
            Console.WriteLine("Ascending ints...");
            foreach (var i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Descending
            var list2 = new List<int> {2435, 12, 63, 2, 72, 674, 2532, 123, 234523, 45, 234523, 45234526, 34534, 2134};
            BubbleSort(list2, CompareIntDesc);
            Console.WriteLine("Descending ints...");
            foreach (var i in list2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Ascending Ints
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
            BubbleSort(navne, CompareStringAsc);
            Console.WriteLine("Ascending Strings...");
            foreach (var s in navne)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            #endregion

            #region Ascending Ints
            #region names
            List<string> navne2 = new List<string>()
            {
                "Christian","Keld","Oliver", "Patrick Rosen",
                "Patrick Øl","Jan","Flemming","Steffan",
                "Mark","Julia","Tor","Gert"
            };
            #endregion
            BubbleSort(navne2, CompareStringDesc);
            Console.WriteLine("Descending Strings...");
            foreach (var s in navne2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            #endregion

            #region Orders
            List<Order> orders = Helper.makeOrders();
            BubbleSort(orders, CompareOrderAmount);
            foreach (var o in orders)
            {
                Console.WriteLine("ID: {0}  Amount: {1}  ", o.OrderId, o.OrderAmount);
            }
            #endregion

            Console.WriteLine();
            List<Order> orders2 = Helper.makeOrders();
            BubbleSort(orders2, CompareStringLenght);
            foreach (var s in orders2)
            {
                Console.WriteLine("ID: {0}  Navn: {1}  Amount: {2}  ",s.OrderId, s.CustomerName, s.OrderAmount);
            }

            Console.ReadKey();
        }
    }
}
