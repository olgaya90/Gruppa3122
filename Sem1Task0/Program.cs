﻿//============================================================================================================
// # 0 Напишите пргограмму, которая на вход принимает число и 
// выдает его квадрат (число умноженное на само себя)
//============================================================================================================

String? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = inputNumber * inputNumber;
    Console.WriteLine(outNumber);
}
