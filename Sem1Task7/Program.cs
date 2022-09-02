//==========================================
// Напишите программу, которая на вход принимает число n, 
// а на выход показывает все числа в промежутке от -n до n
//==========================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine); 
    if (inputNumber > 99 && inputNumber < 1000)
   { 
      int LastDigit = inputNumber%10;
      Console.Write(LastDigit);
   }   
}
