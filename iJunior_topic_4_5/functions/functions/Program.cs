using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dummy = true;
            while (dummy)
            {
                String ask = Console.ReadLine();
                writeError("You are dummy");
                if (ask == "exit")
                {
                    dummy = false;
                }


            }
        }

        static void writeError(string text)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;
         }


    }
}
