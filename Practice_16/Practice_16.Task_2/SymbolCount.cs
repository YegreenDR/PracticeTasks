using System.IO;

namespace Practice_16.Task_2
{
    internal class SymbolCount
    {
        public static void SymCount()
        {
            var charCount = 0;
            using (var reader = new StreamReader(@"D:\Practice16.txt", detectEncodingFromByteOrderMarks: true))
            {
                while (reader.Read() > -1)
                {
                    charCount++;
                }
            }
            Console.WriteLine(charCount);
        }
    }
}
