 using System;
namespace DateAndTime;

class Program{
    public static void Main(string[] args)
    
    {                                
                            //year month day  hr  min sec 
        
        DateTime date =  new(2021,  8,   10,  10, 40, 32, 001);
        
        Console.WriteLine(date);

        Console.WriteLine($"year:{date.Year} month:{date.Month} day:{date.Day}    hour:{date.Hour} minute:{date.Minute} second:{date.Second} millisecond:{date.Millisecond}" );






        //2.DateTime to String  dd//MM/yyyy  hh:mm:ss tt

        Console.WriteLine("Enter date in format: yyyy/MM/dd hh:mm:ss tt");

        DateTime date2 = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);

        //Console.WriteLine(date2);


        string[] splitedArr = date2.ToString("yyyy/MM/dd hh:mm:ss tt").Split(new char[] {' ',':','/'});

        // foreach (string i in strArr)
        // {
        //     Console.WriteLine(i);
        // }

        //2021/08/10 10:40:32 AM

        Console.WriteLine("date and time in revrse order:");
        for(int i=splitedArr.Length-1; i>=0;i--){
            Console.Write(splitedArr[i] + " ");
        }







        //3.user input  in format(yyyy/MM/dd  hh:mm:ss tt) print year month day

        Console.WriteLine("\nEnter date in the format : yyyy/MM/dd hh:mm:ss tt");
        DateTime date3 = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt"  ,null);

        Console.WriteLine(date3);
        Console.WriteLine($"{date3.Year}, {date3.Month}, and {date3.Day}");
        

    }
}