using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJunior_topic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Практика - задание первое
            //string password = "qwerty";
            //string answer;

            //Console.Write("Пароль! (угрожающе смотрю):");
            //answer = Console.ReadLine();


            //if (password == answer)
            //{
            //    Console.WriteLine("Угадал, ага, молодец");

            //}
            //else
            //{ Console.WriteLine("У- Уходи!");
            //}


            // Практика - задание второе

            //double bitcoinUSD = 35000;
            //double amountOfBitcoin;
            //double usdBitcoin = 1/bitcoinUSD;
            //double amountOfUsd;
            //double answer;


            //Console.WriteLine("Что хотите купить?:" +
            //    " Доллары - нажмите 1, " +
            //    " Биткоин - нажмите 2");

            //answer = Convert.ToDouble(Console.ReadLine());

            //switch (answer)
            //{
            //    case 1:


            //        Console.WriteLine("Сколько нужно долларов?:");

            //        amountOfUsd = Convert.ToDouble(Console.ReadLine());
            //        if (amountOfUsd != 1337)
            //        {    
            //            Console.WriteLine("С вас: " + amountOfUsd * usdBitcoin + " биткоинов");
            //        }

            //        else
            //        { Console.WriteLine("Поздравляем! Вы выиграли ДЖЕКПОТ!"); }
            //        break;

            //    case 2:
            //        Console.WriteLine("Сколько нужно биткоинов?:");
            //        amountOfBitcoin = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("С вас: " + amountOfBitcoin * bitcoinUSD + " долларов");

            //        break;



            //}

            //

            string password = "qwerty";
            string answer;
           
            int i = 1;

            while (i <= 5)

            {
                Console.Write("Пароль! (угрожающе смотрю):");
                answer = Console.ReadLine();

                if (password != answer)

                {

                    Console.WriteLine("Пароль неверный");
                    i++;
                }

                else

                {
                    Console.WriteLine("Угадал с " + i + " попытки");
                    break;
                }

               
            }


            Console.ReadKey();
        }
    }
}
