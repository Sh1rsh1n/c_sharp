void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int possition = 0;

    while(possition < count)
    {
        Console.WriteLine(collection[possition]);
        possition++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int possition = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            possition = index;
            return possition;
        }
        index++;
    }
    return possition;
}

int[] array = new int[10];

FillArray(array);

PrintArray(array);
Console.WriteLine();

int poss = IndexOf(array, 44);
Console.WriteLine(poss);