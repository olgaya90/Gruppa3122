//===================================================================================================
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой находится эта точка.
//===================================================================================================
//чтение данных из консоли
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;

}

int QuterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

    return -1;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("введите координаты x:");
int y = ReadData("введите координаты y:");

int res = QuterTest(x, y);

PrintResult("точка находится в четверти №:" + res);
