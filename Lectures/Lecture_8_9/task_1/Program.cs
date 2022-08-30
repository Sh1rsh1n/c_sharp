/*
рекурсия
*/
string NumberRec(int a, int b)
{
    if (a >= b)
    {
        return NumberRec(a - 1, b) + $"{a} ";
    }
    else
    {
        return string.Empty;
    }
}

Console.WriteLine(NumberRec(1, 10));
