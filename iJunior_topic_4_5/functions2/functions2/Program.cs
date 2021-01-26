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
            rPlusT = Sum(r, t)+r*t;


            Console.WriteLine(rPlusT);
            Console.WriteLine(Sum(r,t));
            Console.ReadLine();
        }

        static int Sum(int x, int y)
            {

            //return x + y;
            // or 

            int sum;
            sum = x + y;
            return sum;
            

            
            
            }

    }
}
