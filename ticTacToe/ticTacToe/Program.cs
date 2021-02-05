using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map = 
           {
           { '_','_','_','_','_','_','_'},
           {'|',' ','|',' ','|',' ','|'},
           {'|','-','+','-','+','-','|'},
           {'|',' ','|',' ','|',' ','|'},
           {'|','-','+','-','+','-','|'},
           {'|',' ','|',' ','|',' ','|'},
           {'T','T','T','T','T','T','T'}};

            bool itsNotTheEnd = true;
            int xPos = 1;
            int yPos = 1;
            char symbol = 'X';

            while (itsNotTheEnd)                                                             //Начало хода
            {
                
                bool xMove = true;
                while (xMove)
                {
                    Console.SetCursorPosition(0, 0);
                    //int[,] win = new int[7, 7];

                for (int i= 0; i<map.GetLength(0); i++)
                { for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                    //Console.Write(i + " " + j);
                }
                        Console.Write("\n");
                    }

                
                
                    

                    Console.SetCursorPosition(xPos, yPos);
                    Console.WriteLine(symbol);
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
                            if (xPos > 1) xPos = xPos - 2;
                            else Console.ForegroundColor = ConsoleColor.Red;
                            break;

                        case ConsoleKey.RightArrow:
                            if (xPos <= 3) xPos = xPos + 2;
                            else Console.ForegroundColor = ConsoleColor.Cyan;
                            break;

                        case ConsoleKey.Enter:
                            map[yPos, xPos] = 'X';
                            symbol = 'O';
                            xMove = false;
                            break;

                    }

                    Console.Clear();
                }

            }


            Console.ReadLine();

        }
        //static void PlayerMove()
        //{
        //    ConsoleKeyInfo move = Console.ReadKey();
        //    int yPos = 0;
        //    int xPos = 0;

        //    switch (move.Key)
        //    {
        //        case ConsoleKey.DownArrow:
        //            if (yPos <= 3) yPos = yPos + 2;
        //            else Console.ForegroundColor = ConsoleColor.Green;
        //            break;

        //        case ConsoleKey.UpArrow:
        //            if (yPos > 1) yPos = yPos - 2;
        //            else Console.ForegroundColor = ConsoleColor.Yellow;
        //            break;

        //        case ConsoleKey.LeftArrow:
        //            if (xPos > 1) xPos = xPos - 2;
        //            else Console.ForegroundColor = ConsoleColor.Red;
        //            break;

        //        case ConsoleKey.RightArrow:
        //            if (xPos <= 3) xPos = xPos + 2;
        //            else Console.ForegroundColor = ConsoleColor.Cyan;
        //            break;

        //        case ConsoleKey.Enter:
        //            map[yPos, xPos] = 'X';
        //            char symbol = 'O';
        //            bool xMove = false;
        //            break;
        //    }

    }
}
