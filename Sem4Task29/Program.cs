//=====================================================================
// Напишите программу, которая выводит массив из 8
//элементов и выводит их на экран.
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


int [] GenArray(int arrLen)
{
    int [] array = new int[arrLen];
    Random ren = new Random();
    for (int i=0; i<arrLen; i++)
    {
        array[i] = ren.Next();
    }
    return array;
}

//метод вывода результата
void PrintArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]+ ", ");
    }
    {
        Console.WriteLine(array[array.Length-1]);
    }
}

int arrLen = ReadData("Введите длину массива:");
int[] array = GenArray(arrLen);
PrintArray(array);

PrintArray(GenArray(ReadData("Введите число ")));


