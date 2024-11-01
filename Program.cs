using System;

namespace MyApplication
{
   public static class Program
   {
      public static void Main(string[] args)
      {
         Write1ThroughNWhile();
         Write1ThroughN_For();
         WriteNThrough1_While();
         WriteNThrough1_For();
         WriteEvensThrough100();
         OutputRightTriangle();
         OutputRightTriangle2();
         OutputRightTriangle3();
         OutputRightTriangle4();
      }
      public static void Write1ThroughNWhile()
      {
         int i = 1; while (i < 6)
         {

            Console.WriteLine(i);
            i++;
         }
      }
      public static void Write1ThroughN_For() { 
      int i = 1;
         for ( i = 1; i< 5; i++)
         {
            Console.WriteLine(i);
         }
      }
 public static void WriteNThrough1_While(){
   int ia = 5;
         while (ia > 0)
         {
            Console.WriteLine(ia);
            ia--;
         }
 }
 public static void WriteNThrough1_For(){
   int ia =5;
for (ia = 5; ia > 0; ia--)
{
   Console.WriteLine(ia);
}
 }
 public static void WriteEvensThrough100(){
   int ib = 0;
for (ib = 0; ib < 100; ib++)
{
   if (ib % 2 != 0)
   {
      continue; // Skip the rest of the loop body for this iteration
   }
   Console.WriteLine(ib);
}
 }
public static void OutputRightTriangle() {
   int i = 1; int j, k; int val= 4;
for (i = 1; i <= val; i++)
{
   for (j = 1; j <= val - i; j++)
   {
      // Console.Write("");  
   }
   for (k = 1; k <= i; k++)
   {
      Console.Write("*");
   }
   Console.WriteLine("");
}
}
public static void OutputRightTriangle2() {
   int i = 1; int val2 = 6; int j, k;
for (i = 1; i <= val2; i++)
{
   for (j = 1; j <= val2 - i; j++)
   {
      // Console.Write("");  
   }
   for (k = 1; k <= i; k++)
   {
      Console.Write("*");
   }
   Console.WriteLine("");
}
}
public static void OutputRightTriangle3() {
   int i = 1; int val = 4; int j, k;
for (i = 1; i <= val; i++)
{
   for (j = 1; j <= val - i; j++)
   {

   }
   for (k = 1; k <= j; k++)
   {
      Console.Write("*");
   }
   Console.WriteLine("");
}
}
public static void OutputRightTriangle4() {
int i = 1; int val2 = 6; int j, k;
for (i = 1; i <= val2; i++)
{
   for (j = 1; j <= val2 - i; j++)
   {

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
