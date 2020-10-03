using System;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program ");
            int length = 0;
            Console.WriteLine("Enter the first coordinate");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Coordinate");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Coordinate : " + x1 + "," +y1);
            Console.WriteLine("Second Coordinate : " +x2 + "," + y2);

            Console.ReadKey();






        }

    }
}
