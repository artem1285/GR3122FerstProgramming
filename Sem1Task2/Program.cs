//==========================================
// Написать программу,которая на вход принимает 
// два числа и выдает какое число больше, а какое меньше. 
//==========================================

string? inputLineA = Console.ReadLine(); // string - изначально это строка. Console.ReadLine - принимаем 2 числа на вход от пользователя
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null) //тут проверчем число на null (отсутствие всего. Я не совсем понял что это значит)

{
    int inputNumberA = int.Parse(inputLineA); // здесь мы превращаем строчку в число
    int inputNumberB = int.Parse(inputLineB);
    if (inputNumberA > inputNumberB)         // тут мы провреряем:Если А больше Б то в консоли появится А
    {
    Console.WriteLine(inputNumberA);
    }
    else // или 
    {
    Console.WriteLine(inputNumberB); // если больше В выведится число В
    }
}
