/*
Вычисляется сумма всех нечетных натуральных чисел от n1 до n2
(n1 и n2 вводятся с клавиатуры, цикл for).
*/


/*
Проверяем правильность ввода чисел с помощью do while(должны быть больше или равны 0)
*/
int n1, n2;

do
{
    n1 = InputValue();
    n2 = InputValue();
}
while (!(n1 >= 0 && n2 >= 0));

int sum = 0;

/*
    Проверяем какое число больше, затем вызываем метод CalcSum где происходит магия))
*/
if (n1 > n2)
{
    CalcSum(n2, n1);
}
else if (n2 > n1)
{
    CalcSum(n1, n2);
}
else
{
    Console.WriteLine("Числа равны");
}

/*
    ввод с консоли
*/
int InputValue()
{
    Console.WriteLine("Введите натуральное число от 0 до 1000: ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

/*
    метод CalcSum ни чего не возвращает, принимает два аргумента типа int first, int last
    выполняет вычисления и выводит результат в консоль
*/
void CalcSum(int first, int last)
{
    for (int i = first; i <= last; i++)
    {
        if (i % 2 != 0)
        {
            sum += i;
        }
    }
    Console.WriteLine("sum = " + sum);
}
