// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Добрый день! Данная программа из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.");
Console.WriteLine("");
Console.WriteLine("Введите 1 если хотите задать массив вручную, в противном случае будет задан по умолчанию:");
int question = Convert.ToInt32(Console.ReadLine());
int size = default;

string[] NewArray()
{
    string[] array = new string [size];
    for (int i=0; i<size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива:");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] newArray = new string[default];
if (question == 1) 
{
    Console.WriteLine("Какая длинна должна быть у массива?");
    size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    if (size >  0) 
    {
        newArray = NewArray();
    }
    else Console.WriteLine("Вы ввели некорректную длину массива.");
}
else 
{
   newArray = new string[12] {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan", "С#"};
   size = newArray.Length;
}

void ArrayPrint(string[] array)
{
    int i=0;
    Console.Write("[");

    for (i=0; i<size-1; i++)
    {
        Console.Write($" {array[i]}, ");
    }
    Console.Write($" {array[i]} ]");
}
Console.WriteLine("");
Console.WriteLine("заданный первоначальный массив:");
Console.WriteLine("");
ArrayPrint(newArray);
Console.WriteLine("");

string[] SecondArray(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    return array2;
}

string[] endArray = SecondArray(newArray);
Console.WriteLine("");
Console.WriteLine("Итоговый массив:");
Console.WriteLine("");
ArrayPrint(endArray);
Console.WriteLine("");