//=====================================================================
// # 34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
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


int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        
            if (array[i] % 2 == 0)
                count++;
    
       
    }
    return count;
}


//метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] array = FillArray(50, 100, 1000);
int downBoreder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");


PrintArray(array);
PrintResult("В массиве " + EvenCount(array) +  "четных элементов" );
