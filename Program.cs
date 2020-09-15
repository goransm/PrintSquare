using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace PrintSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            void drawRect(int a, int b)
            {
                Console.WriteLine();
                for (int y = 0; y < b; y++)
                {
                    string line = "  ";
                    for(int x = 0; x < a; x++)
                    {
                        line += x == 0 || y == 0 || x == a - 1 || y == b - 1 ? "#" : " ";
                    }
                    Console.WriteLine(line);
                }
                Console.WriteLine();
            }

            int askInput(string description)
            {
                Console.WriteLine(description);
                string input = Console.ReadLine();
                int returnVal = 0;
                try
                {
                    returnVal = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine($"Nice try, but {input} is not suitable as a dimension.");
                    return askInput("Please try again! And type a number this time.");
                }
                return returnVal < 1 ? askInput("Seriously? You're trying to break me? Give me a proper input!") : returnVal;
            }

            Console.WriteLine("Welcome to the wonderful PrintSquare app!");
            Console.WriteLine("Type an integer to draw a square, or something else to opt for a rectangle:");

            string arg1 = Console.ReadLine();

            try
            {
                int x = int.Parse(arg1);
                drawRect(x, x);
            }
            catch
            {
                Console.WriteLine("Nice! You want more control!");
              
                drawRect(askInput("Type the width of the rectangle:"), askInput("And the height:"));
            }


        }
    }
}
