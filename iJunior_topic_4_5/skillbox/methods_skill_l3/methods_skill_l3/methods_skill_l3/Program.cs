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
            int lol = 5;
            int[] bigWhite = new int[3] {4, 1, 2} ;
            Random rand = new Random();
            for(int i=0; i<bigWhite.Length; i++)
            {
                bigWhite[i] = rand.Next(1, 100);
                Console.Write(bigWhite[i] + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < Method(lol, bigWhite).Length; i++)
            {

                Console.Write(Method(lol, bigWhite)[i]+" ");
                
            }

            Console.ReadKey();
            //Method(lol, bigWhite);
           // Console.ReadKey();
        }

        static void Method(params int[] array)
        {
            Console.WriteLine(array[1]);
        }

        static int[] Method(int lol, params int[] array)
        {
            int[] newArray = new int[3];
            for (int i = 0; i<newArray.Length; i++)
            {
                newArray[i] = lol * array[i];
            }
            return newArray;        
        }
    }
}
