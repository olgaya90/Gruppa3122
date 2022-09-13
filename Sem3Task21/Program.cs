//=========================================================================================
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
//=========================================================================================
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
double Calculate(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)); ;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}



int x1 = ReadData("введите координаты x1:");
int y1 = ReadData("введите координаты y1:");
int z1 = ReadData("введите координаты z1:");
int x2 = ReadData("введите координаты x2:");
int y2 = ReadData("введите координаты y2:");
int z2 = ReadData("введите координаты z2:");


PrintResult(Math.Round(Calculate(x1, y1,z1, x2, y2,z2), 2).ToString());

