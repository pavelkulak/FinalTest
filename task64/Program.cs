// Задача 64: Задайте которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1


int N = GetNum("Введите натуральное число N: ");
PrintNaturalNumbers(N);


static int GetNum(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

static void PrintNaturalNumbers(int N)
{
    if (N >= 1)
    {
        Console.Write($"{N}");

        if (N > 1)
        {
            Console.Write(", ");
        }

        PrintNaturalNumbers(N - 1);
    }
}


