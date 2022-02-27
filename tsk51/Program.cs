// Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int y = int.Parse(Console.ReadLine());
int[,] arr = new int[x, y];

FillArray();
PrintArray();

void FillArray()
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = i+j;
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
           Console.Write ($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}