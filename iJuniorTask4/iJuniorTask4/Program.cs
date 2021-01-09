using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJuniorTask4Gold
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfGold;
            int amountOfCristals;
            int costOfCristal = 47;
            float youGet;
            int change;
           

            Console.Write("Сколько вам нужно кристалов? :");
            amountOfCristals = Convert.ToInt32(Console.ReadLine());
            Console.Write("Достаю из кармана:");
            amountOfGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вот все, что есть!");
            bool enoughGold, notEnoughGold;
            enoughGold = amountOfGold >= amountOfCristals * costOfCristal;
            notEnoughGold = amountOfGold <= amountOfCristals * costOfCristal;
            change = Convert.ToInt32(enoughGold) * (amountOfGold - amountOfCristals * costOfCristal); 
            youGet = amountOfGold%(amountOfCristals * costOfCristal );
            //Console.Write("Получи свои " + youGet + " остальные " + change + " оставь себе");
            Console.Write("Получи свои " + amountOfCristals* Convert.ToInt32(enoughGold) + " кристралов, остальные " + (change + amountOfGold* Convert.ToInt32(notEnoughGold)) + " золотых оставь себе");


            Console.ReadKey();

            

        }
    }
}
