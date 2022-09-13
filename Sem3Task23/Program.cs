//========================================================================================
// # 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
//========================================================================================
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;

}

string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t ";
        ++i;
    }
    outLine = outLine + numberN;
    return outLine;

}

string LineSqer(int numberN)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + i * i * i+ " \t";
        ++i;
    }
    outLine = outLine + numberN * numberN * numberN;
    return outLine;

}
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("введите число N:");
string LineTop = LineNumbers(num,1);
string LineDown = LineNumbers(num,3);

PrintResult(LineTop);
PrintResult(LineDown);
