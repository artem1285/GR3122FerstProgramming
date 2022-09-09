//=============================
//Напишите программу, которая на вход принимает 
//координаты двух точек и выдает расстояние между ними в 3 D  пространстве.
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
double Colculite(int х1, int y1, int z1, int х2, int y2, int z2)
{
    return Math.Sqrt((х2 - х1) * (х2 - х1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}
// собираем данные
int х1 = ReadData("Введите х1: ");
int y1 = ReadData("Введите y1: ");
int z1 = ReadData("Введите z1: ");
int х2 = ReadData("Введите х2: ");
int y2 = ReadData("Введите y2: ");
int z2 = ReadData("Введите z2: ");


// выводим результат
PrintResult(Math.Round(Colculite(х1, y1,z1, х2, y2,z2),2).ToString());