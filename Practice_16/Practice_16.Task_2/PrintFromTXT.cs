namespace Practice_16.Task_2
{
    internal class PrintFromTXT
    {
        public static void Print()
        {
            try
            {
                using (StreamReader sr = new StreamReader("D:\\Practice16.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение: " + e.Message);
            }
        }
    }
}
