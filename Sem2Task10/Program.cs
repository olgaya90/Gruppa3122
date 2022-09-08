// ========================================================================================
// # 10 Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// =========================================================================================


Console.WriteLine("Введите трехзначное число");
String? inputLineB = Console.ReadLine();
int inputNumberB = 0;
inputNumberB = int.Parse(inputLineB);

char[] charArray = inputNumberB.ToString().ToCharArray();
Console.WriteLine(charArray[1]);



