class Program
{
    static void Main()
    {
        // Задаем прямоугольный двумерный массив
        int[,] array = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим строку с наименьшей суммой элементов
        int minSum = int.MaxValue; // Начальное значение для сравнения сумм
        int minRow = 0; // Индекс строки с наименьшей суммой
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minRow = i;
            }
        }

        // Выводим результат
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");

    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}