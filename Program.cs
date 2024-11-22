using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        ShiftArrayLeft(array, k);

        Console.WriteLine($"Массив после циклического сдвига на {k} позиций влево:");
        PrintArray(array);
    }

    static void ShiftArrayLeft(int[] array, int k)
    {
        int n = array.Length;

        k = k % n;

        int[] temp = new int[n];

        for (int i = 0; i < n; i++)
        {
            temp[i] = array[(i + k) % n];
        }

        for (int i = 0; i < n; i++)
        {
            array[i] = temp[i];
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}