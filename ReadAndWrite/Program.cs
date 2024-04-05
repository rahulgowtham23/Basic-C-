using System;
namespace ReadAndWrite;

class Program
{
    public static void Main(string[] args)
    {
        //Getting the inputs
        Console.Write("Enter your Name:");
        string name = Console.ReadLine();
        Console.Write("Enter your Father Name:");
        string fatherName = Console.ReadLine();

        /*//Printing the results
        //Concatenation
        Console.WriteLine(name+" "+fatherName);

        //Placeholder
        Console.WriteLine("{0} {1}",name,fatherName);
        Console.WriteLine("{0} {1}",fatherName,name);
        Console.WriteLine("{1} {0}",name,fatherName);
        */

        //Interpolation (less runtime)
        Console.WriteLine($"{name} {fatherName}");

        Console.ReadKey();  // => hold the terminal untill user enters any key  
    }
}