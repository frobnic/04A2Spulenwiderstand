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

            Console.Write("Bitte erfassen Sie den Widerstand R in Ohm    :");
            R = double.Parse(Console.ReadLine());
            Console.Write("Bitte erfassen Sie die Induktivität L in Henry:");              
            L = double.Parse(Console.ReadLine());
            Console.Write("Bitte erfassen Sie die Frequenz f             :");              
            f = double.Parse(Console.ReadLine());

            Z = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(2 * Math.PI * f * L, 2));

            Console.WriteLine("Z = {0:F2} Ohm" , Z);
        }
    }
}
