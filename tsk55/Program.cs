// Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int y = int.Parse(Console.ReadLine());
int[,] arr = new int[x, y];

FillArray();
PrintArray();
Console.WriteLine();
Console.WriteLine("Средние арифметические по столбцам:");
ShowAverages();

void FillArray()
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}

void ShowAverages()
{
    for (int i = 0; i < y; i++)
    {
        int avr = 0;
        for (int j = 0; j < x; j++)
        {
            avr += arr[j, i];
        }
        avr /= x;
        Console.Write($"{avr} ");
    }
    Console.WriteLine();
}