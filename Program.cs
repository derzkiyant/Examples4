Task25();
Console.ReadKey();

Task27();
Console.ReadKey();

Task29();

// ------------------------------

void Task25()
{
    Console.WriteLine("\nЗадача 25: Напишите цикл, который принимает на вход два числа (A и B) и " +
                        "возводит число A в натуральную степень B.\n3, 5 -> 243\n2, 4 -> 16");

    int numberA = ReadIntFromConsole("Введите число A: ");
    int numberB = ReadIntFromConsole("Введите число B: ");
    int power = GetPower(numberA, numberB);

    Console.WriteLine($"{numberA} в степени {numberB} -> {power}");
}

void Task27()
{
    Console.WriteLine("\nЗадача 27: Напишите программу, которая принимает на вход число и " +
                        "выдаёт сумму цифр в числе.\n452 -> 11\n82 -> 10\n9012 -> 12");

    int number = ReadIntFromConsole("Введите число: ");
    int sum = GetSumNumbers(number);

    Console.WriteLine($"Сумма цифр в числе {number} -> {sum}");
}

void Task29()
{
    Console.WriteLine("\nЗадача 29: Напишите программу, которая задаёт массив из 8 элементов " +
                        "и выводит их на экран.\n1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]\n6, 1, 33-> [6, 1, 33]");

    int size = ReadIntFromConsole("Введите размер массива: ");
    int[] array = new int[size];

    FillArrayFromConsole(array);
    PrintIntArray(array);
}

// ------------------------------

int ReadIntFromConsole(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetPower(int num1, int num2)
{
    int pow = num1;
    for (int i = 1; i < num2; i++)
    {
        pow *= num1;
    }
    return pow;
}

int GetSumNumbers(int currentNum)
{
    int sum = 0;
    while (currentNum > 0)
    {
        sum += currentNum % 10;
        currentNum /= 10;
    }
    return sum;
}

void FillArrayFromConsole(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ReadIntFromConsole($"Введите {i + 1}-ый элемент массива: ");
    }
}

void PrintIntArray(int[] arr)
{
    Console.Write($"Вывод массива: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]");
}
