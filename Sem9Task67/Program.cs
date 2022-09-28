//============================================================================================
// # 67 примает на вход число и возвращает сумму числа
//============================================================================================
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Вывод в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}


//рекурентная функция
int RecSumDig(int num)
{
    if (num /10  == 0) return num;
    return RecSumDig(num / 10) + num % 10;;
}

int numN = ReadData("Введите число: ");
int sum = RecSumDig(numN);
PrintResult(sum);
