// Задайте значения M и N. Напишите программу, которая найдёт все
//натуральные элементы в промежутке от M до N.
// Чтение данных из консоли
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

string RecMN(int m, int n)
{
    if (m >= n)
        return n.ToString();
    return m + " " + RecMN(m + 1, n);
}

// программа
int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

//PrintResult(RecMN(n, m));
PrintResult(m > n ? RecMN(n, m) : RecMN(m, n));
