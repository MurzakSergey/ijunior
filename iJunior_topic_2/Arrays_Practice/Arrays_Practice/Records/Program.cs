using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] records = {{"Дельфин", "Мумий Тролль", "ЛЮК", "Слезы", "Психея"}, {"Deftones", "BMTH", "KORN" , "Led Zeppelin", "Gojira"},
            { "Trentemeller", "Phantogramm", "St.Vinsent", "Depesh Mode", "KORN"} };
            // 2 раза KORN для проверки
            
            bool recordCase = true;
            int menuPosY = 1;

            while (recordCase)
            {

                Console.SetCursorPosition(5, 0);
                Console.WriteLine("Murlo's collection");
                Console.SetCursorPosition(0, menuPosY);
                Console.WriteLine("1 - Show index from record\n" +
                "2 - Show record from position\n" +
                "3 - Show record list\n" +
                "4 - Exit");
                

                

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(5, 0);
                        Console.WriteLine("Murlo's collection");
                        Console.SetCursorPosition(0, 2);
                        string recordName;
                        Console.WriteLine("Type a record:");
                        recordName = Console.ReadLine();
                        bool recordWasFond = false; 
                        for (int i = 0; i < records.GetLength(0); i++)
                        {
                            for (int j = 0; j < records.GetLength(1); j++)
                            {
                                if (recordName.ToLower() == records[i, j].ToLower())
                                {
                                    Console.WriteLine("The record is in " + (i+1) + " shelf " + (j+1) + " column");
                                    recordWasFond = true;
                                    break;
                                }
                            } 
                        }

                        if (recordWasFond == false)
                        {
                            Console.WriteLine("There is no such record");
                        }

                        menuPosY = 10;
                        break;


                    case 2:
                        
                        Console.Clear();
                        Console.SetCursorPosition(5, 0);
                        Console.WriteLine("Murlo's collection");
                        Console.SetCursorPosition(0, 2);
                        Console.Write("Type shelf number: ");
                        int shelf = Convert.ToInt32(Console.ReadLine());
                        if (shelf > records.GetLength(0) || shelf <= 0)
                        {
                            Console.WriteLine("Wrong shelf");
                            menuPosY = 10;
                            break;
                        }
                        Console.Write("Type column number: ");
                        int column = Convert.ToInt32(Console.ReadLine());
                        if (column > records.GetLength(1) || column <= 0)
                              {
                            Console.WriteLine("Wrong column");
                            menuPosY = 10;
                            break;
                        }



                        Console.WriteLine("That record is " + records[(shelf-1), (column-1)]);
                        menuPosY = 10;
                        break;

                    case 3:
                        Console.Clear();
                        Console.SetCursorPosition(5, 0);
                        Console.WriteLine("Murlo's collection");

                        for (int i = 0; i < records.GetLength(0); i++)
                        {
                            for (int j = 0; j < records.GetLength(1); j++)
                            {
                                Console.Write(records[i, j] + " | ");
                            }
                            Console.WriteLine("\n");
                        }

                        menuPosY = 14;
                        break;

                    case 4:
                        recordCase = false;
                    break;
                       
                }
            }
            

            //Console.ReadKey();


        }
    }
}
