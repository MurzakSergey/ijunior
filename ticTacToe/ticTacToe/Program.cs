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
            char[,] map = 
           {
           { '_','_','_','_','_','_','_','_','_','_','_','_','_'},
           {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
           {'|','-','-','-','+','-','-','-','+','-','-','-','|'},
           {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
            {'|','-','-','-','+','-','-','-','+','-','-','-','|'},
           {'|',' ',' ',' ','|',' ',' ',' ','|',' ',' ',' ','|'},
           {'T','T','T','T','T','T','T','T','T','T','T','T','T'}}; // the map

            bool itsNotTheEnd = true;
            int xPos = 1;
            int yPos = 1;
            char symbolOpen = '[';
            char symbolClose = ']';
            bool xMove = true;
            while (itsNotTheEnd)                                                             //Начало хода
            {
                
                
                while (xMove)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(0, 0);
                for (int i= 0; i<map.GetLength(0); i++)
                { for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                   
                }
                        Console.Write("\n");
                    }
                    Console.SetCursorPosition(xPos, yPos);
                    Console.WriteLine(symbolOpen);
                    Console.SetCursorPosition(xPos+2, yPos);
                    Console.WriteLine(symbolClose);
                    ConsoleKeyInfo move = Console.ReadKey();
                   
                    switch (move.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (yPos <= 3) yPos = yPos + 2;
                            else Console.ForegroundColor = ConsoleColor.Green;
                            break;

                        case ConsoleKey.UpArrow:
                            if (yPos > 1) yPos = yPos - 2;
                            else Console.ForegroundColor = ConsoleColor.Yellow;
                            break;

                        case ConsoleKey.LeftArrow:
                            if (xPos > 1) xPos = xPos - 4;
                            else Console.ForegroundColor = ConsoleColor.Red;
                            break;

                        case ConsoleKey.RightArrow:
                            if (xPos <= 7) xPos = xPos + 4;
                            else Console.ForegroundColor = ConsoleColor.Cyan;
                            break;

                        case ConsoleKey.Enter:
                            map[yPos, xPos+1] = 'X';
                            xMove = false;
                            break;
                        
                    }
                    
                    Console.Clear();
                    
                    }                              // X move
                while (xMove == false)
                {
                   
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, 0);
                    //int[,] win = new int[7, 7];

                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            Console.Write(map[i, j]);
                            //Console.Write(i + " " + j);
                        }
                        Console.Write("\n");
                    }

                    Console.SetCursorPosition(xPos, yPos);
                    Console.WriteLine(symbolOpen);
                    Console.SetCursorPosition(xPos + 2, yPos);
                    Console.WriteLine(symbolClose);
                    ConsoleKeyInfo move = Console.ReadKey();

                    switch (move.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (yPos <= 3) yPos = yPos + 2;
                            else Console.ForegroundColor = ConsoleColor.Green;
                            break;

                        case ConsoleKey.UpArrow:
                            if (yPos > 1) yPos = yPos - 2;
                            else Console.ForegroundColor = ConsoleColor.Yellow;
                            break;

                        case ConsoleKey.LeftArrow:
                            if (xPos > 1) xPos = xPos - 4;
                            else Console.ForegroundColor = ConsoleColor.Red;
                            break;

                        case ConsoleKey.RightArrow:
                            if (xPos <= 7) xPos = xPos + 4;
                            else Console.ForegroundColor = ConsoleColor.Cyan;
                            break;

                        case ConsoleKey.Enter:
                            map[yPos, xPos+1] = 'O';
                            xMove = true;
                            break;
                    }

                    

                    Console.Clear();
                }                      // O move
                itsNotTheEnd = Chek('X', itsNotTheEnd, map);
                itsNotTheEnd = Chek('O', itsNotTheEnd, map);

            }

            Console.WriteLine("ITS OVER");
            Thread.Sleep(500);

        }
        static bool Chek(char xOrY, bool k, char[,] map)
        {
                        
            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (map[i, 2] == xOrY && map[i, 6] == xOrY && map[i, 10] == xOrY)
                {
                k = false;
                    break;

                }
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[1, j] == xOrY && map[3, j] == xOrY && map[5, j] == xOrY)
                    {
                        k = false;
                        break;
                    }

                    if (map[1, 2] == xOrY && map[3, 6] == xOrY && map[5, 10] == xOrY)
                    {
                        k = false;
                        break;
                    }

                    if (map[1, 10] == xOrY && map[3, 6] == xOrY && map[5, 2] == xOrY)
                    {
                        k = false;
                        break;
                    }
                }
            }
            return k;
        }
    }
    
}
