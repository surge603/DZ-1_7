// Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int y = int.Parse(Console.ReadLine());
int[,] arr = new int[x, y];

FillArray();
PrintArray();
Console.Write("Координаты какого числа следует найти? ");
int fnd = int.Parse(Console.ReadLine());
FindPosition();

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

void FindPosition()
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            if (arr[i, j] == fnd)
            {
                Console.WriteLine($"Искомое число {fnd} найдено в ячейке [{i},{j}]");
                return;
            }
        }
    }
    Console.WriteLine($"Искомое число {fnd} в матрице не найдено.");
}