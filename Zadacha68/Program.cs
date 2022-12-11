// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
void AkkermanFunction(int x, int y)
{
    Console.Write(Akkerman(x, y)); 
}
int Akkerman(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    else if (y == 0 && x > 0)
    {
        return Akkerman(x - 1, 1);
    }
    else
    {
        return (Akkerman(x - 1, Akkerman(x, y - 1)));
    }
}

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 0 || numberN < 0) Console.WriteLine("Вы ввели отрицательное число!");
else AkkermanFunction(numberM,numberN);
Console.WriteLine();
Console.Write("Exit.");
Console.ReadLine();
