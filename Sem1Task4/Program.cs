//============================================================================================================
// # 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//============================================================================================================

String? inputLineA = Console.ReadLine();
String? inputLineB = Console.ReadLine();
String? inputLineC = Console.ReadLine();

int inputNumberA = int.Parse(inputLineA);
int inputNumberB = int.Parse(inputLineB);
int inputNumberC = int.Parse(inputLineC);

if (inputLineA != null && inputLineB != null && inputLineB != null)
{
    if ((inputNumberA > inputNumberB) && (inputNumberA > inputNumberC))
    {        
        Console.Write("max = ");
        Console.Write(inputNumberA);
    }   
    if ((inputNumberB > inputNumberC) && (inputNumberB > inputNumberA))
    {
        Console.Write("max = ");
        Console.Write(inputNumberB);
    }
    if ((inputNumberC > inputNumberB) && (inputNumberC > inputNumberA))
    {
        Console.Write("max = ");
        Console.Write(inputNumberC);
    }          
}