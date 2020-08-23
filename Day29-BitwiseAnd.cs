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
        var T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            var input = Console.ReadLine().Split(' ');
            var N = int.Parse(input[0]);
            var K = int.Parse(input[1]);

            int max = 0;

            for (int j = 1; j < N; j++)
            {
                for (int k = j + 1; k <= N; k++)
                {
                    int h = j & k;
                    if (h < K && max < h) max = h;
                }
            }

            Console.WriteLine(max);
        }
    }
}

