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
            if (szam % 2<0) 

           
            {
                Console.WriteLine("A hőmérséklet fagy");
            }

            else

            {
                Console.WriteLine("A hőmérséklet nem fagy");
            }


            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

