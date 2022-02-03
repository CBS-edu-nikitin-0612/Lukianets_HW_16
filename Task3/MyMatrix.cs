using System;

namespace Task3
{
    internal class MyMatrix
    {
        private int[,] matrix;
        private int _n, _m;

        public MyMatrix(int n, int m)
        {
            N = n; 
            M = m;
            matrix = new int[n, m];
        }

        public void InitializeByRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < _n; i++)
                for (int j = 0; j < _m; j++)
                    matrix[i, j] = rnd.Next(0, 10);
        }

        public void Show()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _m; j++)
                    Console.Write($"{matrix[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void ShowAllMatrix()
        {
            int min = _n < _m ? _n : _m;

            for (int num = 1; num <= min; num++)
            {
                Console.WriteLine($"Matrix {num}");
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                        Console.Write($"{matrix[i, j]} ");
                    Console.WriteLine();
                }
                Console.WriteLine("_",10);
            }
            Console.WriteLine();
        }

        public MyMatrix ChangeColumnNumber(int col)
        {
            Random rnd = new Random();
            MyMatrix newMatrix = new MyMatrix(_n, col);

            for (int i = 0; i < _n; i++)
                for (int j = 0; j < col; j++)
                {
                    if (j < _m) newMatrix[i, j] = matrix[i, j];
                    else newMatrix[i, j] = rnd.Next(10, 99);
                }
            return newMatrix;
        }

        public MyMatrix ChangeLineNumber(int line)
        {
            Random rnd = new Random();
            MyMatrix newMatrix = new MyMatrix(line, _m);

            if (line <= _n)
            {
                for (int i = 0; i < line; i++)
                    for (int j = 0; j < _m; j++)
                        newMatrix[i, j] = matrix[i, j];
            }
            else
            {
                for (int i = 0; i < line; i++)
                    for (int j = 0; j < _m; j++)
                    {
                        if (i < _n) 
                            newMatrix[i, j] = matrix[i, j];
                        else
                            newMatrix[i, j] = rnd.Next(10, 99);

                    }
            }
            return newMatrix;
        }

        private int this[int i, int j]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }

        private int N
        {
            set
            {
                if (value > 0)
                    _n = value;
                else
                    Console.WriteLine("Wrong input");
            }
        }
        private int M
        {
            set
            {
                if (value > 0)
                    _m = value;
                else
                    Console.WriteLine("Wrong input");
            }
        }
    }
}
