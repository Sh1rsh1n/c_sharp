int a = new Random().Next(-10, 10);
Console.WriteLine(a);
int b = new Random().Next(-10, 10);
Console.WriteLine(b);

double result = 0;
if (a % 2 == 0 && b % 2 == 0)
{
    if (b == 0)
    {
        Console.WriteLine("на ноль делить нельзя");
        return;
    }
    result = (double) a / b;
    Console.WriteLine("Оба числа чётные. Их частное = " + result);
}
else if (a % 2 != 0 && b % 2 != 0)
{
    result = a + b;
    Console.WriteLine("Оба числа нечётные. Их сумма = " + result);
}
else
{
    result = a * b;
    Console.WriteLine("Одно из чисел нечётное. Их произведение = " + result);
}
