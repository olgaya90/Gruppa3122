//=========================================================
// #25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
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
void PrintResult(long line)
{
    Console.WriteLine(line);
}

long Pow(int numA, int numB)
{
    long res = 1;
    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }
    return res;
}


int numA = ReadData("Введите числа A: ");
int numB = ReadData("Введите числа B: ");
long res = Pow(numA, numB);
Console.WriteLine(res);




