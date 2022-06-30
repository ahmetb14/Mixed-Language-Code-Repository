using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Ahmet", "Berkay", "Yılmaz" };
            students = new string[4] { "", "", "", "" };
            string[] students2 = { "Ahmet", "Berkay", "Yılmaz" };
            //students2[3] = "Ahmet";

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {

                { "İstanbul","İzmit","Balıkesir" },
                { "Ankara","Konya","Kırıkkale" },
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun" },
                { "İzmir","Muğla","Manisa" },

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("************");
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
