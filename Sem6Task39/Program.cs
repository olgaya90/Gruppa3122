//===================================================================================================
// # 39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
//===================================================================================================

// заполняем массив
int[] GenArray(int arrLength, int downBoreder, int topBorder)
{
    int[] arr = new int[arrLength];
    Random ren = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ren.Next(downBoreder, topBorder + 1);
    }
    return arr;
}

//  печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// метод разворота массива и создание нового массива
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}

// метод разворота массива и создание нового массива
int[] SwapArray(int[] arr)
{
    int bufElem = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        bufElem = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i]= bufElem;
    }    
    return arr;
}

int[]arr = GenArray(20,1,100);
Console.WriteLine("Исходный массив");
PrintArray(arr);

int[] coppyArray = SwapNewArray(arr);
Console.WriteLine("Новый перевернутый массив");
PrintArray(coppyArray);
Console.WriteLine("Исходный массив");
PrintArray(arr);

arr = SwapArray(arr);
Console.WriteLine("Перевернутый исходный массив");
PrintArray(arr);