//==========================================
// Написать программу,которая на вход принимает 
// три числа и выдает мах из этих чисел. 
//==========================================

string? inputLineA = Console.ReadLine(); // string - изначально это строка. Console.ReadLine - принимаем 3 числа на вход от пользователя
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null) //тут проверчем число на null (отсутствие всего. Я не совсем понял что это значит)
{
    int inputNumberA = int.Parse(inputLineA); // здесь мы превращаем строки в числа
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    if (inputNumberA > inputNumberB) // первое ветвление, в котором сравниваем 
    //два числа. В случае если первое мах, мы сравниваем его с 3 числом
      {
        if (inputNumberA > inputNumberC)  // в случае если 1 число будет больше 3 числа
        {
         Console.WriteLine(inputNumberA);   //в консоль выведится 1 число
        }
        else // или 
        {
        Console.WriteLine(inputNumberC); // или если 3 число будет больше, 
        //выведится 3 число
        }
      } // из этих двух чисел найдется максимальное. Одно из двух.
        else // теперь если второе число больше первого, тогда сравниваем его с третьм числом
        if (inputNumberB > inputNumberC) // тут сравниваем 2 и 3 число
        {
         Console.WriteLine(inputNumberB);   // если 2 число больше, выведится оно
        }
        else
        {
        Console.WriteLine(inputNumberC);  // или если 3 число больше, выведится оно
        }
}

// но почему то тогда не выводится. Появляется такая ошибка
/* E:\веб разработка\C#\GR3122FerstProgramming\Sem1Task4\Program.cs(23,27): error 
CS0103: Имя "inputNumberС" не существует в текущем контексте. */
// а вот если в первом варианте поменять вместо Console.WriteLine(inputNumberС)
// на Console.WriteLine(inputNumberВ), тогда программа работает.
// Прошу помочь разъяснить. 