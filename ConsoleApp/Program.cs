using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parola da convertire");
            string g = Console.ReadLine();
            foreach (char c in g)
            {
                Console.WriteLine(System.Convert.ToInt32(c));
            }
            Console.ReadKey();
        }
    }
}
