//====================================================================================================
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//====================================================================================================
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

//
int[] PointFind(int k1, int k2, int b1, int b2)
{
    int[] outArr = new int[2];

    int x = (b1 - b2) / (k1 - k2);
    int y = k1 * x + b1;
    outArr[0] = x;
    outArr[1] = y;
    return outArr;
}

int k1 = ReadData("Введите k1: ");
int b1 = ReadData("Введите b1: ");
int k2 = ReadData("Введите k2: ");
int b2 = ReadData("Введите b2: ");
int[] x = PointFind(k1, b1, k2, b2);
int[] y = PointFind(k1, b1, k2, b2);
PrintResult("Точка пересечения двух прямых: " + (x,y));
