/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
    присваиваем рандомные значения от -10 до 10, координатам первой и второй точки
*/
Console.WriteLine("point one");
int p1x = new Random().Next(-10, 10);
Console.WriteLine($"point x: {p1x}");
int p1y = new Random().Next(-10, 10);
Console.WriteLine($"point y: {p1y}");
int p1z = new Random().Next(-10, 10);
Console.WriteLine($"point z: {p1z}");
Console.WriteLine("point two");
int p2x = new Random().Next(-10, 10);
Console.WriteLine($"point y: {p2x}");
int p2y = new Random().Next(-10, 10);
Console.WriteLine($"point y: {p2y}");
int p2z = new Random().Next(-10, 10);
Console.WriteLine($"point z: {p2z}");

/*
    Выводим в консоль результаты вычислений метода distance.
*/
Console.WriteLine($"result: {distance(p1x, p2x, p1y, p2y, p1z, p2z)}");

/*
    метод distance
    на вход принимает координаты 2х точек
    по теореме Пифагора, расчитываем расстояние между 1ой и 2ой точкой
    рассчеты выполняем с помощью двух статических методов Sqrt(корень) и Pow(возведение в степень) класса Math 
*/
double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}