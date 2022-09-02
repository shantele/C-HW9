// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());  // start
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());  // end

if (M < 0 || N < 0)
{
    Console.WriteLine("Введите положительные числа!");
    return;
}

int Ackermann(int start, int end)
{
    if (start == 0) return end + 1;
    if (start != 0 && end == 0) return Ackermann(start - 1, 1);
    if (start > 0 && end > 0) return Ackermann(start - 1, Ackermann(start, end - 1));
    return Ackermann(start, end);
}

Console.WriteLine($"Результат вычисления функции Аккермана = {Ackermann(M, N)}");