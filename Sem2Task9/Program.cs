// ==================================================================================
// #9 Напишите программу, которая выводитслучайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.
// ===================================================================================

void MyVariant()
{
    Console.WriteLine( "Метод 1" );
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)

    //Вариант 1
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void Variant()
{
    // Вариант2
    Console.WriteLine( "Метод 2" );
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)

        Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void charVariant()
{

    // Вариант char
    Console.WriteLine( "Метод 3" );
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(charArray[0] > charArray[1] ? charArray[0] : charArray[1]);
}

MyVariant();
