using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, sign;
            int age;
            Console.Write("Введите имя?:");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет?:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кто вы по зодиаку?:");
            sign = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, вам {age} лет, вы {sign}");
            Console.ReadKey();
            
           
        }
    }
}
