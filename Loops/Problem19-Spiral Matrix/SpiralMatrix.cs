using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int col = n, row = n-1;
        int elements = 1;
        int indexCol = -1;
        int indexRow = 0;
        while (col > 0 || row > 0)
        {
            indexCol++;
            for (int i = 0; i < col; i++)
            {
                matrix[indexCol, indexRow] = elements;
                elements++;
                indexCol++;
            }
            indexCol--;
            col--;
            for (int i = 0; i < row; i++)
            {
                indexRow++;
                matrix[indexCol, indexRow] = elements;
                elements++;
            }
            row--;
            for (int i = 0; i < col; i++)
            {
                indexCol--;
                matrix[indexCol, indexRow] = elements;
                elements++;
            }
            col--;
            for (int i = 0; i < row; i++)
            {
                indexRow--;
                matrix[indexCol, indexRow] = elements;
                elements++;
            }
            row--;
        }
        for (int i = 0; i < n; i++)
        {
            for (int z = 0; z < n; z++)
            {    
                Console.Write(matrix[z,i] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }   

    }
}
