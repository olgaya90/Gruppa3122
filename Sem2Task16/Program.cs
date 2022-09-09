//чтение данных из консоли
int ReadData(string line)
{
    //вводи сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возврвщаем значение
    return number;
}

// Тест на квадрат
bool SqrTest(int ferstnum, int secondnum)
{   
    if (ferstnum == secondnum * secondnum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//выводим данные вычисления
void PrintData(int ferstnum, int secondnum)
{
    if (SqrTest(ferstnum, secondnum))
    {
        Console.WriteLine("Число " + ferstnum + "квадрат числа " + secondnum);
    }
    else
    {
        Console.WriteLine("Число " + ferstnum + "не квадрат числа " + secondnum);
    }
}




int num1 = ReadData("введите число 1");
int num2 = ReadData("введите число 2");

PrintData(num1, num2);
PrintData(num2, num1);

