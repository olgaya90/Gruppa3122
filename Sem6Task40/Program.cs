//===================================================================================================
// # 39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
//===================================================================================================
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

// заполняем массив
bool TrgTest(int numA, int numB, int numC)
{
    bool res = false;
    //return (a + b > c) && (a + c > b) && (b + c > a);
    if (numA + numB > numC && numA + numC > numB && numC + numB > numA)
    {
        res = true;
    }

    return res;
}

int numA = ReadData("Введите длину стороны A: ");
int numB = ReadData("Введите длину стороны B: ");
int numC = ReadData("Введите длину стороны C: ");
bool res = TrgTest(numA, numB, numC);
Console.WriteLine(res);


//PrintResult(TrgTest(a, b, c) ? "Такой треугольник может быть" : "Такого треугольника не может быть");