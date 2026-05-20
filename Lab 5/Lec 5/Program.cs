
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_5
{  
    class dog
    {
        string name;
        public dog(string dogName)
        {
            name = dogName;
            Console.WriteLine("dog name is: " + name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            dog d1 = new dog("babbi");
            dog d2 = new dog("suuti");
            Console.ReadLine();
        }
    }
}