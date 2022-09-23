//==================================================================================
//№ 51 Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д
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

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
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

// Вычисляем сумму
int DiagSum(int[,] arr2D)
{
    int sum = 0;
    int len = arr2D.GetLength(0) > arr2D.GetLength(1) ? (arr2D.GetLength(0)) : (arr2D.GetLength(1));
    for (int i = 0; i < len; i++)
    {
        sum = sum + arr2D[i, i];
    }
    return sum;
}

int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");

int[,] arr2D = new int[m, n];
Fill2DArray(arr2D, 1, 9);
Print2DArray(arr2D);


PrintResult("Сумма главной диагонали: ", DiagSum(arr2D).ToString());


