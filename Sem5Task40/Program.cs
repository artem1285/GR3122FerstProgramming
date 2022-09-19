﻿// Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины

// вариант константина
// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

bool TriangleTest(int a, int b, int c)
{
    return (a + b > c) && (a + c > b) && (b + c > a); // он срназу выводит результат, т.е сначла 
    //будет выполнено в  скобочках, копилятор сравнит между собой, true, true, false, а потом
    // через && будет сравнивать  
}

// сама программа
int a = ReadData("Введите длину стороны a: "); // получает стороны 
int b = ReadData("Введите длину стороны b: ");
int c = ReadData("Введите длину стороны c: ");

PrintResult(TriangleTest(a, b, c) ? "Такой треугольник может быть" : "Такого треугольника не может быть");
// тут использует тернарный оператор что бы вывести результат
// методу PrintResult передает, сначала запускает TriangleTest тест
//и в случае если тест возвращает true, тогда
// передает М PrintResult вот это сообщение "Такой треугольник может быть"
// а если TriangleTest тест возвращает false - неправду, тогда "Такого треугольника не может быть"