using System;
using System.Net.Http;
using System.Net.NetworkInformation;
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
            double length = 0;
            Console.WriteLine("Enter the first coordinate");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Coordinate");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Coordinate : " + x1 + "," +y1);
            Console.WriteLine("Second Coordinate : " +x2 + "," + y2);

            double calculated;
            Program P = new Program();
            calculated = P.Formula(x1, y1, x2, y2);

            
            length = length + calculated;
            Console.WriteLine("Calculated Lenth is {0}", length);

            Console.ReadKey();
        }

        public double Formula(int x1, int y1, int x2, int y2)
        {
            
            double formula = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return formula;
        }

    }
}
