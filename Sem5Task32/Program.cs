//=====================================================================
// # 31 Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
//=====================================================================
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;

}


int[] InversArray(int arrayLength, int downBoreder, int topBorder)
{
    int[] array = new int[arrayLength];
    Random ren = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ren.Next(downBoreder, topBorder + 1);
    }
    return array;
}

//  печатаем массив
void PrintArray(int[] array)
{
    Console.Write("[" + array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}

//метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// изменяем массив
int[] ChangeArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int arrayLength = ReadData("Введите длину массива: ");
int downBoreder = ReadData("Введите минимальное значение: ");
int topBorder = ReadData("Введите максимальное значение: ");

int[] array = InversArray(arrayLength, downBoreder , topBorder);
PrintArray(array);
PrintArray(ChangeArr(array));

