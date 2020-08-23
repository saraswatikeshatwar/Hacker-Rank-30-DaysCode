using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {



    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        //check n is even or else odd
        if(N % 2 == 0)
        {
            //if even then check n is number between 2 and 5
            if(N >=2 && N <=5)
            {
                Console.WriteLine("Not Weird");
            }
            //if even then check n is number between 6 and 20
            else  if(N >=6 && N <=20)
            {
                Console.WriteLine("Weird");
            }
            // number is greater than 20
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
        //if odd then print weird
        else
        {
            Console.WriteLine("Weird");
        }
    }
}
