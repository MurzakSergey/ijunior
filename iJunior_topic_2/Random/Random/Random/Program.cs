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
            int attempts = 2;
            lower = 1;
            larger = 100;
            Random rand = new Random();
            number = rand.Next(lower, larger);
            Console.WriteLine("Угадайте число от " + lower + " до " + (larger - 1) + " с " + attempts + " попыток: ");
            for (int i=1; i<=attempts; i++)
            {                            
                answer = Convert.ToInt32(Console.ReadLine());

                if (i == attempts && answer != number)
                {
                    Console.WriteLine("Может повезет в следующий раз! Это было число " + number + "!");
                    break;    
                }


                if (answer == number)
                {
                    Console.WriteLine("Вау! Угадал! Это и правда " + number);

                }

                else
                {
                    Console.WriteLine("У тебя " + (attempts - i) + " попыток" + "                       подсказка, только тихо! это" + number);
                                    
                }

                

                }

            

            Console.ReadKey();

        }
    }
}
