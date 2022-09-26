//========================================================================================
//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен наименьший элемент массива.
// Печать двумерного массива
//=========================================================================================

void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void FindMin(int[,] arr, ref int x, ref int y)
{
    int min = arr[0, 0];
    x = 0; y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] CreateArr(int[,] arr, int x, int y)
{
    int k = 0; int m = 0;
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == x)
        {
        }
        else
        {
            m = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == y)
                {
                }
                else
                {
                    outArr[k, m] = arr[i, j];
                    m++;
                }
            }
            k++;
        }
    }
    return outArr;
}

int[,] array2D = new int[4, 4];
Fill2DArray(array2D, 0, 9);
Print2DArray(array2D);
int x = -1;
int y = -1;
FindMin(array2D, ref x, ref y);
int[,] outArr = CreateArr(array2D, x, y);
Print2DArray(outArr);


// // Создает двумерный массив размером m×n
// int[,] GenerateArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     Random rand = new Random();
//     int[,] array = new int[countRow, countColumn];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rand.Next(topBorder, downBorder);
//         }
//     }
//     return array;
// }

// // Возвращает частотный словарь элементов двумерного массива
// SortedDictionary<int, int> CountDictionary(int[,] array)
// {
//     SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             if (dict.ContainsKey(array[j, i]))
//                 dict[array[j, i]] = dict[array[j, i]] + 1;
//             else
//                 dict.Add(array[j, i], 1);
//         }
//     }
//     return dict;
// }

// // вывод двумерного массива
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");

//         }
//         Console.WriteLine();
//     }
// }

// // вывод ответа
// void PrintAnswer(string answer, string title = "")
// {
//     Console.WriteLine("{0} -> {1}", title, answer);
// }



// int[,] array = GenerateArray(5, 5, 0, 10);

// Console.WriteLine("\n------- Исходная матрица -------\n");
// Print2DArray(array);

// SortedDictionary<int, int> dict = CountDictionary(array);

// PrintAnswer("Сколько повторений\n", "\nЧисло");
// foreach (KeyValuePair<int, int> kvp in dict)
// {
//     PrintAnswer(kvp.Value.ToString(), kvp.Key.ToString());
// }