using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] records = {{"Дельфин", "Мумий Тролль", "ЛЮК", "Слезы", "Психея"}, {"Deftones", "BMTH", "KORN" , "Led Zeppelin", "Gojira"},
            { "Trentemeller", "Phantogramm", "St.Vinsent", "Depesh Mode", "Dua Lipa"} };

            Console.WriteLine("Type smtn");


            for (int i = 0; i < records.GetLength(0); i++)
                

            {
                Console.Write("\n");
                for (int j = 0; j < records.GetLength(1); j++)

                {
                    Console.Write(records[i, j] + " | ");

                }



            }


            Console.ReadKey();


        }
    }
}
