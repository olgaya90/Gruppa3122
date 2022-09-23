//==================================================================================
//№ 48 Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
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
int[,] Fill2DArrMN(int countM, int countN)
{
    
    //Создаем массив
    int[,] arr2D = new int[countM, countN];

    
    // заполняем массив
    for (int i = 0; i < countM; i++)
    {
        for (int j = 0; j < countN; j++)
        {
            arr2D[i, j] = i+j;
        }

    }

    //возвращаем результат
    return arr2D;
}


// Печать двумерного массива цветом
void Ptint2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int M = ReadData("Введите количество строк");
int N = ReadData("Введите количество столбцов");

int[,] arr2D = Fill2DArrMN(M,N);
Ptint2DArray(arr2D);
