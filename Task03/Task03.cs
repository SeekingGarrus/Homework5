// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// Подзадачи
// 1. Ввести размер массива
int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Создать массив
double[] CreateArrayDouble(int size)
{
    return new double[size];
}

// 3. Заполнить массив руками
void FillDouble(double[] array) // метод заполнения массива double
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetDataFromUser($"Введите значение массива [{i + 1}]");
    }
}

double GetDataFromUser(string text) // функция получения числа от пользователя в double
{
    double num = 0;
    bool flag = true;
    do
    {
        Console.Write($"{text}: ");
        flag = double.TryParse(Console.ReadLine(), out num);
    } while (!flag);
    return num;
}

// 4. Распечатать созданный массив
string ArrayJoinToString(double[] array)
{
    return $"[{String.Join(", ", array)}]";
}

// 5. Найти в массиве min и max, вычислить разницу
void SelectionSort(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между max ({max}) и min ({min}) элементом составляет {Math.Round(max - min, 2)}");
}

int count = GetNumber("Количество элементов массива: ");
double[] numbers = CreateArrayDouble(count);
FillDouble(numbers);
Console.WriteLine(ArrayJoinToString(numbers));
SelectionSort(numbers);