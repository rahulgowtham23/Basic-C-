using System;

namespace ValueAndReferenceType;

class Program 
{
    public static void Main(string[] args)
    {
        int number1 = 10;
        
        System.Console.WriteLine(number1);

        
        int number2 = number1;

        System.Console.WriteLine(number2);

        number1=20;
        System.Console.WriteLine(number2);


        Student student1 = new Student();

        student1.Name = "rahul";

        System.Console.WriteLine(student1.Name); 

        Student student2=student1;

        System.Console.WriteLine(student2.Name);

        student1.Name = "gowtham";

        System.Console.WriteLine(student1.Name);
        System.Console.WriteLine(student2.Name);



    }
}