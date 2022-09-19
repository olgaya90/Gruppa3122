//=====================================================================
// # 31 Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
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

int[] NegotivPositivSums(int[] array)
{
    int[] sums = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sums[0] += array[i];
        }
        else
        {
            sums[1] += array[i];
        }
    }
    return sums;
}

//метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLenght = ReadData("Введите длину массива: ");
int downBoreder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLenght, downBoreder, topBorder);
Print1DArray(inputArray);
int[] sumArray = NegotivPositivSums(inputArray);

PrintResult("Сумма >0:  " +sumArray[0] + "Сумма   <0: " + sumArray[1]);
