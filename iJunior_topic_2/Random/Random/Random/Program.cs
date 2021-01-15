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
            //int larger, lower, number, answer;
            //int attempts = 2;
            //lower = 1;
            //larger = 100;
            //Random rand = new Random();
            //number = rand.Next(lower, larger);
            //Console.WriteLine("Угадайте число от " + lower + " до " + (larger - 1) + " с " + attempts + " попыток: ");
            //for (int i=1; i<=attempts; i++)
            //{                            
            //    answer = Convert.ToInt32(Console.ReadLine());

            //    if (i == attempts && answer != number)
            //    {
            //        Console.WriteLine("Может повезет в следующий раз! Это было число " + number + "!");
            //        break;    
            //    }


            //    if (answer == number)
            //    {
            //        Console.WriteLine("Вау! Угадал! Это и правда " + number);

            //    }

            //    else
            //    {
            //        Console.WriteLine("У тебя " + (attempts - i) + " попыток" + "                       подсказка, только тихо! это" + number);

            //    }



            //    }

            Random rand = new Random();
            double heroHP = rand.Next(90,100);
            double enemyHP = rand.Next(60,75);
            
            
            double heroArmor = rand.Next(20, 50);
            double enemyArmor = rand.Next(10, 25);

            while (heroHP >= 0 && enemyHP >=0)
            {
                

                double heroDamage = rand.Next(25, 100);
                double enemyDamge = rand.Next(100, 290);

                Console.WriteLine("Hero HP = " + heroHP + " Enemy HP = " + enemyHP);
                Console.WriteLine("Hero hits " + heroDamage + " Enemy hits " + enemyDamge);
                heroHP -= enemyDamge / heroArmor;
                enemyHP -= heroDamage /enemyArmor;


                if (heroHP <= 0 && enemyHP <=0)
                {
                    Console.WriteLine("Draw!");
                }

                else if (enemyHP <= 0)
                
                {
                    Console.WriteLine("Hero wins!");
                }

                else if (heroHP <= 0)
                {
                    Console.WriteLine("Enemy wins!");
                }

                

            }


            Console.ReadKey();
            
            




            

            Console.ReadKey();

        }
    }
}
