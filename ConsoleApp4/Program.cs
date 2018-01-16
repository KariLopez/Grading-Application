using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Please enter a number from 0 to 100");
                int letterGrade = int.Parse(Console.ReadLine());
                if (letterGrade <= 60)
                {
                    Console.WriteLine("Letter Grade: F");
                }
                else if (letterGrade <= 66)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (letterGrade <= 79)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (letterGrade <= 87)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else
                {
                    Console.WriteLine("Letter Grade: A");
                }
                repeat = DoAgain();
            }

        }
        public static bool DoAgain()
        {
            bool goAgain;
            Console.WriteLine("Continue? Y/N");
            string input = Console.ReadLine();
            input=input.ToLower();
            if (input == "n")
            {
                goAgain = false;
            }
            if (input == "y")
            {
                goAgain = true;
            }
            else
            {
                Console.WriteLine("I'm sorry I do not recognize that entry, Please try again");
                goAgain = DoAgain();
            }
            return goAgain;

        }
    }
}
