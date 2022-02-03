namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(4, 6);
            matrix.InitializeByRandom();
            matrix.Show();

            matrix.ShowAllMatrix();

            MyMatrix newMatrix1 = matrix.ChangeColumnNumber(8);
            newMatrix1.Show();
            MyMatrix newMatrix2 = matrix.ChangeLineNumber(6);
            newMatrix2.Show();
        }
    }
}
