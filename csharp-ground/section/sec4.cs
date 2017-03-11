using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ground.section
{
    class sec4
    {
        public static void SecIV()
        {

            int n = 0;
            do
            {
                Console.Write("Height : ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0 || n > 23);


            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = n-(i+1); k <= n; k++)
                {
                    Console.Write("#");
                }

                Console.Write("\n");
            }
        }
    }
}
