/*
Повторяются вычисления и вывод площади круга по вводимому радиусу r
до тех пор, пока не введена буква z или Z .
*/

const double pi = 3.14;

bool value = true;
double radius = 0;

while (value)
{
    Console.WriteLine("Введите число: ");
    
    string str = Console.ReadLine();
    value = double.TryParse(str, out radius);
    double squar = pi * (radius * radius);

    Console.WriteLine($"squar = {squar}");
}