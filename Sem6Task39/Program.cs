// Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// генерация массива
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печать массива
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

// Метод разворота массива с созданием ового массива
int[] SwopNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}

// М который будет без создания новго массива
int[] SwopArray(int[] arr)
{
int bufElement = 0;

    for (int i = 0; i < arr.Length; i++)
 {
    bufElement = arr[arr.Length/2- i];
    arr[arr.Length- 1 - i] = arr [i];
    arr [i] = bufElement;
 }
    return arr;
}

int [] arr = GenArray (20,1,100);
Console.WriteLine ("Исходный массив: ");
PrintArray (arr);
int [] copyArray = SwopNewArray(arr);
Console.WriteLine ("Новый перевернутый массив: ");
PrintArray (copyArray);
Console.WriteLine ("Исходный массив: ");
PrintArray (arr);
arr = SwopArray (arr);
Console.WriteLine ("Перевернутый исходный массив: ");
PrintArray (arr);