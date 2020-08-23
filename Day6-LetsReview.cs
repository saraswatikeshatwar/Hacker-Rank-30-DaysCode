using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            int time = Convert.ToInt32(Console.ReadLine());
            while(time > 0)
            {
            string S = Console.ReadLine();
            string  name = "";
            string name1 = "";
            char[] Namechar = S.ToArray();
            for (int i = 0; i < Namechar.Length; i++)
            {
                //check index is even if then add to name string
                if(i % 2 ==0)
                {
                    name  += Namechar[i].ToString();
                }
                //check index is odd if then add to name1 string
                if(i % 2 == 1)
                {
                    name1 += Namechar[i].ToString();
                }
            }
            //print the string name , name1
            Console.Write(name + " ");
            Console.Write(name1);
            Console.WriteLine();
            time--;
            }
            Console.ReadKey();
    }
}
