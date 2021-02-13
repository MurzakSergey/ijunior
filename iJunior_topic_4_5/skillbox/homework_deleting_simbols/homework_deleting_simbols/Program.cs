using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_deleting_simbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string cat;
            Console.WriteLine("Tipe a text: ");
            cat = Console.ReadLine();
            cutToNormal(cat);
            Console.ReadKey();
        }

        static void cutToNormal(string yourText)
        {
            Console.WriteLine("\nAfter cutting duplicated simbols: ");
            Console.Write(yourText[0]);
            for (int i = 0; i < yourText.Length - 1; i++)
            {
                if (yourText[i] != yourText[i + 1])
                {
                    Console.Write(yourText[i + 1]);
                }
             }
            
        }

    }
}
