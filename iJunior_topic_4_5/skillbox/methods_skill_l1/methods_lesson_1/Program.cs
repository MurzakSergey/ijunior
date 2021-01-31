using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Разделение логики: использование методов

            // Есть два массива содержащие не менее 10 и не более 20 элементов элементов. 
            // Организовать заполнение и вывод на экран каждого из них
            // Найти максимальный и минимальный элементы в каждом массиве

            Random r1020 = new Random();
            int rkind = r1020.Next(5, 15);
            int rschool = r1020.Next(5, 15);
            int[] kindergarden = new int[rkind];
            int[] school = new int[rschool];
            string yahoo = "Yahoo!";
            string horai = "Horaiii!";


            Children(kindergarden, 1, 75);

            Children(school, 1, 100);
            Applouse();
            Applouse2(yahoo, horai, 29);
            Console.ReadLine();
            
         }
        static void Children(int[] array, int min, int max)
        {
            Random r1020 = new Random();
            int maxVal = min;
            for (int i = 0; i < array.Length; i++)
            {
                int rk = r1020.Next(min, max);
                array[i] = rk;
                ConsoleColor blue = ConsoleColor.Blue;
                Console.ForegroundColor = blue;
                Console.Write(i + 1 + ".");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(array[i] + " ");
                
                if (array[i] >= maxVal)
                { maxVal = array[i]; }
             }

            Console.Write("\n"+"Max is " + maxVal +"\n\n");
        }

       static void Applouse()
        {
            Random rand = new Random();

            for (int i=0; i <rand.Next(30, 50); i++)
            {

              Console.Write(rand.Next(2)==0 ? "Yahoo!":"Horai");

            }
           
        }  //пример метода который ничечго не принимает и не возвращает
       static void Applouse2(string greetings1, string greetings2, int length)
        {
            Random rand = new Random();

            for (int i = 0; i < rand.Next(1, length); i++)
            {
                Console.Write(rand.Next(2) == 0 ? greetings1 + " ": greetings2);

            }

        }  //пример метода который принимает значения


    }
}
