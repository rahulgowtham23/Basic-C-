using System;
namespace TypeConversion;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number 1:");

        //Type conversion from string to interger
        int num1 = Convert.ToInt32(Console.ReadLine());


        Console.Write("Enter a number 2:");
        int num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter a double number:");
        double num3 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;

        //GetType is used to find the type of data
        Console.WriteLine(num3.GetType());
       
    }
}