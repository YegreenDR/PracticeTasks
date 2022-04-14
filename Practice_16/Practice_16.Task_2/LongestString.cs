namespace Practice_16.Task_2
{
    internal class LongestString
    {
        public static string GetLongestString(string path)
        {
            return Convert.ToString(File.ReadAllLines(path)
                .Where(s => s.Length == File.ReadAllLines(path).Max(m => m.Length))
                .First());
        }

    }
}
