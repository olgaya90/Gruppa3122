//=====================================================================================
// # 42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//=====================================================================================
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


string BinCinvert(int numA)
{
    string res = string.Empty;
    while (numA > 0)
    {
        res = numA % 2 + res;
        numA = numA / 2;
    }
    return res;
}

int numA = ReadData("Введите число: ");
string res = BinCinvert(numA);
Console.WriteLine(res);
