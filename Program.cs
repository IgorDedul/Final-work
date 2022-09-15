// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.WriteLine("Добрый день! Данная программа определяет количество положительных введённых вами чисел");
Console.WriteLine("");
Console.WriteLine("Какое количество чисел вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int positive = 0;

void CorrectInput()
{
    if (size <= 0)
    {
        Console.WriteLine("Вы ввели некорректную длину массива.");
    }
}

CorrectInput();

int[] NewArray()
{
    int[] array = new int [size];
    for (int i=0; i<size; i++)
    {
        Console.WriteLine($"Введите {i+1} число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] array = NewArray();

void ArrayPrint()
{
    int i=0;
    Console.Write("Из введённых вами чисел:");

    for (i=0; i<size-1; i++)
    {
        Console.Write($" {array[i]}, ");
    }
    Console.Write($" {array[i]}");
}

ArrayPrint();
Console.WriteLine("");

int PositiveNumber()
{
    for (int i=0; i<size; i++)
    {
        if (array[i] > 0)
        {
            positive++;
        }
    }
    return positive;
}

positive = PositiveNumber();
Console.WriteLine($"{positive} положительных.");
