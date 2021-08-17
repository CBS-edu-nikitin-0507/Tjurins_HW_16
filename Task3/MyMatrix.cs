using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyMatrix
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void PrintMatrix() 
        {
            string[,] matrix = new string[X, Y];

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    matrix[i, j] = "*";
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
