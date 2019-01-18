    `1using System;

namespace Water_Tank_Filling
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("2 litres and \n "+ "3 litres buckets");
        Console.WriteLine("Enter the volume of the tank");
        
        int t=Convert.ToInt32(Console.ReadLine());
        if (t< 10 || t> 9999)
        {
           Console.WriteLine("You have entered an invalid entry");
           
        }
        else
        {
             int j=5;
        int k=t/j-2;
        Console.WriteLine($"Both buckets can fill the tank {k} times");
            
        }
       


        //Console.ReadKey;
        }
    }
}
