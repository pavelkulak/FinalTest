// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




int M = GetNum("Введите значение M: ");
int N = GetNum("Введите значение N: ");

int sum = CalculateSum(M, N);

Console.WriteLine($"Сумма натуральных элементов от {M} до {N}: {sum}");


static int GetNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

static int CalculateSum(int start, int end)
{
    if (start > end)
    {
        return 0; // Базовый случай: если начальное значение больше конечного, возвращаем 0
    }
    else
    {
        return start + CalculateSum(start + 1, end); // Рекурсивно суммируем числа
    }
}

