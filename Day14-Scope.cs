using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
 public Difference(int[] a)
    {
        this.elements = a;
    }
    // Add your code here



   public  void computeDifference()
    {
        Array.Sort(elements);
        maximumDifference = Math.Abs(elements[0] - elements[elements.Length - 1]);
    }
	// Add your code here

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
