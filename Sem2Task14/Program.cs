//=========================================
//Напишите программу, которая 
//на вход принимает число, и проверяет, 
//кратно ли оно одновременно 7 и 23.
//===================================== 

Console.Write("Введите число: ");
string inputLineA = Console.ReadLine()??"";

int inputNumberA = int.Parse(inputLineA); 

if (inputNumberA % 7 ==0 && inputNumberA % 23 ==0)
{
    Console.Write("Число кратно одновременно и 7 и 23");
}
else
{
    Console.Write("Число не кратно одновременно и 7 и 23");
}

//вариант Анатолия
// string? inputLineА = Console.ReadLine(); // считал счисло
// if (inputLineA != null) 
// Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA)% 23 == 0)) ? ("Кратно"): ("Некратно"));