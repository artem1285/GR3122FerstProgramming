﻿//==========================================
// Написать программу,которая на вход принимает число и 
//выдает четным или нечетным, делится или не делится на 2. 
//==========================================

string? inputLine = Console.ReadLine(); // считываем число пользователя
if (inputLine != null) //тут проверчем число на null 

{
    int inputNumber = int.Parse(inputLine); // здесь мы превращаем строчку в число
    int number = inputNumber; // тут создаем переменную, в которй возьмем число, которое ввел пользователь
    if (number % 2 == 0) // тут идет сравнение с числом, 
    //если оно поделится на 2 и остаток от деления будет 0, 
    //значит оно четное, а если будет с остатком, 
    //то в консоль выйдет нечетное число
    {
    Console.WriteLine("четное");
    }
    else
    {
    Console.WriteLine("нечетное");
    }
}
// честно не совсем понял как это работает. Точнее я понял что если 
// вводим число 5 и %2 = остаток будет 1 и оно выведится как нечетное.
// если 2 то без остатка. Четное. Но вот не уверен что я правильно прописал это в программе
// хотя программа работает.