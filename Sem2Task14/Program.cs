﻿//==================================================================================
// # 14 Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//==================================================================================
int inputNumberA = 0;

// получаем  числo от пользователя

String? inputLineA = Console.ReadLine();
inputNumberA = int.Parse(inputLineA);

// определяем кратность чисел

    bool Result = (inputNumberA % 7 == 0) && (inputNumberA % 23 == 0);

//выводим данные вычисления

    if (Result)
    {
        Console.WriteLine("Число кратно 7 и 23 ");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }


// (inputnumberB % inputnumberA == 0) ? (("Второе число кратно первому"): ("Остаток от деления: + inputNumberB % inputNumberA))



