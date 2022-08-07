int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = new Random().Next(0, 100);
Console.WriteLine(a1);
int a2 = new Random().Next(0, 100);
Console.WriteLine(a2);
int a3 = new Random().Next(0, 100);
Console.WriteLine(a3);
int b1 = new Random().Next(0, 100);
Console.WriteLine(b1);
int b2 = new Random().Next(0, 100);
Console.WriteLine(b2);
int b3 = new Random().Next(0, 100);
Console.WriteLine(b3);
int c1 = new Random().Next(0, 100);
Console.WriteLine(c1);
int c2 = new Random().Next(0, 100);
Console.WriteLine(c2);
int c3 = new Random().Next(0, 100);
Console.WriteLine(c3);

int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3);

int max = Max(max1, max2, max3);

Console.WriteLine("max number = " + max);