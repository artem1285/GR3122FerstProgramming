//=============================
//Напишите программу, которая на вход принимает 
//пятизначное число и проверяет, является ли оно полиндромом. 
//======================
int ReadData(string line) // получаем данные 
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
bool TestPalin(int number) // проверяет число на полидром
{
    if ((number / 10000 == number % 10) && ((number / 1000) % 10) == (number / 10) % 10)
    {
        return true;  // истина, т.е. если число будет полидром, значит выведится true
    }
    else
    {
        return false; // ложь, если число не будет полидром, значит выведится false
    }
}
void PrintPalin(bool line) // печатаем в консоли
{
    Console.WriteLine(line);

}

// собираем программу,т.е. выше мы ее созади, тут сделали короткий вариант. На сколько я понял
int number = ReadData("введите число: "); // просит ввести число
bool result = TestPalin (number); // ввод числа
PrintPalin (result); // вывод результата



