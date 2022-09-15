//=========================================================
// #24 Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А
//=========================================================
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

int VarisntSimple(int numA)
{
    int sumOfnumbers = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfnumbers += i;
    }
    return sumOfnumbers;
}

int VarianSunGause(int numA)
{
    int sumOfnumbers = 0;
    sumOfnumbers = ((1+ numA * numA) / 2);
    return sumOfnumbers;
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
Console.WriteLine(DateTime.Now - d1);
int res1= VarisntSimple(numberA);

DateTime d2 = DateTime.Now;
Console.WriteLine(DateTime.Now - d2);
int res2= VarisntSimple(numberA);
PrintResult("Сумма чисел от 1 до A равна(простой метод): " + res1);
PrintResult("Сумма чисел от 1 до A равна(метод Гауса): " + res2);
