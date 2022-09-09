//=============================
//Напишите программу, которая на вход принимает координаты 
//двух точек и находит расстояние между ними в 2D простарнстве.
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
void PrintResult(string line)
{
    Console.WriteLine(line);
}
// расстояние между строками
double Colculite(int х1, int y1, int х2, int y2)
{
    return Math.Sqrt((х2 - х1) * (х2 - х1) + (y2 - y1) * (y2 - y1));
}
// собираем данные
int х1 = ReadData("Введите х1: ");
int y1 = ReadData("Введите х2: ");
int х2 = ReadData("Введите y1: ");
int y2 = ReadData("Введите y1: ");
// выводим результат
PrintResult(Math.Round(Colculite(х1, y1, х2, y2),2).ToString());

// Math.Round округляет число  - само число, и сколько после , надо оставить





// РЕшение Константина
// int ReadData(string line)
// {
//     // выводим сообщение
//     Console.WriteLine(line);
//     //считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // возвращаем значение
//     return number;
// } 

// double ColculateDistanse (int х1, int y1, int х2, int y2)
// {
//   double distanse = Math.Sqrt(Math.Pow ((х2 - х1), 2) + Math.Pow((y2 - y1), 2));
//    return distanse;
// }

// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// int х1 = ReadData("Введите координату х первой точки: ");
// int х2 = ReadData("Введите координату х второй точки: ");
// int y1 = ReadData("Введите координату y первой точки: ");
// int y2 = ReadData("Введите координату y второй точки: ");

// double Result = ColculateDistanse (х1,y1,х2,y2); // взываем метод подсчета

// PrintResult("Расстояние между точками:" + Math.Round (result, 2));
