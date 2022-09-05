//==========================================
//  Напишите программу, которая выводит 
// случайные числа, из отрезка 10, 99 и показывает наибольшую цифру числа.
//==========================================

void MyVariant()
{
    Console.WriteLine("метод1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int FirstDigit = number / 10;
    int SecondDigit = number % 10;
    if (FirstDigit > SecondDigit)
    {
        Console.WriteLine(FirstDigit);
    }
    else
    {
        Console.WriteLine(SecondDigit);
    }
}

void Evgeniy()
{
    Console.WriteLine("метод2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    int FirstDigit = number / 10;
    int SecondDigit = number % 10;
    // вариант Евгения
    Console.WriteLine((FirstDigit > SecondDigit) ? FirstDigit : SecondDigit);
}

void charVariant()
{
    Console.WriteLine("метод3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);
    // вариант char 
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

// MyVariant();

Evgeniy();