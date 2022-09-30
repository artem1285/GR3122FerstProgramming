//  Задайте значение N. Напишите программу кторая выдает все 
//натуральные числа в промежутке от N до 1.
// Чтение данных из консоли
    int ReadData(string line)
    {
        Console.Write(line);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    // Метод, принимает строку, выводит в консоль
    void PrintResult(string line)
    {
        Console.WriteLine(line);
    }
//  # outLine
//1 4 4 3 2 1 ""
//2 3 3 2 1 "" 
//3 2 2 1 "" 
//4 1 1 ""
//5 0
    string LineGenRec(int numN)
    {
        //Точка остановки
        if(numN==0)return "";
        string outLine = LineGenRec(numN-1) + " " + numN; //на увеличение
        //string outLine = numN + " " +LineGenRec(numN-1); // на уменьшение
        return outLine;
    }
// программа
    int numN = ReadData("Введите число N: ");
    string resultLine = LineGenRec(numN);
    PrintResult(resultLine);

