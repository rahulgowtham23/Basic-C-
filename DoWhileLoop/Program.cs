using System;
namespace DoWhileLoop;

class Program{
    public static void Main(string[] args)
    {

            // string option;
            // bool choice=true;

            // do{
            //     Console.Write("Enter number:");
            //     int userInput = int.Parse(Console.ReadLine());

            //     if(userInput%2==0){
            //         Console.WriteLine($"{userInput} is even");
            //     }
            //     else{
            //         Console.WriteLine($"{userInput} is odd");
            //     }

                
            //     do
            //     {
            //         Console.WriteLine("want to repeat type 'yes' or 'no':");
            //         option=Console.ReadLine();
            //         if(option=="yes"){
            //             choice=true;
            //             break;
            //         }
            //         else if(option=="no"){
            //             choice=false;
            //             break;
            //         }
            //         else{
            //             Console.WriteLine("Enter valid input!");
            //         }
            //     } while (choice);
                
            // }while(choice);


                float celsiusDegree = float.Parse(Console.ReadLine());
                float fahrenheit = (celsiusDegree * 9/5) + 32;
                int kelvin = (int)(celsiusDegree + 273);


                Console.WriteLine(fahrenheit);
                Console.WriteLine(kelvin);
                
    }
}