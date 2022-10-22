
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
Console.WriteLine("Введите число M:\t");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N:\t");
int n = int.Parse(Console.ReadLine()!);

int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных целых чисел в указанном промежутке равна {summ}");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

