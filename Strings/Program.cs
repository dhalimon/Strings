using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //https://www.c-sharpcorner.com/article/string-in-C-Sharp/

            char[] chars = { 'M', 'a', 'h', 'e', 's', 'h' };
            string name = new string(chars);
            Console.WriteLine(name);                                 //Create a string using its constructor


            string firstName = "Mahesh";                            //Create a string from a literal      
            string lastName = "Chand";
            string age = "33";
            string hello = "Hello World!";
            string numberString = "33.23";
            Console.WriteLine(hello.ToLower());
            Console.WriteLine("Hello Dhalimon");
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());
            // Console.WriteLine(hello.Trim());
            //Console.WriteLine(numberString());
            Console.WriteLine(hello.Replace("Hello", "Wassup"));
            //Console.ReadLine();
            //

            //string numberString = "33.23";
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Number: {0}", numberString);

            //Create a string using concatenation
            string nowDateTime = "Date: " + DateTime.Now.ToString("D");

            string authorDetails = firstName + " " + lastName + " is " + age + " years old.";

            Console.WriteLine(nowDateTime);
            Console.WriteLine(authorDetails);

            //Console.ReadKey();
            Console.ReadLine();
        }
    }
}
