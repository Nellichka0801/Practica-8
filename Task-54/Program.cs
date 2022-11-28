// Задайте двумерный массив. Напишите программу, которая 
////упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] PositionOfDigitsByReducing(int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1); z++){
                if (array[i, j] >= array[i, z])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, z];
                    array[i, z] = temp;
                } 
            }
        }
    }
    return array;
}
 
int[,] array = CreateArray(4, 4);
PrintArray(array);
Console.WriteLine("Новый массив");
int[,] newArray = PositionOfDigitsByReducing(array);
PrintArray(newArray);

