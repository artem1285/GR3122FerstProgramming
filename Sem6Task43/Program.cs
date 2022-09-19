// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// печать результата
void PrintData (string prefix, string data) //разбили на две части вывод в консоль
{
     Console.WriteLine(prefix + data); //сначала выводим prefix + а потом данные data
// Поиск точки пересечения двух прямых
int[] PointFind (int k1, int b1, int k2, int b2)
{
    int[] outArr = new int[2];
    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;
    outArr[0] = x;
    outArr[1] = y;
    return outArr;
}
//Ввод значения k1, b1, k2, b2
int k1 =ReadData("Введите значение k1:");
int b1 =ReadData("Введите значение b1:");
int k2 =ReadData("Введите значение k2:");
int b2 =ReadData("Введите значение b2:");

//Вычисляем точку пересечения
int[]Point = PointFind (k1, b1, k2, b2);
//Выводим на экран координату точки пересечения
PrintData ("Точка пересечения двух прямых: ", $"({Point[0]};{Point[1]})");

// но почему то не получается то что надо..