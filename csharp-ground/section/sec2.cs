using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ground.section
{
    class sec2
    {
        public static void SecII() {
            //Variable and Datatype
            Console.WriteLine(">>>> Section 2 Variable and DataType <<<<\n");
            int year = 1990;
            string name = "Marcus";
            string nationality = "African";

            Console.WriteLine("His nmae is {0}",name);
            Console.WriteLine("He was born in {0}", year);
            Console.WriteLine("He is {0}", nationality);

            Console.WriteLine("\n");

            //Boolean
            Console.WriteLine("#Boolean");
            bool isDay = true;

            if(isDay)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
            bool gameOver = false;
            Console.WriteLine("Game Over = {0}",gameOver);

            Console.WriteLine("\n");
            Console.WriteLine("#Datatype number Integer");
            int apple = 18;
            int mango = 5;
            int totalFruit = apple + mango;

            Console.WriteLine("We have {0} fruits in the basket",totalFruit);

            byte month = 12;
            byte day = 10;
            short year2 = 2016;

            Console.WriteLine("Date {0}/{1}/{2}" ,month,day,year2);

            decimal bigNumber = 9460730472580800;
            Console.WriteLine(bigNumber.ToString("0.00000E0"));

            int max = Int32.MaxValue;
            Console.WriteLine(max);
            max = max + 1;
            Console.WriteLine(max);

            Console.WriteLine("\n");
            Console.WriteLine("#Datatype number float double decimal");

            float speed = 8.3f;
            float time = 10.25f;
            float distance = speed * time;

            Console.WriteLine("Mateo runs at speed {0} m/s in {1} seconds",speed ,time);
            Console.WriteLine("Total run distance {0} meters",distance);

            float lightSpeed = 5.8785E12f; //5.8786 x 10^12
            Console.WriteLine("Light can travel {0} miles in 1 year ",lightSpeed);

            double dayx = 365.25;
            double neutronMass = 1.674927471E-27;
            double pi = 22 / 7.0f;
            Console.WriteLine("Earth take about {0} day to orbit the sun",day);
            Console.WriteLine("PI value = {0}", pi);
            Console.WriteLine("Nuetron Mass = {0} kg" ,neutronMass);

            Console.WriteLine("#Datatype Char and String");
            char ch = 'C';
            string OOP = "OOP";

            Console.WriteLine("You are learning {0}# by {1}" ,ch ,OOP);

            Console.WriteLine("\n>>>> End Section 2 Variable and DataType <<<<");
        }
        
    }
}
