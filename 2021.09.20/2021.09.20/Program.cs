using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021._09._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam=Convert.ToInt32(Console.ReadLine());
            if (szam >= -30 && szam <40) 

           
            {
                Console.WriteLine("A szám -30-nál nagyobb");
            }

            else

            {
                Console.WriteLine("A szám 40-nél kisebb");
            }


            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

