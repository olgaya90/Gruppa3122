//============================================================================================================
// # 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//============================================================================================================

String? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    int count = 2;
    while (count <= inputNumberN - 2)
    {
       Console.Write(count);
       Console.Write(",");

       count = count + 2;
    }   
    Console.Write(count);
}    
