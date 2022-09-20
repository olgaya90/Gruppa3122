//=====================================================================================
// # 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Считаем положительные числа
int Count(int numB)
{
    int res = 0;
    for (int i = 0; i < numB; i++)
    {
        int num = ReadData("Введите количество чисел: ");
        if (num > 0) res++;
    }

    return res;
}

int num = ReadData("Введите количество чисел: ");
int res = Count(num);
Console.WriteLine(res);

//PrintResult("Пользователь ввёл чисел больше ноля: ", Count(ReadData("Введите количество чисел: ")).ToString());


