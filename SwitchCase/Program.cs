using System;
namespace SwitchCase;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Input 1:");
        int input1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Input 2:");
        int input2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("which operation needed to perfrom: \n+ \n- \n* \n/ \n%");
        string userOption = Console.ReadLine();

        switch(userOption){
            case "+":
                System.Console.WriteLine(input1+input2);
            break;
            case "-":
                System.Console.WriteLine(input1-input2);
            break;
            case "*":
                System.Console.WriteLine(input1*input2);
            break;
            case "/":
                System.Console.WriteLine(input1/input2);
            break;
            case "%":
                System.Console.WriteLine(input1%input2);
            break;
            default:
                System.Console.WriteLine("Invalid operation");
            break;

        }
        
    }
}