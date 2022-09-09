// ==================================
// Напишите программу, которая на вход принимает 2 числа, 
//и проверяет является ли одно число квадратом другого.
// =========================
int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine()?? "0");
    // возвращаем значение
    return number;
}
//тест на квадрат. Является ли первое число квадратом или нет
bool SqrTest(int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}
//вывод данных
void PrintData(int firstNum, int secondNum)
{
    if (SqrTest(firstNum, secondNum))
    {
        Console.WriteLine("Число" + firstNum + "квадрат числа"  + secondNum);
    }
    else
    {
        Console.WriteLine("Число" + firstNum + "не квадрат числа" + secondNum);
    }
}
int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");
PrintData(num1, num2);
PrintData(num2, num1);