//=============================================================================================
// #13 Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// ============================================================================================


Console.WriteLine("Введите число");
String? inputLineB = Console.ReadLine();
int inputNumberB = 0;
int Lenght = 0;
inputNumberB = int.Parse(inputLineB);

if (inputNumberB.Lenght >= 3)
{
char[] charArray = inputNumberB.ToString().ToCharArray();
Console.WriteLine(charArray[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}




