//=============================================================================================
// #13 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// ============================================================================================



String? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputdayofWeek = int.Parse(inputLine);
    
    string[] dayofWeek = new string[7];
    dayofWeek[0] = "Понедельник";
    dayofWeek[1] = "вторник";
    dayofWeek[2] = "среда";
    dayofWeek[3] = "четверг";
    dayofWeek[4] = "пятница";
    dayofWeek[5] = "суббота";
    dayofWeek[6] = "воскресенье";

if(inputdayofWeek == 6 || inputdayofWeek == 5)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine(dayofWeek[inputdayofWeek-1]);
}
    
}
