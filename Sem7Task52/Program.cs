//==============================================================================================================
// #50 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//==============================================================================================================
// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] arr2D, int min, int max)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Находим среднее арифметическое по столбцам
double[] Count(int[,] arr2D)
{
    double[] arr = new double[arr2D.GetLength(1)];

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr[j] = arr[j] + arr2D[i, j];
        }
    }
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = arr[k] / (double) arr2D.Length;
    }
    return arr;
}

// печатаем массив
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");
int[,] arr2D = new int[m, n];

Fill2DArray(arr2D, 1, 9);
Print2DArray(arr2D);

PrintArray(Count(arr2D));

