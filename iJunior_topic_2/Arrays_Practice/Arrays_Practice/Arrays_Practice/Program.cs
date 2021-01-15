using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Поиск максимального числа в массве

            //int[] array = {-1, -45, -45, -23, -7, -1, -1212, 0};
            //int highter = array[0];

            //for (int i=0; i < array.Length; i++)

            //{
            //    if (highter <= array[i])
            //    {
            //        highter = array[i];
            //    }

            //}

            //Console.WriteLine(highter);

            //Console.ReadKey();




            int[] freePlaces = { 2, 6, 0, 0, 1 };
            int tableToBook;
            int placesToBook;
            bool isDoorOpen=true;


            while (isDoorOpen)
            {
                Console.WriteLine(" \n To show table list - press 1\n To book a place - press 2\n To exit - press 3\n");


                switch (Convert.ToInt32(Console.ReadLine()))
                
                {
                    case 1:
                        Console.Clear();
                        for (int i = 0; i < freePlaces.Length; i++)
                        {
                            Console.WriteLine("At the table nomber " + (i + 1) + " are " + freePlaces[i] + " free sits");
                        }


                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("At what table do you whan to book a place:");
                        tableToBook = Convert.ToInt32 (Console.ReadLine());
                        Console.WriteLine("How many?: ");
                        placesToBook = Convert.ToInt32(Console.ReadLine());
                        freePlaces[tableToBook-1] -= placesToBook;
                        if (freePlaces[tableToBook - 1] >= 0)
                        {
                            for (int book = 0; book < freePlaces.Length; book++)
                            {
                                Console.WriteLine("At the table nomber " + (book + 1) + " are " + freePlaces[book] + " free sits");
                            }
                        }

                        else
                        {
                            Console.WriteLine("At this table only " + (freePlaces[tableToBook - 1] + placesToBook) + " free sits");
                        }

                        break;

                case 3:
                        isDoorOpen = false;     
                    break;

                }

                
                
                




            }

            

        }
    }
}
