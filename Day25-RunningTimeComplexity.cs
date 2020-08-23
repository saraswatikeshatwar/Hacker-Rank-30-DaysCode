using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
          //Console.WriteLine("enter size");
            int T = int.Parse(Console.ReadLine());
          
           //Console.WriteLine("enter values");
            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 2 && Isprime(n)) Console.WriteLine("Prime");//check its prime or not
                else Console.WriteLine("Not prime");
            }
           
           // Console.ReadKey();
    }
     private static Boolean Isprime(int n)
        {
             if (n < 2)
             {
                   return false;
             }

              for (int i = 2; i * i <= n; i++) 
              {
                  if (n % i == 0) 
                  {
                         return false;
                  }
              }
            return true;
        }
        
}
