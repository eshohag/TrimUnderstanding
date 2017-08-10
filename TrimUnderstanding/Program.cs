using System;

namespace TrimUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Text Here...");
            string checkText = Console.ReadLine();
            Console.WriteLine("Without Trim methods-" + checkText.Length);
            Console.WriteLine("With Trim methods-" + checkText.Trim().Length);
            Console.ReadKey();
        }
    }
}
