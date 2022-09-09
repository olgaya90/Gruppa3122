//=============================================================================================
// #13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ============================================================================================

void Variant1()
{
    Console.WriteLine("Введите трехзначное число");
    String? inputLineB = Console.ReadLine();
    int inputNumberB = 0;
    inputNumberB = int.Parse(inputLineB);
    
    char[] charArray = inputNumberB.ToString().ToCharArray();
    Console.WriteLine(charArray.Length == 3 ? (charArray[2]) : ("Третьей цифры нет"));
}


void Variant2()
{
    Console.WriteLine("Введите трехзначное число");
    String? inputLineB = Console.ReadLine();
    int inputNumberB = 0;
    inputNumberB = int.Parse(inputLineB);
    int result = 0;
    int leght = inputNumberB;
    while (leght >= 1000) leght = leght / 10;
    result = inputNumberB < 100 ? -1 : leght % 10;

    Console.WriteLine(result != -1 ? result : "третьей цифры нет");
}




 Variant1();
//Variant2();