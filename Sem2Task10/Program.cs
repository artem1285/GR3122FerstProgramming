//=========================================
//Напишите программу, которая на вход принимает 
//трех значное число, и на выходе показывает вторую цифру этого числа.
//===================================== 
string? threeDigitNumder; // глобальная переменная строка, что бы она работала во всех методах

inputNumber(); // это вызов метода
Print();

void inputNumber() // ввод числа
{
    threeDigitNumder = Console.ReadLine();
}

void Print() // 
{
if (threeDigitNumder != null)
{

    if (threeDigitNumder.Length == 3)
    {
        char[] Array = threeDigitNumder.ToCharArray();
                Console.WriteLine(Array[1]);
    }
    else
    {
        Console.WriteLine("число не трехзначное");
    }
}
}