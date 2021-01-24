using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the mathapp!!!");
            Console.WriteLine("What do you want to calculate area or perimeter?");
            string userInput = Console.ReadLine();
            Console.WriteLine("userInput = " + userInput );

            if (userInput == "perimeter")
            {
                Console.WriteLine("What is the length?");
                string strLength = Console.ReadLine();

                Console.WriteLine("What is the width?");
                string strwidth = Console.ReadLine();

                int length = Int32.Parse(strLength);

                int width = Int32.Parse(strwidth);
                int perimeter = length + width + length + width;
                Console.WriteLine("The answer = perimeter " + perimeter);

            }
            else
            {
                Console.WriteLine("What is the length?");
                string strLength = Console.ReadLine();

                Console.WriteLine("What is the width?");
                string strwidth = Console.ReadLine();

                int length = Int32.Parse(strLength);

                int width = Int32.Parse(strwidth);
                int area = length * width;
                Console.WriteLine("The answer = area " + area);
            }
        }
    }
}
