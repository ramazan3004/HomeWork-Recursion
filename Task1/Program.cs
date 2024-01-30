/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.  */

System.Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());

void RangeFrom_N_To_M(int N, int M)
{
    if (N > M)
    {
        return;
    }
    System.Console.Write($"{N}, ");
    RangeFrom_N_To_M(N+1, M);
}
RangeFrom_N_To_M(n, m);
