//   Напишите программу, которая принимает 
//на вход число и выдает сумму цифр в этом числе
int ReadData(string line) // получаем данные 
{
    // выводим сообщение
 Console.WriteLine(line);
    //считываем число
int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
return number;
}
// вычисление
int DigitCount(int num)
{
int sum = 0; // переменная которая будет накапливать результат
while (num > 0) // цикл, где наше число будет уменьшаться пока не станет 0, что бы он остановился
{
sum += num % 10; 
 num = num / 10; 
}
return sum; // вывод результата нашего числа
}
// печать результата
void PrintResult(string line)
{
Console.WriteLine(line);
}
// программа 
int num = ReadData("Введите число: ");
int sumDigit = DigitCount(num);
PrintResult("Сумма цифр в числе: " + sumDigit);