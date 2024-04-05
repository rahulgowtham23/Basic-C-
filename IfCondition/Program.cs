using System;
namespace IfCondition;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your Mark:");
        int mark = int.Parse(Console.ReadLine());

        /*if(mark>=80){
            System.Console.WriteLine("Grade A");
        }
        else if(mark>=61 && mark<80){
            System.Console.WriteLine("Grade B");
        }
        else if(mark>=36 && mark<60){
            System.Console.WriteLine("Grade C");
        }
        else if(mark<36){
            System.Console.WriteLine("Grade D");
        }
        else{
            System.Console.WriteLine("Invalid Input");
        }
        */

        if(mark>=0 && mark<=100 ){
            if(mark>=80){
            System.Console.WriteLine("Grade A");
            }
            else if(mark>=61 && mark<80){
                System.Console.WriteLine("Grade B");
            }
            else if(mark>=36 && mark<60){
                System.Console.WriteLine("Grade C");
            }
            else if(mark<36){
            System.Console.WriteLine("Grade D");
            }
        }
        else{
            System.Console.WriteLine("Invalid Input");
        }
    }
}