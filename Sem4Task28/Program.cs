//================================================================
// # 28 Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
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


long MultA(int numA)
{
    int i = 1;
    long sum = 1;
    while (i <= numA)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}


int numA = ReadData("Введите число: ");

long res1 = MultA(numA);


PrintResult("Произведение чисел равно: " + res1);
