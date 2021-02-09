using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_skill_l3
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] bigWhite = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Method(bigWhite);
        }

        static void Method(params int[] array)
        {
            Console.WriteLine(array[1]);
        }
    }
}
