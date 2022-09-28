// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Функция Аккермана
int funcAck(int m, int n)
{
     if (m == 0) return n + 1;
     if (n == 0 && m>0) return funcAck(m - 1, 1);  
    
    return funcAck(m - 1, funcAck(m, n - 1));
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

PrintResult(funcAck(m, n) == -1 ? "Введите числа!" : funcAck(m, n).ToString());