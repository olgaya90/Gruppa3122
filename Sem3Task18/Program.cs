//===================================================================================================
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//===================================================================================================
//чтение данных из консоли
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int num = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return num;

}
string QuterBorderAsk(int numQuter)
{
    if (numQuter == 1)
        return "x>0 y>0";
    if (numQuter == 2)
        return "x<0 y>0";
    if (numQuter == 3)
        return "x<0 y<0";
    if (numQuter == 4)
        return "x>0 y<0";
    return "";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("введите номер четверти: ");


string res = QuterBorderAsk(num);

PrintResult(res);
