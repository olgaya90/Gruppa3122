//=====================================================================
// # 37 Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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

int[] Change(int[] array)
{
    int[] outArray = new int [array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        outArray[i] = array[i] * array[array.Length-1 - i];
    }
    return outArray;
}

//печатаем одномерный массив
void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
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

int[] array = FillArray(50,1,1000);
Print1DArray(array);

Print1DArray(Change(array));

