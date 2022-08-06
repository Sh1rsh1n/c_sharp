int a = new Random().Next(10, 30);
int b = new Random().Next(10, 30);
Console.WriteLine(a);
Console.WriteLine(b);

int result = 0;
if (a > b)
{
    result = a - b;
    Console.WriteLine("a - b = " + result);
}
else if (a < b)
{
    result = a + b;
    Console.WriteLine("a + b = " + result);
}
else
{
    Console.WriteLine("nums equals");
}