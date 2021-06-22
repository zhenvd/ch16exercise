using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
       
        static double Divide(double x, double y)
        {
            // Write your code here!
            return x / y;
        }
        
        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName.Contains(".cs"))
            {
                return 1;
            }
            else
            {
                throw new ArgumentNullException("Student submitted nothing");
            }
        }
        

        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Please enter the first value:");
                double x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second value:");
                double y = Double.Parse(Console.ReadLine());
                if (y == 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine($"{x}/{y} = {Divide(x, y)}");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            
            // Test out your Divide() function here!

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            try
            {
                foreach(KeyValuePair<string,string> student in students)
                {
                    if(CheckFileExtension(student.Value) == 1)
                    {
                        Console.WriteLine($"{student.Key} received {CheckFileExtension(student.Value)} point for {student.Value}");
                    }
                    else
                    {
                        Console.WriteLine($"{student.Key} received {CheckFileExtension(student.Value)} point for {student.Value}");
                    }

                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);   
            }


        }
    }
}
