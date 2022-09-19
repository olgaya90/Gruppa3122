//=====================================================================
// # 38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
//=====================================================================
// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Заполняем массив
double[] FillArray(int arrLength, int maxValue)
{
    double[] array = new double[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = Math.Round((ren.NextDouble() * maxValue),2);
    }
    return array;
}



// разница между макс и мин
double MaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}
// печатаем массив
void PrintArray(double[] array)
{
    Console.Write("[" + array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}
double[] array = FillArray(50, 100);

PrintArray(array);
PrintResult("Разница между max и min = " + MaxMin(array));