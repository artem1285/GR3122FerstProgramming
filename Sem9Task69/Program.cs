// Напишите программу которая на вход принимает 2 числа А и В. иВозведите число А в 
//целую степень, В с помощью рекурсии.
// михаил
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// возвращает сумму цифр числа numN
int RecPow(int a, int b)
{
    if(b==1) return a;
    return a*RecPow(a,b-1);
    // или то же, но выглядит так через тернарный оператор
    //  return b == 1 ? a : a * RecPow(a, b - 1);
}
// М кторый вычисляет в цикле 
int NoRecPow(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result = result * num;
    }
    return result;
}

// М который разделяет 

int MyPow(int number, int pow)
{
    if (pow == 2)
    {
        return number * number;
    }
    if (pow == 1)
    {
        return number;
    }

    if (pow % 2 == 0)
    {
        return MyPow(number, pow / 2) * MyPow(number, pow / 2); // делим по полам, потом *
    }
    else
    {
        return MyPow(number, pow / 2) * MyPow(number, pow / 2 + 1); // те числа, кторые не делятся по полам 
    }

}
// Вывод в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}

int a = ReadData("Введите числа А: ");
int b = ReadData("Введите числа B: ");

PrintResult(RecPow(a,b));