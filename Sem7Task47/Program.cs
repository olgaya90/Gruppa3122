//=============================================================================================
// # 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//==============================================================================================

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


// Заполняем массив случайными вещественными числами
void Fill2DArrayDouble(double[,] arr2D, int min, int max)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = new Random().Next(min, max + 1);
        }

    }
}

//возвращаем результат



ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// Печать двумерного массива цветом
void Ptint2DArrayColored(double[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write($"{arr2D[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}



int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");
double[,] arr2D = new double[m, n];

Fill2DArrayDouble(arr2D, -10, 10);
Ptint2DArrayColored(arr2D);