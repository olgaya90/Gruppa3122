// //============================================================================================================
// # 2 Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее
//============================================================================================================

String? inputLineA = Console.ReadLine();
String? inputLineB = Console.ReadLine();

int inputNumberA = int.Parse(inputLineA);
int inputNumberB = int.Parse(inputLineB);

if (inputLineA != null && inputLineB != null)
{
    if (inputNumberA > inputNumberB)
    {        
        Console.Write("max = ");
        Console.Write(inputNumberA);
    }    
    else
    {       
       Console.Write("max = ");
       Console.Write(inputNumberB);
    }
}