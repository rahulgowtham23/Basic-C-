using System;
namespace ForLoop;

class Program
{
    public static void Main(string[] args)

    {   Console.Write("Enter lower limit:");
        int lower_limit=int.Parse(Console.ReadLine());


        Console.Write("Enter upper limit:");
        int upper_limit=int.Parse(Console.ReadLine());

        int sum=0;

        for(int i=lower_limit; i<=upper_limit; i++){
             sum += i*i;
        }
        
        Console.WriteLine(sum);
    }
}