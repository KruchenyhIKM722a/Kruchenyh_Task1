using System;

class Program
{
    static void Main()
    {
        int[] array = { 4, 2, 8, 12, 5 };

        int sum = 0;

        foreach (int element in array)
        {
            sum += element;
        }

        Console.WriteLine("Сума всех элементов в массиве: " + sum);
    }
}