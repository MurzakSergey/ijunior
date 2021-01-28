using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 3;
            int t = 5;
            int rPlusT;
            ConsoleColor color = ConsoleColor.Blue;
            Console.ForegroundColor = color;
            Console.WriteLine("What are you waiting for?");
            rPlusT = Sum(r, t, color = ConsoleColor.Yellow) +r*t;


            Console.WriteLine(rPlusT);
            Console.WriteLine(Sum(r,t));
            Console.ReadLine();
        }

        static int Sum(int x, int y, ConsoleColor font = ConsoleColor.Red)
            {

            //return x + y;
            // or 

            Console.ForegroundColor = font;
            int sum;
            sum = x + y;
            int mus = x - y;
            return sum;
           // return mus; второй возврат уже не получился, т.к., можно сделать только один

            

            
            
            }

    }
}
