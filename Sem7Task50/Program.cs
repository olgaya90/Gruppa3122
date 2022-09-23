//==================================================================================
//№ 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
//===================================================================================
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

// Печать результата
void PrintResult(string prefix, string data)
{
    if (data.Equals("-1"))
    {
        Console.WriteLine("Искомый элемент отсутствует");
    }
    else
    {
        Console.WriteLine(prefix + data);
    }
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
// Ищем элемент по индексам
int FindElem(int x, int y, int[,] arr2D)
{
    if (x < arr2D.GetLength(0) && y < arr2D.GetLength(1))
    {

        return arr2D[x, y];
    }
    else
    {
        return -1;
    }
}

int m = ReadData("Введите количество столбцов M: ");
int n = ReadData("Введите количество строк N: ");
int[,] arr2D = new int[m, n];
Fill2DArray(arr2D, 1, 9);
Print2DArray(arr2D);

int x = ReadData("Введите искомый столбец: ");
int y = ReadData("Введите искомую строку: ");

PrintResult("Искомый элемент: ", FindElem(x, y, arr2D).ToString());




