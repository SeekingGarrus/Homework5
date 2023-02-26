public class Library
{
    int GetNumber(string text) // ввод числа int
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    int[] CreateArray(int size) // создание массива int
    {
        return new int[size];
    }

    double[] CreateArrayDouble(int size) // создание массива double
    {
        return new double[size];
    }

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


    void FillArrayRandom(int[] coll) // рандомное заполнение массива от 100 до 1000
    {
        for (int index = 0; index < coll.Length; index++)
        {
            coll[index] = new Random().Next(100, 1000);
        }
    }

    void FillArray(int[] coll) // рандомное заполнение массива от -100 до 100
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

    string ArrayJoinToString(double[] array) // вывод массива double
    {
        return $"[{String.Join(", ", array)}]";
    }

    int EvenQuantity(int[] arr) // функция, показывающая количество чётных чисел в массиве
    {
        int count = 0;
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            if (arr[i] % 2 == 0)
                count++;
        }
        return count;
    }

    int NotEvenIndex(int[] arr) // функция, показывающая сумму элементов, стоящих на нечётных позициях
    {
        int sum = 0;
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            if (i % 2 != 0)
                sum = sum + arr[i];
        }
        return sum;
    }

    
    void SelectionSort(double[] array) // метод нахождения в массиве min и max, вычисление разницы
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

}