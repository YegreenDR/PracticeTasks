using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_16.Task_2
{
    internal class DeleteString
    {
        public static void DeleteStringAndWrite(string filePath, string filePath1)
        {
            string[] readText = File.ReadAllLines(filePath);
            string[] writeText = new string[readText.Length - 1];
            Array.Copy(readText, 0, writeText, 0, readText.Length - 1);
            File.WriteAllLines(filePath1, writeText);
        }
    }
}
