// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void DifferenceMToN(int x, int y)
{
    if (x < y) Console.Write(Recursion(x - 1, y)); 
    else Console.Write(Recursion(y - 1, x)); 
}

int Recursion(int x, int y)
{
    int result = x;
    if (x == y)
        return 0;    
    else
    {
        x++;
        result = x + Recursion(x, y);
        return result;
    }
}

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 0 || numberN < 0) Console.Write("Вы ввели не натуральное число");
else DifferenceMToN(numberM, numberN);
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();
