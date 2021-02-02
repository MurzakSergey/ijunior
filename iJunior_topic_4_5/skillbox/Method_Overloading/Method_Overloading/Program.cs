using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int lol = sum(new int[] { 1, 2, 2 }); // берем сумму из первого метода, где в качестве переменной передается только массив
            Console.WriteLine(lol);
            lol = sum(1, 2, 5, 123); // так как использовали в качестве переменных не массив, а числа, то бепертся вторая перегрузка, где 
                                     // сначала берется единице в качестве аргумента переменной key, а остальные аргументы через params передается в массив 
            Console.WriteLine(lol);
            Console.WriteLine(notRecursionFibonacci(89)); // считаем без рекурсии указанное число Фибоначчи. Если задавать 40, то решает мгновенно
            Console.WriteLine(fibonacсi(30)); // считаем рекурсией указанное число Фибоначчи. Если задавать 40, то уже тормозит
            
            Console.ReadLine();


        }

        static int sum(params int[] array)
        {
            int result = 0;
            foreach (var s in array)
            {
                result += s;

            }
            return result;            
        }
        static int sum(int key, params int[] array)
        {
            int result = 0;
           foreach (var s in array)
            {
                result += s;

            }

            Console.WriteLine("Type multilplication factor: ");
            key = Convert.ToInt32(Console.ReadLine());
            result *= key;
            return result;
        }

        static int fibonacсi (int n)
        {
            return (n==1 || n==2 ? 1 : fibonacсi(n-1)+fibonacсi(n-2));

        } // рекурсия, считающая число фибоначчи

        static int notRecursionFibonacci (int number)
        {
            int first = 1;
            int second = 1;
            int res=0;

            if (number == 1 || number == 2) return 1;

            else { 
           
            for (int i=0; i<(number-2); i++)
            {
                    res = first + second;
                    first = second;
                    second = res;
            }

            return res;
            }
        }

        

    }
}
