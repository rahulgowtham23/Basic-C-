using System;
namespace TypeConversionAssignment;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();

        Console.Write("Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter mark of subject1:");
        float subject1Mark = float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject2:");
        float subject2Mark = float.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject3:");
        float subject3Mark = float.Parse(Console.ReadLine());

        float avg = (subject1Mark+subject2Mark+subject3Mark)/3;

        Console.Write("Enter Grade:");
        char grade = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter mobile number:");
        long  mobileNumber = long.Parse(Console.ReadLine());

        Console.Write("Enter Mail id:");
        string mailId = Console.ReadLine();

        Console.WriteLine("Trainee Details Are:");
        Console.Write($" Name: {name}");

        System.Console.Write($"Age: {age}");
        System.Console.WriteLine($"Mobile: {mobileNumber}");
        System.Console.WriteLine($"Marks1: {subject1Mark}");
        System.Console.WriteLine($"Marks2: {subject2Mark}");
        System.Console.WriteLine($"Marks3: {subject3Mark}");
        System.Console.WriteLine($"Total: {subject1Mark+subject2Mark+subject3Mark}");
        System.Console.WriteLine($"Average: {avg}");
        System.Console.WriteLine($"Grade: {grade}");
        System.Console.WriteLine($"Mail id: {mailId}");
    }

}
