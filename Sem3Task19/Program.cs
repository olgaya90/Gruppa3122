//===================================================================================================
// Напишите программу, которая принимает на вход пятизначное число и проверяет,является ли оно палиндромом.
//===================================================================================================
//чтение данных из консоли

//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberB = int.Parse(Console.ReadLine() ?? "0");
    return numberB;
    //возвращаем значение
}


bool TestPolin(int numberB)
{
    if (((numberB / 10000) == (numberB % 10)) && (numberB / 1000) % 10 == ((numberB / 10) % 10))
    {
        return true;
    }
    else
    {
        return false;
    }
    Console.WriteLine("введите число");
    return false;

}

void PrintResult(bool res)
{
    if (res)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
        Console.WriteLine("Число не является палиндромом");

}

int numberB = ReadData("введите число:");
bool res = TestPolin(numberB);
PrintResult(res);














