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
            int number = 0;
            Random rand = new Random();
                    


            int[,] matrix = new int[10, 10];

            for (int i=0; i<matrix.GetLength(0); i++ )
            {
                for (int j = 0; j< matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0, 100);

                    Console.Write(matrix[i, j ] + " ");
                           
                              


                }
                Console.WriteLine("\n");
            }

            foreach (int cell in matrix)
            {

                if (cell >= number)
                {
                number = cell;
                }

            }

            Console.WriteLine(number);

           
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                       if (number == matrix[i, j])
                    {
                        matrix[i, j] = 0;
                    }

                        Console.Write(matrix[i, j] + " ");




                    }
                    Console.WriteLine("\n");
                }


            Console.ReadLine();



        }
    }
}
