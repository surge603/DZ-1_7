// Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int y = int.Parse(Console.ReadLine());
double[,] arr = new double[x, y];

FillArray();
PrintArray();

void FillArray()
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = Math.Sqrt(new Random().Next(10, 100));
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
           Console.Write ($"{Math.Round(arr[i, j],2)} ");
        }
        Console.WriteLine();
    }

}