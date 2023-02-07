﻿using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columElements[col];
                }
            }
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    sum += matrix[row, col + count];
                    count++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
