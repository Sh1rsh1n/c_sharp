/*
Вычисляется сумма квадратов n натуральных чисел, начиная с k
(вводятся k и n, цикл for).
*/

/*
Проверяем правильность ввода чисел с помощью do while(должны быть больше или равны 0)
*/
int k, n;

do
{
    Console.WriteLine("Введите число k от 0 до 1000: ");
    k = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число n от 0 до 1000: ");
    n = int.Parse(Console.ReadLine());
}
while (!(k >= 0 && n >= 0));

double sum = 0;

for(int i = k; i <= n; i++)
{
    sum += (double) Math.Pow(i, 2);

    Console.WriteLine("sum = " + sum + " i = " + i);
}