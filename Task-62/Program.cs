// Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07





Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[size, size];

int number = 1;
int i = 0;
int j = 0;

while (number <= size * size)
{
 array[i, j] = number;
 if (i <= j + 1 && i + j < size - 1)
 ++j;
 else if (i < j && i + j >= size - 1)
 ++i;
 else if (i >= j && i + j > size - 1)
 --j;
 else
 --i;
 ++number;
}

PrintArray(array);

void PrintArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]<10){
                Console.Write($"0{array[i, j]} ");
            }
            else Console.Write($"{array[i, j]} ");
            } 
 Console.Write(" ");
        Console.WriteLine("");
    }
}

// int[,] NullArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }


// int[,] SpiralArray(int rows=4, int columns=4)
// {  int number = 1; //int i=0; int j=0;  
//    int[,] matrix = NullArray(rows, columns); 
//    matrix[rows,columns] = number; number++;
//    if(matrix[rows,columns]==0 && number <= matrix.GetLength(0)*matrix.GetLength(1)){
//     SpiralArray (rows, columns++);
//     SpiralArray (rows ++, columns);
//     SpiralArray (rows , columns --);
//     SpiralArray (rows++ , columns);
//    }
//    return matrix;
// }

// void PrintArray(int[,] input) {
//     for (int i = 0; i < input.GetLength(0); i++)
//     {
//         for (int j = 0; j < input.GetLength(1); j++)
//         {
//             Console.Write(input[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = SpiralArray(4,4);
// SpiralArray(4,4);
// PrintArray(matrix);


