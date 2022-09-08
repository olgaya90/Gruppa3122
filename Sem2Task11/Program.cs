//============================================================================
// # 11 Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру этого числа.
// ===========================================================================
System.Random numberGenerator = new System.Random();

int numberB = numberGenerator.Next(100, 1000);

Console.WriteLine(numberB);

int numberA = numberB / 100;
int numberC = numberB % 10;


Console.Write(numberA );
Console.Write(numberC );
