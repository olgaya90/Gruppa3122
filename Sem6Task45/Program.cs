//=====================================================================
// # 45 Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью поэлементного копирования.
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

int[] CoppyArray(int[] array)
{
    int[] outArray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        outArray[i] = array[i];
    }
    return outArray;
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

int[] array = FillArray(50,1,1000);
PrintArray(array);

PrintArray(CoppyArray(array));

