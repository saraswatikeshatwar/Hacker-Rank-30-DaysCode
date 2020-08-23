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
static int R = 6;
        static int C = 6; 

        static int findMaxSum(int[][] arr)
        {
            if (R < 3 || C < 3)
                return -1;

            // Here loop runs (R-2)*(C-2)  
            // times considering different 
            // top left cells of hour glasses. 
            int max_sum = int.MinValue;
            for (int i = 0; i < R - 2; i++)
            {
                for (int j = 0; j < C - 2; j++)
                {
                    // Considering mat[i][j] as top  
                    // left cell of hour glass. 
                    int sum = (arr[i][j] + arr[i][j + 1] +
                               arr[i][j + 2]) + (arr[i + 1][j + 1]) +
                              (arr[i + 2][j] + arr[i + 2][j + 1] +
                               arr[i + 2][j + 2]);

                    // If previous sum is less then  
                    // current sum then update 
                    // new sum in max_sum 
                    max_sum = Math.Max(max_sum, sum);
                }
            }
            return max_sum;
        }


    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        int res = findMaxSum(arr);
            if (res == -1)
                Console.WriteLine("Not possible");
            else
                Console.WriteLine(res);
    }
}
