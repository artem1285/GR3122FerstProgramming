//=========================================
//Напишите программу, которая на вход будет принимать два  
//числа, и выводить, является ли второе число, кратное первому. Если второе 
//число кратно первому, то программа выдает остаток от деления.
//===================================== 


//Вариант Константин


/* void Variant1()
{
    Console.Write("ВВедите первое число: ");
    string? inputLineA = Console.ReadLine(); 
    Console.Write("ВВедите вортое число: ");
    string? inputLineB = Console.ReadLine();

    int inputNumberA = int.Parse(inputLineA); 
    int inputNumberB = int.Parse(inputLineB); */

    //Console.WriteLine((inputNumberB % inputNumberA ==0) ? ("Второе число кратно первому") : ("Остаток от деления: + inputNumberB % inputNumberA"));
//}
/* Variant1(); */

// Вариант препод
int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
ConculateData();
PrintData();

// получаем два числа от пользователя
void ReadData()
{
    Console.Write("ВВедите первое число: ");
    string inputLineA = Console.ReadLine()??"";;
    Console.Write("ВВедите вортое число: ");
    string inputLineB = Console.ReadLine()??"";;

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}

// определяем кратность чисел
void ConculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}
//выводим данные вычисчления
void PrintData()
{
    if (result)
        Console.WriteLine("Второе число кратно первому");
    else
    {
        Console.WriteLine("Остаток от деления: + inputNumberB % inputNumberA");
    }
}






//Вариант Евгений

/* string? inputLineA = Console.ReadLine(); 
string? inputLineB = Console.ReadLine();

if(inputLineA != null && inputLineB != null)  
 {
 int inputNumberA = int.Parse(inputLineA); 
 int inputNumberB = int.Parse(inputLineB);
 
 Console.WriteLine(inputNumberB % inputNumberA ==0 ? "Является кратным": inputNumberB % inputNumberA);  
 } */







