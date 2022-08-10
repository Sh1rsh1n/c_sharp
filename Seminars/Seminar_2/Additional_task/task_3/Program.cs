/*
Вычисляется и выводится в таблицу с шагом 10 км стоимость поездки
на автомобиле в зависимости от расстояния S (10 – 90 км). С клавиатуры
вводятся: b - расход бензина на 100 км, c - цена бензина за 1л литр. (цикл for)
*/

int distance = 130;
Console.WriteLine("distance = " + distance);

double consumeFuel = double.Parse(Console.ReadLine());
double fuelCost = double.Parse(Console.ReadLine());

double price = 0;

for(int i = 10; i <= distance; i += 10)
{
    price = (consumeFuel * i / 100) * fuelCost; 
    Console.WriteLine($"way = {i}, price = {price}");
}