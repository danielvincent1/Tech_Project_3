/*
    Daniel Villavicencio
    09/21/2021
    Tech Project 3
    Iterative Statements
*/

using System;

namespace Tech_Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilometer increment value = ");

            try
            {
                string input = Console.ReadLine();
                int km = int.Parse(input);

                Console.WriteLine("Kilometer Increment Value = " + km);
                Console.WriteLine("{0} {1}", "Kilometers ", "Equivalent Miles");
                Console.WriteLine("{0} {1}", "0 ", "         0");

                do
                {
                    int INCREMENT = km;
                    do
                    {
                        double miles = km * 0.621371;
                        
                        Console.WriteLine(Convert.ToString(km) + "         " + miles);


                        km += INCREMENT;
                    }
                    while (km <= 200);
                }
                while (km >= 10 && km <=25);

            }
            catch
            {

            }
        }
    }
}
