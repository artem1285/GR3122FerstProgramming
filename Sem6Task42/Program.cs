//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// вариант константина
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, string data) // разбили его на две части
{
    Console.WriteLine(prefix + data); // сначала выводим prefix + а потом данные data
}
// вычисление
string DecToBin(int number)
{
    string binNumber = "";

    while (number > 0)
    {
        binNumber = number % 2 + binNumber; // остаток от делния на 2 и прибавляет переменную
        number = number / 2; // само число делит на 2
    }

    return binNumber; // коргда вычилении ничего не остается, возвращаем результат 
}
 PrintResult("Исходное число в бинарном формате:", DecToBin(inputNumber)); // сначала указать сообщение и через , значение переменной