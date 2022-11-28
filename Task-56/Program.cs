// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей 
//суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// наименьшей суммой элементов: 1 строка

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
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

int ArithmeticMeanOfColumns (int[,] array)
{
    int stringMinSum = 0;
    int sum = 0;
    int  minSum = Int32.MaxValue;
    

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
          sum = sum + array[i,j];
        }
        
        if (minSum > sum) {
            minSum = sum; stringMinSum = i+1;
        } 
        sum=0;
        
    }
    return stringMinSum;
}

var array = CreateArray(4, 4);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Наименьшая сумма элементов в строке № " + ArithmeticMeanOfColumns (array));


