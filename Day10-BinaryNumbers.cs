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

 private static int maxConsecutiveOnes(int x) 
    { 
          
        // Initialize result 
        int count = 0; 
  
        // Count the number of iterations 
        // to reach x = 0. 
        while (x != 0) 
        { 
              
            // This operation reduces length 
            // of every sequence of 1s by one. 
            x = (x & (x << 1)); 
  
            count++; 
        } 
  
        return count; 
    } 

    static void Main(string[] args) 
    {
      
     Console.WriteLine(maxConsecutiveOnes(Convert.ToInt32(Console.ReadLine())));
    }
}
