//=====================================================================================
// # 44 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
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

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}


string FibNum(int num)
{
    string res = " ";
    int ferst = 0;
    int last = 1;
    int buf = 0;
    for (int i =0; i<num; i++)
    {
        res = res+" " +last;
        buf = ferst+last;
        ferst=last;
        last=buf;
    }
    return res;
}

int num = ReadData("Введите число Фибоначчи: ");
string res = FibNum(num);
Console.WriteLine(res);

//PrintResult("Числа фибоначчи: ", FibNum(ReadData("Введите количество чисел фибоначчи: ")));