// // Напишите программу, которая по 
//заданному номеру четверти показывает 
//диапазон возможных координат точек в этой четверти.
//============================
int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
string QoterBorderAsk(int numQoter)
{
    if (numQoter == 1)
        return "x>0 y>0";
    if (numQoter == 2)
        return "x<0 y>0";
    if (numQoter == 3)
        return "x<0 y<0";
    if (numQoter == 4)
        return "x>0 y<0";
    return "";
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}
int num = ReadData("Введите номер четверти: ");
string res = QoterBorderAsk(num);
PrintResult(res);
