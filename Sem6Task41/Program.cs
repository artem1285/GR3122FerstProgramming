// Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Вывод результата в консоль
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// метод который считает кольчество чисел введенных пользователем больше 0
int Count(int numbPol)
{
    int res = 0;
    for (int i = 0; i < numbPol; i++)
    {
        int num = ReadData("Введите число : ");
        if (num > 0)
            res++;
    }
    return res;
}

// программа
int enter = ReadData("Введите число: "); // запрос числа у пользователя
int calculation = Count(enter); // посчитате количество чисел больше 0  
PrintResult("Количество чисел больше 0: " + calculation); // выведит сколько чисел введенных с клавиатруы больше 0
