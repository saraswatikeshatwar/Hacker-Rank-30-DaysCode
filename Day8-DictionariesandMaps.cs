using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            //creating abc name dictionary
            var abc = new Dictionary<string, string>();
          
             for(int i = 0; i < n; i++)
             {
               string[] inputs = Console.ReadLine().Split();
            
               abc[inputs[0]] = inputs[1];
             } 
           

                string name1; //= Console.ReadLine();
                
                while ((name1 = Console.ReadLine()) != null)
                {
                  // check if abc contain the name1
                    if (abc.ContainsKey(name1) )                    
                    {
                        Console.WriteLine(name1 + "=" + abc[name1]);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }

                }
                
            
    }
}
