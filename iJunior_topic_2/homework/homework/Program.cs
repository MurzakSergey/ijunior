using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 0;
            //Random rand = new Random();



            //int[,] matrix = new int[10, 10];

            //for (int i=0; i<matrix.GetLength(0); i++ )
            //{
            //    for (int j = 0; j< matrix.GetLength(1); j++)
            //    {
            //        matrix[i, j] = rand.Next(0, 100);

            //        Console.Write(matrix[i, j ] + " ");




            //    }
            //    Console.WriteLine("\n");
            //}

            //foreach (int cell in matrix)
            //{

            //    if (cell >= number)
            //    {
            //    number = cell;
            //    }

            //}

            //Console.WriteLine(number);


            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++)
            //        {
            //           if (number == matrix[i, j])
            //        {
            //            matrix[i, j] = 0;
            //        }

            //            Console.Write(matrix[i, j] + " ");




            //        }
            //        Console.WriteLine("\n");
            //    }


            //Console.ReadLine();




            //Задача:
//            Пользователь вводит числа, и программа их запоминает.
//Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.

//Выход из программы должен происходить только в том случае, если пользователь введет команду exit.

//Программа должна работать на основе расширения массива.

//Внимание, нельзя использовать List<T> и Array.Resize


            int[] figure = new int[1];
            Console.WriteLine(figure[0]);
            bool counting = true;
            string toType;
            int degit;
         
            while (counting)
            {
                toType = Console.ReadLine();
                if (toType == "exit")
                {
                    counting = false;
                    break;
                }

                else if (toType == "sum")
                {
                    int finalSum = 0;
                    foreach (int sum in figure)
                    {
                        
                        finalSum = finalSum + sum;                        
                        Console.WriteLine(finalSum);
                    }

                    //sum = figure[figure.Length - 1];
                    Console.WriteLine();
                    counting = false;
                    break;

                }


                degit = Convert.ToInt32(toType);

                figure[figure.Length-1] = degit;
                //Console.WriteLine(figure[figure.Length-1]);

                int[] nextFigure = new int[figure.Length + 1];
                for (int i = 0; i < figure.Length; i++)
                {
                nextFigure[i] = figure[i];
                Console.WriteLine(figure[i]);
                }
                                
                figure = nextFigure;


            }
            Console.WriteLine("Lola <3");
            Console.ReadKey();

        }
            


        
    }
}
