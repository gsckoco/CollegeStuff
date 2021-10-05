using System;
using System.Threading;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "User Input";
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Magenta;
            String firstName = "";
            String lastName = "";
            int age = -1;
            Console.Clear();

            while (firstName.Length == 0)
            {
                Console.WriteLine("What is your first name: ");
                firstName = Console.ReadLine().Trim();
                Console.Clear();
            }

            while (lastName.Length == 0)
            {
                Console.WriteLine("What is your last name: ");
                lastName = Console.ReadLine().Trim();
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("What is your age: ");
            while (age <= 0)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine().Trim());
                } catch (FormatException)
                {
                    Console.WriteLine("Age must be a number");
                }
            }



            Console.WriteLine("Your name is " + firstName + " " + lastName + " and you are " + age + " years old");

            Console.ReadKey();

            float width = 0;
            int colour = 0;
            while (true)
            {
                width+= 0.075f;
                //Console.WindowWidth = 1 + (width % maxWidth);
                Console.WindowWidth = 10 + (int)((MathF.Sin(width) + 1) * 20);
                Console.WindowHeight = 10 + (int)((MathF.Cos(width) + 1) * 20);

                colour++;

                Console.BackgroundColor = (ConsoleColor)(colour % 16);
                Console.ForegroundColor = (ConsoleColor)(15 - (colour % 16));
                Console.Clear();

                Thread.Sleep(1);
            }


            Console.ReadKey(true);
        }
    }
}
