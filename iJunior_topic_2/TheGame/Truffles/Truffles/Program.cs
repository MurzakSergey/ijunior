using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truffles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; 
            bool playing = true;
            char[,] map =
            {
            {'_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_','_'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ','I','I','I','I',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ','I',' ',' ','I',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ','I',' ',' ','I',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ','I',' ',' ','I',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|'},
            {'T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T','T'}
            };
                     



            //int[,] delta = new int[10, 10];
            int posX = 1, posY = 1;
            char[] bag = new char[1];
            while (playing)
            {
                Console.WriteLine("You are pig. Pick up truffles as $ using arrows! ");
            for (int i=0; i<map.GetLength(0); i++)
            {
                for (int j=0; j<map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
               Console.Write("\n");
            }
                
                
                Console.SetCursorPosition(0, 20);
                Console.Write("Score: ");
                for (int bagLenth = 0; bagLenth < bag.Length; bagLenth++)
                {
                    bag[bagLenth] = 'X';
                    Console.Write(bag[bagLenth]);
                }
                
                // Console.SetCursorPosition (delta[1,0]+posY, delta[0,1]+posX);
                Console.SetCursorPosition(posX, posY+1);
                Console.WriteLine('C');
                ConsoleKeyInfo move = Console.ReadKey();

                switch (move.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (map[posY+1, posX] == ' ' || map[posY + 1, posX] == '$')
                        { posY++; }
                        break;

                    case ConsoleKey.UpArrow:
                        if (map[posY-1, posX] == ' ' || map[posY - 1, posX] == '$')
                        { posY--; }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (map[posY, posX-1] == ' ' || map[posY, posX - 1] == '$')
                        { posX--; }
                        break;

                    case ConsoleKey.RightArrow:
                        if (map[posY, posX+1] == ' ' || map[posY, posX + 1] == '$')
                        { posX++; }
                        break;
                }

                if (map[posY, posX] == '$')
                {
                    map[posY, posX] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int tbLenth = 0; tbLenth < bag.Length; tbLenth++)
                    {
                        tempBag[tbLenth] = bag[tbLenth];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;
                }

                Console.Clear();





            }

            
            
        }

       
    }
}
