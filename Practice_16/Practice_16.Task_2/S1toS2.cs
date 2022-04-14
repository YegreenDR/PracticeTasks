namespace Practice_16.Task_2
{
    internal class S1toS2
    {
        public static string GetStringsS1ToS2(string filePath, int fromS1, int toS2)
        {
            return Convert.ToString(File.ReadAllLines(filePath)
                .Skip(fromS1)
                .Take(File.ReadAllLines(filePath).Length - toS2));
        }

    }
}
