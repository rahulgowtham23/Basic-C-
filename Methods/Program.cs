using System;
namespace Methods;

class Program{
    public static void Main(string[] args)
    {

        static int Add(int number1,int number2){
            return number1 + number2;
        }

        static int Sub(int number1,int number2){
            return number1 - number2;
        }

        static int Mul(int number1,int number2){
            return number1 * number2;
        }

        static int Div(int number1,int number2){
            return number1 / number2;
        }

        bool  flag = true;
        do
        {
            Console.Write("Enter number1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number2:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("choose an operation: \n 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division");
            Console.WriteLine("Enter the above option: ");
            int userOption = int.Parse(Console.ReadLine());
            Console.WriteLine($"user entered option: {userOption}");
            float res;

            switch (userOption)
            {
                case 1:
                    res = Add(number1,number2);
                    Console.WriteLine(res);
                    break;
                case 2:
                    res = Sub(number1,number2);
                    Console.WriteLine(res);
                    break;
                case 3:
                    res = Mul(number1,number2);
                    Console.WriteLine(res);
                    break;
                case 4:
                    res = Div(number1,number2);
                    Console.WriteLine(res);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        
            Console.WriteLine("whether you want to continue type 'yes' to continue / 'no' to exit ");
            string calculateAgain = Console.ReadLine();

            if(calculateAgain != "yes" ){
                flag = false;
            }

        } while (flag);
        

        
        
    }
    
}