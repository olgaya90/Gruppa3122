//=====================================================================
// # 31 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
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
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    {
        Console.WriteLine(array[array.Length - 1]);
    }
}

int EvenSumPos(int[] array)
{
    int sums = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sums += array[i];
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
PrintArray(inputArray);
int sumArray = EvenSumPos(inputArray);

PrintResult("Сумма четных элементов равна:"  + sumArray);
