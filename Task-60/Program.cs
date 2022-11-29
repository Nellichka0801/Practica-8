// Сформируйте трёхмерный массив из неповторяющихся двузначных 
//чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray(int rows, int columns,int page)
{
    var random = new Random();
    int[,,] array = new int[rows, columns, page];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            for (var z = 0; z < page; z++)
            {
                array[i, j, z] = random.Next(1, 10);
            }
           
        }
    }
    return array;
}


void IndexArray(int[,,] input) {
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            for (int z = 0; z < input.GetLength(2); z++) {
                Console.Write($"{input[i, j, z]} {(i, j, z)}");
            if (z != input.GetLength(2) - 1 || j!=input.GetLength(1) - 1)
            Console.Write(", ");

            }
            
        }
        Console.WriteLine();
    }
}
int[,,] array = CreateArray(2, 2, 2);
IndexArray(array);

