//============================================================================================
// # 58 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//============================================================================================
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Печать двумерного массива
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

//  Умножаем две матрицы
int[,] Multi2DArr(int[,] matrA, int[,] matrB)
{
    int[,] matrix = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                matrix[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
    return matrix;
}

int m = ReadData("Введите количество строк первой матрицы: ");
int n = ReadData("Введите количество столбцов первой матрицы: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);

PrintResult("Количество строк второй матрицы: " , n.ToString());
int n1 = ReadData("Введите количество столбцов второй матрицы: ");
int[,] matrix1 = new int[n, n1];

Fill2DArray(matrix1, 1, 9);
Print2DArray(matrix1);

Print2DArray(Multi2DArr(matrix,matrix1));