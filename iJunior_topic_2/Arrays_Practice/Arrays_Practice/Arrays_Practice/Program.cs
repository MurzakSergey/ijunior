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
                Console.SetCursorPosition(5, 0);
                Console.WriteLine("Welcome to sharPab! \n");
                Console.SetCursorPosition(0, 15);
                for (int i = 0; i < freePlaces.Length; i++)
                {
                    
                    Console.WriteLine("At the table nomber " + (i + 1) + " are " + freePlaces[i] + " free sits");
                }

                Console.SetCursorPosition(0, 3);
                Console.WriteLine(" \n To book a place - press 1\n To exit - press 2\n");


                switch (Convert.ToInt32(Console.ReadLine()))
                
                {
                    case 1:

                        Console.WriteLine("At what table do you whan to book a place:");
                        tableToBook = Convert.ToInt32 (Console.ReadLine());
                        if (tableToBook > freePlaces.Length || tableToBook <= 0)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine("There is no that table");
                        }

                        else
                        {
                            Console.WriteLine("How many?: ");
                            placesToBook = Convert.ToInt32(Console.ReadLine());
                            freePlaces[tableToBook - 1] -= placesToBook;
                            
                            Console.Clear();

                            if (freePlaces[tableToBook - 1] < 0)
                            {
                                Console.SetCursorPosition(0, 2);
                                Console.WriteLine(" At this table are " + (freePlaces[tableToBook - 1] + placesToBook) + " free sits, and you need " + placesToBook+"\n\n" );
                                freePlaces[tableToBook - 1] += placesToBook;
                            }

                            else if (placesToBook <= 0)
                            {
                                Console.SetCursorPosition(0, 2);
                                Console.WriteLine("Wrong number of places!");
                                freePlaces[tableToBook - 1] += placesToBook;
                                
                            }

                            else

                            {
                                Console.SetCursorPosition(0, 2);
                                Console.WriteLine("Succsecely booked!");
                            }


                            

                        }

                        break;

                case 2:
                        isDoorOpen = false;     
                    break;

                }

                

                
                
                




            }

            

        }
    }
}
