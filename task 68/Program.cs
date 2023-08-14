// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int m = GetNum("Введите значение m: ");
int n = GetNum("Введите значение n: ");

int result = AckermannFunction(m, n);

Console.WriteLine($"A({m},{n}) = {result}");


static int GetNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

static int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else
    {
        throw new ArgumentException("Входные данные должны быть неотрицательными.");
    }
}
