using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class user
{
    //task 1 . taking inputs. 2 sorting in an array.3 Display the array.4 Calculating the sum.

    //create an array 
    int[] numbers = new int[5];//class number - attribute

    //taking inputs
    public void taking5_Inputs()//Class member - behavior
    {
        Console.WriteLine("Enter 5 Numbers ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i}: ");
            numbers[i] = Int16.Parse(Console.ReadLine());
        }
    }

    public void DisplayArray()// Class member - behavior
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Array index {i}: {numbers[i]} ");
        }
    }

    //Sum function (Q Part inclz )
    public void CalculateSum()
    {
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            sum = sum + numbers[i];
        }

        Console.WriteLine("Sum of Array = " + sum);
    }

}

class Kavishka
{
    //Main function
    public static void Main(string[] args)
    {
        //create the obj of the class user
        user Kavishka1 = new user();

        Kavishka1.taking5_Inputs();
        Kavishka1.DisplayArray();
        Kavishka1.CalculateSum();

        Console.ReadLine();
    }
}