using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_16.Task_2
{
    internal class GetStringFirstLetter
    {
        public static string GetLineWithFirstLetter(string path, char firstChar)
        {
            return Convert.ToString(File.ReadAllLines(path)
                .Where(s => s[0] == firstChar));
        }

    }
}
