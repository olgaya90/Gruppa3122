//==================================================================================
//№ 49 Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их квадраты.
//===================================================================================
//Чтение данных из консоли
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
}

// // Заполняем массив случайными числами
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

// Делаем квадраты
void Update2DArry(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr2D.GetLength(1); j = j + 2)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr2D[i, j] = (int)Math.Pow(arr2D[i, j], 2);
            }

        }
    }
}

int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");

int[,] arr2D = new int[m, n];
Fill2DArray(arr2D, 10, 99);
Print2DArray(arr2D);
Update2DArry(arr2D);

Console.WriteLine();
Print2DArray(arr2D);


