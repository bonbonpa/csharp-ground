using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ground.section
{
    class sec3
    {
        public static void SecIII()
        {
            //Constant
            Console.WriteLine(">>>> Section 3 Constant <<<<\n");
            const float PI = 3.14f;
            float r = 4;

            float area = PI * r * r;
            float circumference = 2 * PI * r;
            float volumn = (4 / 3.0f) * PI * r * r * r;
            float surface = 4 * PI * r * r;

            Console.WriteLine("Circle radius = {0}",r);
            Console.WriteLine("Circle area = {0}",area);
            Console.WriteLine("Circle circumference = {0}");
            Console.WriteLine("Circle volumn = {0}",volumn);
            Console.WriteLine("Circle surface = {0}",surface);

            //Constant and Array
            const int SIZE = 5;

            string[] names = new string[SIZE];
            int[] scores = new int[SIZE];

            Console.WriteLine("Enter name score of {0} players" , SIZE);
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine("Player {0} name: " , i + 1);
                names[i] = Console.ReadLine();
                Console.WriteLine("Player {0} score" , i + 1);
                scores[i] = Int32.Parse(Console.ReadLine());
            } //read value
            int maxIndex = 0;

            for (int i = 0; i < SIZE; i++)
            {
                if(scores[i] > scores[maxIndex])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine("{0} is the winner with score {1}" , names[maxIndex],scores[maxIndex]);

            Console.WriteLine("\n>>>> End Section 3 Constant <<<<");
        }
    }
}
