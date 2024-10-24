using System;

namespace MyApplication
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            int ia = 5;
            int ib = 0;
            int val2 = 6;
         int val =4;
         int j, k ;
            while (i < 6)
            {
                Console.WriteLine(i);
                i++;
            }

            for (i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            while (ia > 0)
            {
                Console.WriteLine(ia);
                ia--;
            }

            for (ia = 5; ia > 0; ia--)
            {
                Console.WriteLine(ia);
            }

            for (ib = 0; ib < 100; ib++)
            {
                if (ib % 2 != 0)
                {
                    continue; // Skip the rest of the loop body for this iteration
                }
                Console.WriteLine(ib);
            }

             for (i = 1; i <= val; i++)  
         {  
            for (j = 1; j <= val-i; j++)  
            {  
               // Console.Write("");  
            }  
            for (k = 1; k <= i; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  

              for (i = 1; i <= val2; i++)  
         {  
            for (j = 1; j <= val2-i; j++)  
            {  
               // Console.Write("");  
            }  
            for (k = 1; k <= i; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  

         for (i = 1; i <= val; i++)  
         {  
            for (j = 1; j <= val-i; j++)  
            {  
               // Console.Write(" ");  
            }  
            for (k = 1; k <= j; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  

         for (i = 1; i <= val2; i++)  
         {  
            for (j = 1; j <= val2-i; j++)  
            {  
               // Console.Write(" ");  
            }  
            for (k = 1; k <= j; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  

        }

    }
}