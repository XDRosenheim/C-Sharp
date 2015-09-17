using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest
{
    class Person
    {
        private int Id;
        public int Age;
        public String Name { get; set; }
        public int getAge(){return Age;}
    }

    class Elev : Person
    {
        public int Karakter { get; set; }
    }
}
