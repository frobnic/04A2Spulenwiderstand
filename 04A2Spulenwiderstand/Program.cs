using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04A2Spulenwiderstand
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, L, Z, f;

            Console.Write("R");
            R = double.Parse(Console.ReadLine());
            Console.Write("L");              
            L = double.Parse(Console.ReadLine());
            Console.Write("f");              
            f = double.Parse(Console.ReadLine());

            Z = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(2 * Math.PI * f * L, 2));

            Console.WriteLine("Z = " + Z);
        }
    }
}
