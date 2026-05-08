using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter NUmber 1 : ");//Get by user input Number 1.
            int num1 = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");//Get by user input Number 1.
            int num2 = Int16.Parse(Console.ReadLine());

            int calculate = num1 + num2;//Calculate.

            Console.WriteLine("Final Answer: " + calculate);//Final result show.
        }
    }
}
