﻿//==========================================
// напишите программу которая на вход принимает число и выдает его 
//в квадрате (число *на само себя)
//==========================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    //int outNumber = inputNumber * inputNumber;
    int outNumber = (int)Math.Pow(inputNumber,2);
    Console.WriteLine(outNumber);
}