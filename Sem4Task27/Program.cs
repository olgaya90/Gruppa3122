//================================================================
//Напишите программу, которая принимает на вход
//число и выдаёт количество цифр в числе.
//=================================================================
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;

}
//метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}


int numberA = ReadData("Введите число: ");


Console.WriteLine(res1);
int res1 = VarisntSimple(sum);


PrintResult("Количество цифр в числе равно: " + res1);
