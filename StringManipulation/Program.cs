using System;
using System.Threading;
namespace StringManipulation;

class Program
{
            // static float Power(float a,float b){
            //     if(b==0 || b<0){
            //         return 1;
            //     }
            //     else{
            //         return a * Power(a,b-1);
            //     }
            // }
            public static void Main(string[] args)
            {
                
                // int w = int.Parse(Console.ReadLine());
                // int h = int.Parse(Console.ReadLine());
                // for(int i=0;i<h;i++){
                //     for(int j=0;j<w;j++){
                //         if(i==0 || i==h-1 || j==0 || j==w-1){
                //             Console.Write("*");
                //         }
                //         else{
                //             Console.Write(" ");
                //         }
                //     }
                //     Console.WriteLine();
                // }
                // int m = int.Parse(Console.ReadLine());
                // int n = int.Parse(Console.ReadLine());
                
                // int[,] matrix1 = new int[m,n];

                // for(int i=0;i<matrix1.Length;i++){
                //     for(int j=0;j<matrix1.Length;i++){
                //         matrix1[i,j]=int.Parse(Console.ReadLine());
                //     }
                // }

                //  for(int i=0;i<matrix1.Length;i++){
                //     for(int j=0;j<matrix1.Length;j++){
                //         Console.Write(matrix1[i,j]);
                //     }
                //     Console.WriteLine();
                // }



                // int[,] matrix2 = new int[n,m];

                // for(int i =0;i<value;i++){
                //     for(int j=0;j<value;j++){
                //         matrix2[i,j]=int.Parse(Console.ReadLine());
                //     }
                // }

                /*int[,] matrix3 = new int[m,m];

                for(int i =0;i<m;i++){
                    for(int j=0;j<m;i++){
                        matrix3[i,j] = matrix1[i,j]*matrix2[i,  j];
                    }
                }*/
                

                // string str1 = Console.ReadLine();
                
                // char[] charr = str1.ToCharArray();

                // for(int i=0;i<charr.Length;i++){
                //     for(int j=i+1;j<charr.Length;j++){
                //         if(charr[i]==charr[j]){
                //             charr[j] = '#';
                //         }
                //     }
                // }

                // for(int i =0;i<charr.Length;i++){
                //     if(charr[i]!='#'){
                //         Console.Write(charr[i]);
                //     }
                // }


            // string str1 = Console.ReadLine();
            // string str2 = Console.ReadLine();
            // char[] charr1 = str1.ToCharArray();
            // char[] charr2 = str2.ToCharArray();
            // int count=0;

            // if(str1.Length==str2.Length){
                

            //     for(int i = 0;i<charr1.Length;i++){
            //         for(int j=0;j<charr2.Length;j++){
            //             if(charr1[i]==charr2[j]){
                        
            //                count++; 
            //                break;
            //             }
            //         }
            //     }
            //     if(count==str1.Length){
            //         System.Console.WriteLine("anagram");
            //     }
            //     else{
            //         System.Console.WriteLine("not");
            //     }
            // }
            // else{
            //     System.Console.WriteLine("not");
            // }


        
        //simple assignment1 1

        /*string str = Console.ReadLine();

        int n=str.Length;
        int c=0;
        for(int i =0;i<n;i++){
            if(str[i]!=' '){
                c++;
                System.Console.Write(str[i]);
            }
        }
        System.Console.WriteLine(c);
        */

        // simple assignment1 6
        /*string str = Console.ReadLine();

        DateTime date;

        bool temp = DateTime.TryParseExact(str,"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date);

        if(temp){
            System.Console.WriteLine("yes");
        }
        else{
            System.Console.WriteLine("no");
        }
        */


        //asssignment 1 9
        /*int n = int.Parse(Console.ReadLine());

        string[] numbers = Console.ReadLine().Split(',');
        int sum=0;
        for(int i=0;i<numbers.Length;i++){
            sum = sum + int.Parse(numbers[i]);
        }
        if(sum%2==0){
            System.Console.WriteLine("even");
        }
        else{
            System.Console.WriteLine("odd");
        }*/


        string str = Console.ReadLine();

        for(int i=0;i<str.Length;i++){
            if(str[i]=='a'|| str[i]=='e'|| str[i]=='i' || str[i]=='o' || str[i]=='u'){
                System.Console.Write(str[i]);
            }
        }
        
                
    }
}
