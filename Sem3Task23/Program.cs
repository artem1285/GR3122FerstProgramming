//=============================
//Напишите программу, 
//которая на вход принимает число Н и выдает таблицу кубов, чисел от 1 до N.
//======================
int ReadData(string line)
{
    // выводим сообщение
Console.WriteLine(line);
    //считываем число
int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
return number;
}
string LineNumbers(int numberN,int pow) // число от пользователя
{
int i = 1; // переменная с числом, от него будет начинаться вывод
string outline = string.Empty;
while (i < numberN)
{
 outline = outline + Math.Pow(i,pow) + "\t"; // возвели в степень и передали как параметр int pow. табуляция \t - она выровит что бы числа были дркг под другом
 ++i;
}
outline = outline + i + Math.Pow(numberN,pow);
return outline;
}
void PrintResult(string line)
{
Console.WriteLine(line);
}
int num = ReadData("Введите число N: "); // просим ввести число
PrintResult(LineNumbers(num,1)); // вывод верхних чисел
PrintResult(LineNumbers(num,3)); //вывод нижних чисел