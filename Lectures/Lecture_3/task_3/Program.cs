int[] arr = { 1, 5, 6, 47, 8, 5, 1, 23, 6, 42 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPoss = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPoss]) minPoss = j; //для сортировки в обратном порядке от большего к меньшему нужно помеять знак < на >.
        }

        int temp = array[i];
        array[i] = array[minPoss];
        array[minPoss] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);