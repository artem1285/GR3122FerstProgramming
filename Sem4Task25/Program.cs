// Напишите цикл, который на вход принимает два 
//числа А и В и возводит число А в натуральную степень В.
int ReadData(string line) // получаем данные,  на какое число в какую степень возводить
{
    // выводим сообщение
Console.WriteLine(line);
    //считываем число
int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
return number;
}
// степень. Указываем два числа. Так как результат возведения в степень получится длинным, указваем long
long Pow (int numА, int numB) 
{
long res = 1; // создаем переменную, 
for (int i = 0; i < numB; i++) // тут * столько раз сколько число В
res = res * numА;
return res; // возвращаем результат переменной long res
}
void PrintData (long line)
{
Console.WriteLine(line);
}
// программу 
int numА = ReadData ("Введите число: ");
int numB = ReadData ("Введите число для возведения в степень: ");
long numPow = Pow (numА, numB);
PrintData (numPow);
