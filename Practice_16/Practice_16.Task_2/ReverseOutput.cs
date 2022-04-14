using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_16.Task_2
{
    internal class ReverseOutput
    {
        public static void PrintToFileReverseLinesInfile(string path)
        {
            string pathoutput = @"D:\Practice16Reverse.txt";
            File.WriteAllLines(pathoutput, File.ReadAllLines(path).Reverse());
        }

    }
}
