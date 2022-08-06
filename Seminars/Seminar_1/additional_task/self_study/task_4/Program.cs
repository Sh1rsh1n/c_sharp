
int numberOfMonth;
bool result;

/*
вводим значение до тех пор пока не будет корректно.
TryParse - обробатывает входные данные
while выполнится только тогда, когда !(result) = false И !(numberOfMonth > 0 && numberOfMonth < 13) = false
*/
do
{
    Console.Write("Введите номер месяца от 1 до 12: ");
    string value = Console.ReadLine();
    result = Int32.TryParse(value, out numberOfMonth);
}
while (!(result) || !(numberOfMonth > 0 && numberOfMonth < 13));


if (numberOfMonth == 12 || numberOfMonth <= 2)
{
    Console.WriteLine("Зима");
    if (numberOfMonth == 12)
    {
        Console.WriteLine("Декабрь. Идет сессия");
    }
    if (numberOfMonth == 1)
    {
        Console.WriteLine("Январь. Идут каникулы");
    }
    if (numberOfMonth == 2)
    {
        Console.WriteLine("Февраль. Идет 2ой семестр");
    }
}
else if (numberOfMonth > 2 && numberOfMonth < 6)
{
    Console.WriteLine("Весна");
    if (numberOfMonth == 3)
    {
        Console.WriteLine("Март. Идет 2ой семестр");
    }
    if (numberOfMonth == 4)
    {
        Console.WriteLine("Апрель. Идет 2ой семестр");
    }
    if (numberOfMonth == 5)
    {
        Console.WriteLine("Май. Идет сессия");
    }
}
else if (numberOfMonth > 5 && numberOfMonth < 9)
{
    Console.WriteLine("Лето");
    if (numberOfMonth == 6)
    {
        Console.WriteLine("Июнь. Идет Сессия");
    }
    if (numberOfMonth == 7)
    {
        Console.WriteLine("Июль. Идут каникулы");
    }
    if (numberOfMonth == 8)
    {
        Console.WriteLine("Август. Идут каникулы");
    }
}
else if (numberOfMonth > 8 && numberOfMonth < 12)
{
    Console.WriteLine("Лето");
    if (numberOfMonth == 9)
    {
        Console.WriteLine("Сентябрь. Идет 1ый семестр");
    }
    if (numberOfMonth == 10)
    {
        Console.WriteLine("Октябрь. Идет 1ый семестр");
    }
    if (numberOfMonth == 11)
    {
        Console.WriteLine("Ноябрь. Идет 1ый семестр");
    }
}