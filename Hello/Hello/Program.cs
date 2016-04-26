using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their name, save the name, and respond with Hello + name of user

            Console.WriteLine("Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);


            // Ask the user if they slept well. If it is less then 8 hours return a phrase and the same for more than 8 hours

            Console.WriteLine("Tell me, how many hours of sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested, keep this up!");
            }
            else
            {
                Console.WriteLine("You need more sleep, try to get more tonight!");
            }
            
        }
    }
}
