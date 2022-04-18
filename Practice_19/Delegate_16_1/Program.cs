namespace Task_1
{
    class Delegate
    {

        public delegate double CalcFigure(double R, Action<string> action);
        /// <summary>
        /// returns lenght of circle with radius r
        /// </summary>
        /// <returns> double number lenght of circle</returns>
        public static double Get_Length(double r, Action<string> action)
        {
            double D;
            D = 2 * Math.PI * r;
            action($"Длина окружности={ Math.Round(D, 3)}");
            return D;
        }
        /// <summary>
        /// returns area of circle with radius r
        /// </summary>
        /// <returns> double number area of circle</returns>
        public static double Get_Area(double r, Action<string> action)
        {
            double S;
            S = Math.PI * Math.Pow(r, 2);
            action($"Площадь круга={Math.Round(S, 3)}");
            return S;
        }
        /// <summary>
        /// returns area of circle with radius r
        /// </summary>
        /// <returns> double number area of circle</returns>
        public static double Get_Volume(double r, Action<string> action)
        {
            double V;
            V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            action($"Объём шара={Math.Round(V, 3)}");
            return V;
        }

    }
}