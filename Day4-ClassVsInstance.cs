using System;
using System.Collections.Generic;
using System.IO;

class Person {
    public int age;     
	public Person(int initialAge)
     {
        // Add some more code to run some checks on initialAge
        //check initial age greater than 0 if then give val to age otherwise consider age is 0 and print age is not valid
        if (initialAge > 0)
         {
                age = initialAge;
         }
         else
        {
            age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console 
        //check age less than 13 then young
         if(age < 13)
         {
             Console.WriteLine("You are young.");
         }
         //check age less than 18 then teenager
         else if( age < 18)
         {
             Console.WriteLine("You are a teenager.");
         }
         //otherwise old
         else
         {
             Console.WriteLine("You are old.");
         }
     }

     public void yearPasses() {
        // Increment the age of the person in here
        age = age + 1;
     }

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person p=new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}
