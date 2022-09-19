//=====================================================================
// # 35 Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
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

//универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBoreder, int topBorder)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    int[] array = new int[num];

    if (downBoreder < topBorder)
    {
        // заполняем массив
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = numSintezator.Next(downBoreder, topBorder + 1);
        }
    }

    //возвращаем результат
    return array;
}

int CountElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] > 10) && (array[i] < 99))
            count++;
    }
    return count;
}

//печатаем одномерный массив
void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    {
        Console.WriteLine(array[array.Length - 1]);
    }
}
//метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] array = FillArray(123, 1, 1000);
Print1DArray(array);
PrintResult("В массиве " + CountElem(array) + "элементов в отрезке [10,99]");
