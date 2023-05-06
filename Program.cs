﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[,]
        {
            {1, 4, 2},
            {3, 6, 5},
            {7, 9, 8}
        };

        int[] flattenedArray = FlattenArray(array); // تبدیل آرایه دوبعدی به آرایه یک بعدی
        Array.Sort(flattenedArray); // مرتب کردن آرایه به صورت صعودی

        int median = FindMedian(flattenedArray); // پیدا کردن میانه

        Console.WriteLine("The median of the array is: " + median);
        Console.ReadLine();
    }

    // تبدیل آرایه دوبعدی به آرایه یک بعدی
    static int[] FlattenArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int[] flattenedArray = new int[rows * columns];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                flattenedArray[index] = array[i, j];
                index++;
            }
        }

        return flattenedArray;
    }

    // پیدا کردن میانه
    static int FindMedian(int[] array)
    {
        int length = array.Length;
        int middleIndex = length / 2;

        if (length % 2 == 0) // اگر تعداد اعداد زوج بود
        {
            int median = (array[middleIndex - 1] + array[middleIndex]) / 2;
            return median;
        }
        else // اگر تعداد اعداد فرد بود
        {
            int median = array[middleIndex];
            return median;
        }
    }
}