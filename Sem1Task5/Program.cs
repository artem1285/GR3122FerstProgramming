//==========================================
// Напишите программу, которая на вход принимает число n, 
// а на выход показывает все числа в промежутке от -n до n
//==========================================

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN); 
    if (inputNumberN > 0)
   { 
       int startNumber = (-1) * inputNumberN;
       while (startNumber < inputNumberN)
      {
        Console.Write(startNumber + ", ");
        startNumber = startNumber + 1;
      }
      Console.Write(inputNumberN);
   }   
}
