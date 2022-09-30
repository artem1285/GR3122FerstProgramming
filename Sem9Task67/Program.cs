// Напишите программу кторая на вход 
//принимает число N и возвращает сумму его чисел.
int ReadData(string line)
    {
        Console.Write(line);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    // Метод, принимает строку, выводит в консоль
    void PrintResult(string line)
    {
        Console.WriteLine(line);
    }
    int SumDigit(int num)
{
    if (num / 10 == 0)
        return num;
    return SumDigit(num / 10) + num % 10;
}

//программа 
int number = ReadData("Введите число: ");
int sum = SumDigit(number); // передаем этому методу число
PrintResult("Сумма цифр в числе: "+sum);