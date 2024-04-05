using System;
namespace WhileLoop;

class Program
{
    public static void Main(string[] args)
    {
        //Exercise 1
        /*int i=0;
        Console.WriteLine("Even numbers from 0 to 25:");
        while(i<=25){
            if(i%2==0){
                Console.Write(i+" ");
            }
            i++;
        }
        */

        //Exercise 2

        // Console.WriteLine("\nEnter the number:");


        // bool isValid = int.TryParse(Console.ReadLine(), out int result);

        // while (!isValid)
        // {
        //     Console.WriteLine("Invalid number. Enter again:");
        //     isValid = int.TryParse(Console.ReadLine(), out result);
        // }
        // Console.WriteLine(result);


    Console.WriteLine("\nEnter the number:");
    bool isValid = int.TryParse(Console.ReadLine(), out int result);
    while(true){
        {
            if(isValid){
                System.Console.WriteLine(result);
                break;
            }
            else{
                System.Console.WriteLine("Invalid num");
                isValid = int.TryParse(Console.ReadLine(), out  result);
            }
        }
    }



    }
}