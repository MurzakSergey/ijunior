using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int larger, lower, number, answer;
            int attempts = 10;
            lower = 1;
            larger = 6;
            Random rand = new Random();
            

            for (int i=0; i<attempts; i++)
               

            {
                number = rand.Next(lower, larger);
                Console.WriteLine("Угадайте число от " + lower + " до " + (larger-1) + " : ");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer == number)
                {
                    Console.WriteLine("Вау! Угадал! Это и правда " + number);

                }

                else
                {
                    Console.WriteLine("Давай еще раз! У тебя " + (attempts - i-1) + " попыток" + number);
                                    
                }

              
            }

            Console.ReadKey();

        }
    }
}
