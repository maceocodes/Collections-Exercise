using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileParser parser = new FileParser();

            var arrayData = parser.Read("C:/Users/246600/Desktop/CodeLou/C#/Week6Exercise/Week6Exercise/data.txt");

            for (int i = 0; i < arrayData.Length; i++)
            {
                Console.WriteLine(arrayData[i]);
            }
        }
    }
}
