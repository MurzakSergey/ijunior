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

            //Задание 4, с использованием for

            // string password = "qwerty";
            // string answer;


            //int attempts;

            //for (attempts = 1; attempts <= 5; attempts++)

            // {
            //     Console.Write("Пароль! (угрожающе смотрю):");
            //     answer = Console.ReadLine();

            //     if (password != answer)

            //     {

            //         Console.WriteLine("Пароль неверный, у вас осталось " + (5-attempts) + " попыток");

            //     }

            //     else

            //     {
            //         Console.WriteLine("Угадал с " + attempts + " попытки");
            //         break;
            //     }



            // }

            //Задание 4, с использованием while (но лучше использовать for  т.к., мы знаем количество итераций

            //string password = "qwerty";
            //string answer;


            //int attempts=1;

            //while (attempts <= 5)

            //{
            //    Console.Write("Пароль! (угрожающе смотрю):");
            //    answer = Console.ReadLine();

            //    if (password != answer)

            //    {

            //        Console.WriteLine("Пароль неверный, у вас осталось " + (5 - attempts) + " попыток");

            //                         attempts++;
            //    }

            //    else

            //    {
            //        Console.WriteLine("Угадал с " + attempts + " попытки");
            //        break;
            //    }


            //}


            // Задание 5

            double amountOfMoney;
            int years;
            int waitingYears;
            double percent = 5.5;
            

            Console.Write("Сколько хотите положить на счет?: ");
            amountOfMoney = Convert.ToDouble(Console.ReadLine());
            Console.Write("На какой срок?: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("С учетом процентной ставки " + percent + " вот ваш доход по годам: ");

            // с использованием while (но лучше использовать for  т.к., мы знаем количество итераций

            //while ( years >= 0)
            //{

            //    Console.WriteLine("Ваш доход за " + waitingYears + " год "+ " составит " + amountOfMoney);
            //    amountOfMoney += amountOfMoney*(percent/100);

            //    years--;
            //    waitingYears++;

            // }

            for (waitingYears = 0; waitingYears <= years; waitingYears++)

            {
                Console.WriteLine("Ваш доход за " + waitingYears + " год " + " составит " + amountOfMoney);
                amountOfMoney += amountOfMoney*(percent/100);

                


            }










            Console.ReadKey();
        }
    }
}
