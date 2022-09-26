// 
int ReadData(string line) // получаем число А 
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
// метод вывода результата, выводит в консоль
int CalculateDigitsString(int num)
{
    string numString = num.ToString();
    return numString.Length;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// вариант с логарифомом
int CalculateDigits(int num)
{
    return (int)(Math.Log10(num) + 1);
}
 // вариент препод - потом можно разкомментировать
// int DbgitCount(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += 1; 
//         num = num / 10;
//     }
//     return num;
// }

int number = ReadData("введите число: ");
int numberOfDigits = CalculateDigits(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);

numberOfDigits = CalculateDigitsString(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);

numberOfDigits = CalculateDigits(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);