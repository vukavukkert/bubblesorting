using System;



int l = int.Parse(Console.ReadLine()); //length
int[] array = new int[l];
int swap;
for (int i = 0; i < l; i++)
{
    Console.WriteLine($"введите элеиент {i}");
    array[i] = int.Parse(Console.ReadLine());

}

for (int i = 0; i < l; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("\nсортировка");
//sorting
for (int i = 1; i < l; i++)
{
    for(int j = 0; j < l-i; j++)
    {
        if (array[j] < array[j + 1])
        {
            array.Swap(j, j + 1);
        }
        
    }
    for (int u = 0; u < l; u++)
    {
        Console.Write($"{array[u]}, ");
    }
    Console.WriteLine();
}
Console.WriteLine("окончательный результат");
for (int i = 0; i < l; i++)
{
    Console.Write($"{array[i]}, ");
}

static class SwapExtension
{
    public static void Swap(this int[] array, int x, int y) => (array[x], array[y]) = (array[y], array[x]);
}

