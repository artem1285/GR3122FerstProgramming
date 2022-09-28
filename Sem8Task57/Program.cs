// Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит 
//информацию о том, сколько раз встречается элемент входных данных.
// михаил
// Создает двумерный массив размером m×n
int[,] GenerateArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[,] array = new int[countRow, countColumn];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(topBorder, downBorder);
        }
    }
    return array;
}

// Возвращает частотный словарь элементов двумерного массива. Отсортированный словарь
SortedDictionary<int, int> CountDictionary(int[,] array)
{
    SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (dict.ContainsKey(array[j, i]))// тут смотрит  есть ли такой ключ. 
                dict[array[j, i]] = dict[array[j, i]] + 1;// увеличивает значение ключа на единцу
            else
                dict.Add(array[j, i], 1); // если такого ключа нет, то он его добавляет с 1. 
        }
    }
    return dict;
}
// вывод двумерного массива
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}
// вывод ответа
void PrintAnswer(string answer, string title = "")
{
    Console.WriteLine("{0} -> {1}", title, answer);
}

// программа 
int[,] array = GenerateArray(5, 5, 0, 10); // генерирует массив 5х5, заполняет от 0до 10
Console.WriteLine("\n------- Исходная матрица -------\n");
Print2DArray(array);
SortedDictionary<int, int> dict = CountDictionary(array); // создает частотный словарь
PrintAnswer("Сколько повторений\n", "\nЧисло");
foreach (KeyValuePair<int, int> kvp in dict) // проходит по словарю, используя KeyValuePair
//foreach - тот же цикл for, но для всех элементов. Он возможен в том случае когда в какой то конструкции
// есть поддержка интерфейса, под названием инуберл, т.е. пронумеровна, проиндексирована. 
{
    PrintAnswer(kvp.Value.ToString(), kvp.Key.ToString()); // для каждого элемента он вызывает PrintAnswer или принтдата. печать ключа и значения. 
}

// анатолий
// Генерация случайного 2D массива.
int[,] Gen2DArr(int rows, int columns, int arrMin, int arrMax)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    if (arrMin > arrMax) // проверка ни мин мах
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }
    int range = arrMax - arrMin;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}

Dictionary<int, int> FreqDict(Dictionary<int, int> countValues, int[,] arr) // использует словарь
{
    foreach (int item in arr)// проходит по всем элементам массива
    {
        if (countValues.ContainsKey(item)) // если в словаре есть такой ключ 
        {
            countValues[item]++; // тогда он его увеличивает 
        }
        else
        {
            countValues.Add(item, 1); // если нет, добавляет
        }
    }
    return countValues;
}

// Печать словаря.
void PrintDict(Dictionary<int, int> countValues)
{
    foreach (var item in countValues)
    {
        Console.WriteLine(item);
    }
}

// Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


int[,] arr = Gen2DArr(10, 10, 0, 10); // генерирует массив
Dictionary<int, int> countValues = new Dictionary<int, int>(); // создает словарь
Print2DArray(arr); // печатает двумерный массив 
FreqDict(countValues, arr); // заполняет частотный словарь
PrintDict(countValues); // печатает частотный словарь