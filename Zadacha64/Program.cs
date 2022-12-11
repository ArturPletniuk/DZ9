//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int Recursion(int x, int y)
{
    if (x == y)
        return x;
    else
        Console.Write($"{Recursion(x, y + 1)}, ");
    return y;
}
Console.Write("Введите положительное число: ");
int naturalNumber =  Convert.ToInt32 (Console.ReadLine());
int number = 1;
if (naturalNumber < number) Console.WriteLine("Вы ввели не положительное число!");
else
{
    Console.Write($"N = {naturalNumber} -> ");
    Console.WriteLine(Recursion(naturalNumber, number));
} 
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();
