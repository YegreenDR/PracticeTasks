using System;

namespace Practice_3.Task_4
{
    class WordMatr
    {
        private string[,] _matr;
       public int RowCount=>_matr.GetLength(0);
        public int ColumnCount => _matr.GetLength(1);

        public string this[int i,int j]
        {
            get
            {
                return _matr[i, j];
            }
        }
        public WordMatr(string [,] matr)
        {
            _matr = matr;
        }
        public WordMatr(int rowCount, int columnCount)
        {
            _matr = new string[rowCount, columnCount];
        }

        public static WordMatr operator + (WordMatr currentMatr, WordMatr addMatr)
        {
            string[,] result = new string[currentMatr.RowCount, currentMatr.ColumnCount];
            for (int i = 0; i < currentMatr.RowCount; i++)
            {
                for (int j = 0; j < currentMatr.ColumnCount; j++)
                {
                    result[i, j] = currentMatr[i, j] + " " + addMatr[i, j];
                }
            }
            return new WordMatr(result);
        }
        
        public void Info()
        {
            for (int i = 0; i < _matr.GetLength(0); i++)
            {
                for (int j = 0; j < _matr.GetLength(1); j++)
                {
                    Console.Write($"{_matr[i,j],-20}");
                }
                Console.WriteLine();
            }
        }
        public void Fill()
        {
            for (int i = 0; i < _matr.GetLength(0); i++)
            {
                for (int j = 0; j < _matr.GetLength(1); j++)
                {
                    _matr[i, j] = Faker.Name.First();
                }
            }
        }

    }
}
