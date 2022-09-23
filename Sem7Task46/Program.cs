//==================================================================================
//№ 46 Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//===================================================================================
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}

//универсальный метод генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColum, int downBoreder, int topBorder)
{
    //Генератор случайных чисел
    System.Random rand = new System.Random();
    //Создаем массив
    int[,] array2D = new int[countRow, countColum];

    //   0 1 2 3
    // 0  x 
    // 1       y
    // 2

    // заполняем массив
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            array2D[i, j] = rand.Next(downBoreder, topBorder + 1);
        }

    }

    //возвращаем результат
    return array2D;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// Печать двумерного массива цветом
void Ptint2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write($"{matr[i, j]}\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");

int[,] arr2D = Fill2DArray(row, column, 1, 100);
Ptint2DArrayColored(arr2D);