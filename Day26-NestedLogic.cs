using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] expected;
            string[] actual;
            expected = Console.ReadLine().Split(' ');
            actual = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(expected, Int32.Parse);
            int[] e = Array.ConvertAll(actual, Int32.Parse);
            int fine = 0;
            int actualDay = a[0];
            int actualMonth = a[1];
            int actualYear = a[2];
            int expectedDay = e[0];
            int expectedMonth = e[1];
            int expectedYear = e[2];
            if (actualYear > expectedYear)
            {
                fine = 10000;
            }
            else if (actualMonth > expectedMonth && (actualYear >= expectedYear))
            {
                fine = 500 * (actualMonth - expectedMonth);
            }
            else if (actualDay > expectedDay && (actualMonth >= expectedMonth) && (actualYear >= expectedYear))
            {
                fine = 15 * (actualDay - expectedDay);
            }
            else
            {
                fine = 0;
            }
            Console.WriteLine(fine);
    }
}
