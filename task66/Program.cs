// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumMN(int M, int N)
{
    int res = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        res = M + SumMN(M, N);
        return res;
    }
}

void SumFromMToN(int M, int N)
{
    System.Console.Write(SumMN(M - 1, N));
}

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
SumFromMToN(M, N);