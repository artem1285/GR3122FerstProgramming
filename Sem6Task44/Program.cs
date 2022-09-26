// Не используя рекурсию, 
//выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// вариант константин
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
// Метод, печатает одномерный массив
void Print1DArray(int[] arr)
{
    string arrString = "";

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + ", ";
    }
         arrString += arr[arr.Length - 1];
    Console.WriteLine(arrString);
}

int[] Fibonacci(int number)
{
    int[] fibonacciArr = new int[number]; // объявляет массив, который будет заполнен
    fibonacciArr[1] = 1; // первое значение заполняет, потому что 0 запонлнено при инициализации автоматически

    for (int i = 2; i < number; i++) // тут начинает заполнять с 2
    {
        fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1]; // изменяя i продвигается и заполняет массив
    }
    return fibonacciArr;
}

// программа 
int inputNumber = ReadData("Введите длину последовательности: ");

Console.WriteLine($"Последовательность Фибоначчи длиной {inputNumber}:");
Print1DArray(Fibonacci(inputNumber));


// метод препод 
// Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }
// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}
string FibNum(int num)
{
    string res = string.Empty;
    int ferst = 0; // на первом проходе будет 0
    int last = 1;
    int buf = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + " " + ferst; //  сюда первый попадет 0 
        buf = ferst + last;
        ferst = last;
        last = buf;
    }
    return res;
}
int numFib = ReadData("Введите количество чисел фибоначчи: "); // сначала получим число фибаначи
string line = FibNum(numFib); // переменная в которую положим результат numFib
PrintResult("Числа фибоначчи: ", line); // печататем, в префикс положим сообщение

PrintResult("Числа фибоначчи: ", FibNum(ReadData("Введите количество чисел фибоначчи: ")));