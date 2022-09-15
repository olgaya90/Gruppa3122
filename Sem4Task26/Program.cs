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
        sum += 1;
        num = num / 10;
    }
    return sum;
}


int number = ReadData("Введите число: ");
int numberofDigit = DigitCount(number);
PrintResult("Количество цифр в числе равно: " + numberofDigit);
