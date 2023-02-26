// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int GetNumber(string text) // ввод числа int
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size) // создание массива int
{
    return new int[size];
}

void FillArrayRandom(int[] coll) // метод заполнения массива int
{
    for (int index = 0; index < coll.Length; index++)
    {
        coll[index] = new Random().Next(100, 1000);
    }
}

void PrintArrayFor(int[] array) // вывод массива int
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int EvenQuantity(int[] arr) // функция, показывающая количество чётных чисел в массиве
{
    int count = 0;
    for (int i= 0; i <= arr.Length-1; i++)
    {
        if (arr[i] % 2 == 0)
        count++;
    }
    return count;
}

int number1 = GetNumber("Введите количество элементов массива: ");
int[] array = CreateArray(number1);
FillArrayRandom(array);
PrintArrayFor(array);
int result = EvenQuantity(array);
Console.Write($"Количество четных чисел в массиве: {result}");