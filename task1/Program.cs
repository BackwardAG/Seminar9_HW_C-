// // Задача 66: Задайте значения M и N. Напишите программу,
// // которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

Console.WriteLine("Введите числа M и N для определения границ промежутка: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());


int SumNumbersBetween(int M, int N)
{   
    if (M == N) 
    {
        return M;
    }
    if (M < N)
    {
        return N + SumNumbersBetween(M, N - 1);
    } 
    else
    {
        return N + SumNumbersBetween(M, N + 1);
    }
}

System.Console.WriteLine(SumNumbersBetween(M,N));