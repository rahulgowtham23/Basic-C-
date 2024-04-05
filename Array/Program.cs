using System;
using System.Collections;
using System.Net.WebSockets;
using System.Threading;
namespace Array;

class Program{
    public static void Main(string[] args)
    {
        string[] arr = new string[6] {"Mani","Ganesh","Venkat","Suresh","Venkat","rahul"};



        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i]+" ");
        }

        
        Console.WriteLine("\nEnter name to search:");
        string name = Console.ReadLine();

        bool flag=true;

        for(int i=0;i<arr.Length;i++){
            if(name==arr[i]){
                flag=false;
                System.Console.WriteLine($"The name is present and index is {i+1}");
            }
        }
        if(flag){
            System.Console.WriteLine("The name is not present");
        }


    
    // int count= 0;

    // for(int i=0;i<arr.Length;i++){
    //     if(name==arr[i]){
    //         Console.WriteLine($"The name is present in the array and index is {i}");
    //         break;
    //     }
    //     else{
    //         count=count+1;
    //     }
    // }

    // if(count==arr.Length){
    //     Console.WriteLine("The name is not present in the array");
    // }
        

    // int count2= 0;

    // foreach (string i in arr)
    // {
    //     if(i==name){
    //         Console.WriteLine($"The name is present in array");
    //         break;
    //     }
    //     else
    //         count2=count2+1;
    // }

    // if(count2==arr.Length){
    //     Console.WriteLine("The name is not present in the array");
    // }

    }

    }

    
