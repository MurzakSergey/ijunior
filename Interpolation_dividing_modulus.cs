using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation_dividing_modulus

{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCards = 52;
            int columns = 3;
            float rows =  numberOfCards/columns;
            float inTheRest = Convert.ToSingle(numberOfCards) % columns;

            Console.WriteLine("Рядов по три карты =" + rows);
            Console.WriteLine($"Карт в остатке ={inTheRest}");
            Console.ReadKey();
        }
    }
}
