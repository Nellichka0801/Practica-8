//  Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] input) {
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1)
            Console.Write(", ");
        }
        Console.WriteLine();
    }
}

int[,] ProductOfMatrices (int[,] array, int[,] newArray)
{
    int[,] matrix= new int[2,2];
    
    for (int i = 0; i < array.GetLength(0); i++)     
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
          for (int k = 0; k < array.GetLength(1); k++) {
            matrix[i, j] = matrix[i, j] + (array[i, k] * newArray[k, j]); 
            }
        
        }    
    }
    return matrix;
}

Console.WriteLine("Массив 1");
int[,] array = CreateArray(2, 2);
PrintArray(array);
Console.WriteLine("Массив 2");
int[,] newArray = CreateArray(2, 2);
PrintArray(newArray);
Console.WriteLine("Произведеение 2 ух массивов");
int[,] matrix = ProductOfMatrices (array, newArray);
PrintArray(matrix);

