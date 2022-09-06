//============================================================================================================
// # 3 Напишите программу, которая будет 
// выдавать название дня недели по заданному номеру
//============================================================================================================

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

if(inputdayofWeek>7 || inputdayofWeek<1)
{
    Console.WriteLine("Такого дня нет");
}
else
{
    Console.WriteLine(dayofWeek[inputdayofWeek-1]);
}
    
}
