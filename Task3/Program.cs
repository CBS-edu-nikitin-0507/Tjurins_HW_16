using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix mat = new MyMatrix();

            mat.X = Int32.Parse(Console.ReadLine());
            mat.Y = Int32.Parse(Console.ReadLine());

            //выводит на экран матрицу и производные от нее матрицы разных порядков. - Dont really understand what is производные от нее матрицы разных порядков.
            mat.PrintMatrix();
        }
    }
}
