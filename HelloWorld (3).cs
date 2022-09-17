using System;
namespace arrays
{
   class Program
    {       
        static void Main(string[] args)
        {               
           int[] item = test1(new[] { 10, 20, -30, -40, 50 });            
           Console.Write("New array: ");         
           foreach(var i in item)
            {
               Console.Write(i.ToString()+" ");
            }     
          }               
       static int[] test1(int[] numbers)
         {
          int size = numbers.Length;
            int[] shiftNums = new int[size];

            for (int i = 0; i < size; i++)
            {
                shiftNums[i] = numbers[(i + 1) % size];
            }
            return shiftNums;
         }    
   } 
}

