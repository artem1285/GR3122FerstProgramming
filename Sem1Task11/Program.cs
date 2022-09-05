//=========================================
//Напишите программу, которая выводит трехзначное  число, 
//и удаляет вторую цифру этого числа и выводит пользователю.
//===================================== 
//Вариант Евгений
System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(10, 1000);
Console.WriteLine(number);
int FirstDigit = number / 100;
int SecondDigit = number % 10;
Console.WriteLine(FirstDigit *10 + SecondDigit);

//Вариант Константин

void Variant1()
{
    Console.WriteLine("Вариант 1: ");
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);
   char[] charArray = number.ToString().ToCharArray();
    Console.Write(charArray[0]);
   Console.WriteLine(charArray[2]);
}
Variant1();