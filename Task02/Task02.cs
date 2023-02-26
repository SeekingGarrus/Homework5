// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int GetNumber(string text) // ввод числа int
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size) // создание массива int
{
    return new int[size];
}

void FillArray(int[] coll) // метод заполнения массива int
{
    for (int index = 0; index < coll.Length; index++)
    {
        coll[index] = new Random().Next(-100, 100);
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

int NotEvenIndex(int[] arr) // функция, показывающая сумму элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i= 0; i <= arr.Length-1; i++)
    {
        if (i % 2 != 0)
        sum = sum + arr[i];
    }
    return sum;
}

int number1 = GetNumber("Введите количество элементов массива: ");
int[] array = CreateArray(number1);
FillArray(array);
PrintArrayFor(array);
int summ = NotEvenIndex(array);
Console.Write($"Сумма элементов, стоящих на не четных позициях: {summ}");