//===================================================================================================
// Напишите программу, которая принимает на вход пятизначное число и проверяет,является ли оно палиндромом.
//===================================================================================================
//чтение данных из консоли

int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int numberB = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return numberB;



}
bool TestPolin(int numberB, int rev, int Count)
{
    rev = 0;
    Count = 0;
    while (numberB > 9999 && numberB < 100000)
    {
        numberB = numberB / 10;
        rev = rev * 10 + numberB % 10;
        Count++;
    }
    Console.WriteLine(Count);
    if (numberB == rev)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        numberB = numberB * 10 + numberB % 10;
        if (rev == numberB)
            Console.WriteLine("Число является палиндромом");
        else
            Console.WriteLine("Число не является палиндромом");

    }




}
Console.ReadLine();













