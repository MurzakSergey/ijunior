using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ticTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool reStart = true;

            while (reStart)
            {
                char[,] map =
           {
           { '_','_','_','_','_','_','_','_','_','_','_','_','_'},
           {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
           {'|','-','-','-','+','-','-','-','+','-','-','-','|'},
           {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
           {'|','-','-','-','+','-','-','-','+','-','-','-','|'},
           {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
           {'T','T','T','T','T','T','T','T','T','T','T','T','T'}}; // the map
                int itsNotTheEnd = 1;
                int consoleShift = 10;
                int xPos = consoleShift + 1;
                int yPos = consoleShift + 1;
                int moveCounting = 0;
                char player = ' ';
                bool xMove = true;


                while (itsNotTheEnd == 1)                                                             //Начало хода
                {

                    // X move 
                    while (xMove)
                    {
                        player = 'X';
                        Map(player, consoleShift, xPos, yPos, map);
                        ConsoleKeyInfo move = Console.ReadKey();

                        switch (move.Key)
                        {
                            case ConsoleKey.DownArrow:
                                if (yPos <= consoleShift + 3) yPos = yPos + 2;
                                break;

                            case ConsoleKey.UpArrow:
                                if (yPos > consoleShift + 1) yPos = yPos - 2;

                                break;

                            case ConsoleKey.LeftArrow:
                                if (xPos > consoleShift + 1) xPos = xPos - 4;
                                break;

                            case ConsoleKey.RightArrow:
                                if (xPos <= consoleShift + 7) xPos = xPos + 4;
                                break;

                            case ConsoleKey.Enter:
                                if (map[yPos - consoleShift, xPos + 1 - consoleShift] != ' ')
                                {
                                    Console.SetCursorPosition(consoleShift + 1, consoleShift + 8);
                                    Console.WriteLine("Here is " + map[yPos - consoleShift, xPos + 1 - consoleShift] + " already!");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                map[yPos - consoleShift, xPos + 1 - consoleShift] = player;
                                xMove = false;
                                moveCounting++;
                                break;

                        }

                        Console.Clear();
                        itsNotTheEnd = Chek(player, itsNotTheEnd, moveCounting, map);

                    }
                    if (itsNotTheEnd == 0 || itsNotTheEnd == 2) break;

                    // O move
                    while (xMove == false)
                    {
                        player = 'O';
                        Map(player, consoleShift, xPos, yPos, map);
                        ConsoleKeyInfo move = Console.ReadKey();

                        switch (move.Key)
                        {
                            case ConsoleKey.DownArrow:
                                if (yPos <= consoleShift + 3) yPos = yPos + 2;
                                break;

                            case ConsoleKey.UpArrow:
                                if (yPos > consoleShift + 1) yPos = yPos - 2;
                                break;

                            case ConsoleKey.LeftArrow:
                                if (xPos > consoleShift + 1) xPos = xPos - 4;
                                break;

                            case ConsoleKey.RightArrow:
                                if (xPos <= consoleShift + 7) xPos = xPos + 4;
                                break;

                            case ConsoleKey.Enter:
                                if (map[yPos - consoleShift, xPos + 1 - consoleShift] != ' ')
                                {
                                    Console.SetCursorPosition(consoleShift + 1, consoleShift + 8);
                                    Console.WriteLine("Here is " + map[yPos - consoleShift, xPos + 1 - consoleShift] + " already!");
                                    Thread.Sleep(1000);
                                    break;
                                }
                                map[yPos - consoleShift, xPos + 1 - consoleShift] = player;
                                xMove = true;
                                moveCounting++;
                                break;
                        }



                        Console.Clear();
                        itsNotTheEnd = Chek(player, itsNotTheEnd, moveCounting, map);
                        break;
                    }


                }

                Console.SetCursorPosition(consoleShift, consoleShift);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);

                    }
                    Console.Write("\n");
                    for (int n = 0; n < consoleShift; n++)
                    {

                        Console.Write(" ");
                    }
                }
                Kitten(consoleShift);
                Console.SetCursorPosition(consoleShift+10, consoleShift+16);
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (itsNotTheEnd == 2) Console.WriteLine("Draw!");
                else Console.WriteLine(player + " wins!");
                Thread.Sleep(500);
                Console.SetCursorPosition(consoleShift, consoleShift+17);
                Console.WriteLine("To restart press <Enter>, and any key to exit");
                


                Thread.Sleep(1500);
                ConsoleKeyInfo restart = Console.ReadKey();
                if (restart.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    reStart = true;

                }
                else reStart = false;
            }


        }
        static int Chek(char xOrY, int itsNotTheEnd, int moveCounting, char[,] map)
        {

            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (map[i, 2] == xOrY && map[i, 6] == xOrY && map[i, 10] == xOrY)
                {

                    Console.ForegroundColor = ConsoleColor.Green;

                    itsNotTheEnd = 0;
                    break;

                }
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[1, j] == xOrY && map[3, j] == xOrY && map[5, j] == xOrY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        itsNotTheEnd = 0;
                        break;
                    }

                    if (map[1, 2] == xOrY && map[3, 6] == xOrY && map[5, 10] == xOrY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        itsNotTheEnd = 0;
                        break;
                    }

                    if (map[1, 10] == xOrY && map[3, 6] == xOrY && map[5, 2] == xOrY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        itsNotTheEnd = 0;
                        break;
                    }

                    else if (moveCounting == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        itsNotTheEnd = 2;
                    }
                }
            }

            return itsNotTheEnd;

        }
        static void Map(char player, int consoleShift, int xPos, int yPos, char[,] map)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(consoleShift - 8, consoleShift - 5);
            Console.WriteLine("Use arrors to move and <Enter> to put a " + player);
            Console.SetCursorPosition(consoleShift + 2, consoleShift - 3);
            Console.WriteLine(player + " move");
            Console.SetCursorPosition(consoleShift, consoleShift);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);

                }
                Console.Write("\n");
                for (int n = 0; n < consoleShift; n++)
                {

                    Console.Write(" ");
                }
            }


            Console.SetCursorPosition(xPos, yPos);
            Console.WriteLine("[");
            Console.SetCursorPosition(xPos + 2, yPos);
            Console.WriteLine("]");
        }
        static void Kitten(int consoleShift)
        {
            char[,] Kitten =
             {
           { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
           { ' ',' ','|',' ',' ',' ',' ',' ',' ',' ','|',' ',' '},
           { ' ',' ','|','-','-','-','-','-','-','-','|',' ',' '},
           { ' ',' ','|',' ',' ',' ',' ',' ',' ',' ','|',' ',' '},
           { ' ',' ','|',' ','Y',' ',' ',' ','Y',' ','|',' ',' '},
           { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
           { ' ','-','-','-',' ',' ','T',' ',' ','-','-','-',' '},
           { ' ','-','-','-','_',' ','.',' ','_','-','-','-',' '},
           { ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}, };

            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < Kitten.GetLength(0); i++)
            {
                for (int j = 0; j < Kitten.GetLength(1); j++)
                {
                    Console.Write(Kitten[i, j]);

                }
                Console.Write("\n");
                for (int n = 0; n < consoleShift; n++)
                {

                    Console.Write(" ");
                }
            }





        }

    }
}
