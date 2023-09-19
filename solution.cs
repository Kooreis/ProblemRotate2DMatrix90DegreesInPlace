Here is a C# console application that rotates a 2D matrix by 90 degrees in-place:

```C#
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        RotateMatrix(matrix);
        PrintMatrix(matrix);
    }

    static void RotateMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = i; j < n - i - 1; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[n - 1 - j, i];
                matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j];
                matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];
                matrix[j, n - 1 - i] = temp;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
```

This program first defines a 2D matrix, then calls the `RotateMatrix` method to rotate the matrix by 90 degrees in-place. After the rotation, it calls the `PrintMatrix` method to print the rotated matrix to the console.