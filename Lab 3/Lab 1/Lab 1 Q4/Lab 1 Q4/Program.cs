<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Item price : ");//Get by user input one Item.
            double numItem = double.Parse(Console.ReadLine());

            Console.Write("Enter the Quantity you purchased : ");//Get by user input how many Items.
            double quantity = double.Parse(Console.ReadLine());

            double total = numItem * quantity;//Calculate the total Cost.

            Console.WriteLine("Your Total cost is Rs." + total + ".00");//Display the Final result.        


        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Item price : ");//Get by user input one Item.
            double numItem = double.Parse(Console.ReadLine());

            Console.Write("Enter the Quantity you purchased : ");//Get by user input how many Items.
            double quantity = double.Parse(Console.ReadLine());

            double total = numItem * quantity;//Calculate the total Cost.

            Console.WriteLine("Your Total cost is Rs." + total + ".00");//Display the Final result.        


        }
    }
}
>>>>>>> 39f9b9eaf46f67545936fd17d8628429ac78c46c
