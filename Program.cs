/* Задача: Написать программу, которая из имеющегося массива строк формирует
массив строк, длина которых меньше либо равна 3 символа. Первоначальный
массив можно ввести с клавиатуры, либо задать на страте выполнения
алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */

string[] arrayString = EnteringStringArray();
PrintArr(arrayString);
Console.Write(" -> ");
PrintArr(ModifiedStringArray(arrayString));
Console.WriteLine();



string[] EnteringStringArray()
{
    Console.Write("Введите строки массива через запятую: ");
    string[] stringArray = (Console.ReadLine() ?? String.Empty).Split(",");
    return stringArray;
}

string[] ModifiedStringArray(string[] array)
{
    int sizeModifiedArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) sizeModifiedArray++;
    }
    string[] modifiedArray = new string[sizeModifiedArray];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            modifiedArray[j++] = array[i];
        }
    }
    return modifiedArray;
}

void PrintArr(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write("\b\b]");
}