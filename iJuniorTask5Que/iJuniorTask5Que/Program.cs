using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJuniorTask5Que
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPerPerson = 10; //минут
            int amountOfPeople;
            float waitingTimeHours, waitingTimeMin;
            Console.Write("Сколько перед вами старушек?: ");
            amountOfPeople = Convert.ToInt32(Console.ReadLine());

            waitingTimeHours = amountOfPeople * waitingPerPerson/60;
            waitingTimeMin = Convert.ToSingle(amountOfPeople) * waitingPerPerson % 60;
            Console.WriteLine("Вам ждать: " + waitingTimeHours + " часа "+ waitingTimeMin + " минут. Подумайте о смысле жизни");
            Console.ReadKey();
        }
    }
}
