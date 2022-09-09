//=============================
//Напишите программу, которая на вход принимает 
//число n и выдает таблицу квадратов чисел от 1 до n. 
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
string LineNumbers(int numberN,int pow)
{
int i = 1;
string outline = string.Empty;
while (i < numberN)
{
 outline = outline + Math.Pow(i,pow) + "\t";
 ++i;
}
outline = outline + i + Math.Pow(numberN,pow);
return outline;
}
void PrintResult(string line)
{
Console.WriteLine(line);
}
int num = ReadData("Введите число N: ");
PrintResult(LineNumbers(num,1));
PrintResult(LineNumbers(num,2));