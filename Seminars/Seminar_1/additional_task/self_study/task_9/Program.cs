int num;
string value;
bool result;


do{
    Console.Write("Введите номер дня недели от 1 до 7: ");
    value = Console.ReadLine();
    result = Int32.TryParse(value, out num);
}
while (!(result));


if (num >= 1 && num <= 5)
{
    switch (num)
    {
        case 1: Console.Write("Monday"); break;
        case 2: Console.Write("Tuesday"); break;
        case 3: Console.Write("Wednesday"); break;
        case 4: Console.Write("Thursday"); break;
        case 5: Console.Write("Friday"); break;
    }
    Console.WriteLine(" WorkDay");
}
else if (num >= 6 && num <= 7)
{
    switch (num)
    {
        case 6: Console.Write("Saturday"); break;
        case 7: Console.Write("Sunday"); break;
    }
    Console.WriteLine(" WeekEnd");
}
else
{
    Console.WriteLine("Incorrect numbers. Try again.");
}