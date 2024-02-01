// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

Console.WriteLine("Введите размер массива");
int SizeArray = Convert.ToInt32(Console.ReadLine());
int [] Array = new int[SizeArray];
void CreateArray()
{
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0, 10);
    }
}

void PrintArray()
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}

void ReverseArray(int[] arr)
{
    if (arr.Length <= 1)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.Write("");
        return;
    }
    ReverseArray(arr.Skip(1).ToArray());
    Console.Write(arr[0] + " ");
}
CreateArray();
PrintArray();
Console.WriteLine();
ReverseArray(Array);