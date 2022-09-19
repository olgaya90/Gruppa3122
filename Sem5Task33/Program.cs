//=====================================================================
// # 33 Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
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

//заполняем массив
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
int FindElem(int[] array, int elm)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elm)
        {
            return i; 
        }
    }
    return -1;
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

// вывод ответа
void PrintAnswer(int index)
{
    Console.WriteLine(index>0 ? ("Элемент найден на позиции:"+index) : "Нет");
}

int arrayLength = ReadData("Введите длину массива: ");
int downBoreder = ReadData("Введите минимальное значение: ");
int topBorder = ReadData("Введите максимальное значение: ");

int[] array = InversArray(arrayLength, downBoreder, topBorder);
PrintArray(array);
int elm = ReadData("Введите искомое значение: ");
PrintAnswer(FindElem(array, elm));

