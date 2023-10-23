/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

Console.WriteLine("введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int check = m;

if (m > n)
{
    m = n;
    n = check;
}

PrintSumm(m, n, check = 0);

