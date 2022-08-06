Console.Write("Введите ваш вес: ");
double weigth = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите ваш рост: ");
double heigth = Convert.ToInt32(Console.ReadLine());

double weigthIndexMax = weigth + (weigth * 0.1);
double weigthIndexMin = weigth - (weigth * 0.1);
double index = heigth - 100;

if (weigthIndexMax > index && weigthIndexMin < index)
{
    Console.WriteLine("Норма");
}
else if (weigthIndexMax > index)
{
    Console.WriteLine("Нужно похудеть!");
}
else if (weigthIndexMin < index)
{
    Console.WriteLine("Нужно поправиться!");
}
