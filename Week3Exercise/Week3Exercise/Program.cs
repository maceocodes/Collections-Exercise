using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car rx7 = new Car();
            rx7.Make = Console.ReadLine();
            rx7.Year = int.Parse(Console.ReadLine());
            rx7.Price = double.Parse(Console.ReadLine());
        }
    }
}
