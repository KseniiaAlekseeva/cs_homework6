// User enters M numbers. Counts how many numbers greater than 0.

int[] GetArray()
{
    Console.WriteLine("Enter some numbers: ");
    string[] str = Console.ReadLine().Split(" ");
    int[] array = new int[str.Length];

    for (int i = 0; i < str.Length; i++)
        array[i] = Convert.ToInt32(str[i]);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count++;
    return count;
}

int[] arr = GetArray();
PrintArray(arr);
Console.WriteLine($"This arrray contains {CountPositive(arr)} positive numbers.");