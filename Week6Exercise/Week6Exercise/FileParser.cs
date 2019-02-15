using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week6Exercise
{
    class FileParser : IFileParser
    {
        public string[] Read(string path)
        {
            int arraySize = 0;
            string[] array;

            var reader = new StreamReader(path);

            arraySize = int.Parse(reader.ReadLine());

            array = new string[arraySize];

            for(int i = 0; i < array.Length; i++ )
            {
                array[i] = reader.ReadLine();
            }
            reader.Close();
            reader.Dispose();

            return array;
        }
    }
}
