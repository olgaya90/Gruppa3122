//============================================================================================================
// # 1 Напишите пргограмму, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго
//============================================================================================================

String? inputLineA = Console.ReadLine();
String? inputLineB = Console.ReadLine();
if (inputLineA != null&&inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    bool outResult = (inputNumberA * inputNumberA==inputNumberB);

    Console.WriteLine(outResult);
}
