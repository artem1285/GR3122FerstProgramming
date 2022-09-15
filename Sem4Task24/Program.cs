// Напишите программу, 
//которая на вход принимает число А и выдает сумму чисел от 1 до А.
int ReadData(string line) // получаем число А 
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int numberA = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return numberA;
}
// метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
    int sumOfNumbers =0;
    for (int i=1;i<=numA;i++)
    {
        sumOfNumbers+=i;
        }
return sumOfNumbers;
}

int VariantSumGaus (int numA)
{ 
int sumOfNumbers = 0;
sumOfNumbers  = ((1  + numA) * numA) /2; 
return sumOfNumbers;
}

int numberА =ReadData("введите число А: ");
int res1 = VariantSumGaus (numberА); // это вычисление в ментоде int VariantSumSimple(int numA)
int res2 = VariantSumSimple (numberА); 
PrintResult("Сумма чисел от 1 до А равна( метод гауса): " + res1); // это что выведится 
PrintResult("Сумма чисел от 1 до А равна(простой метод): " + res2);